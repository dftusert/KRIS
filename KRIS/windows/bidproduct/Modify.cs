using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.bidproduct
{
    public partial class Modify : Form
    {
        private string username;

        private int prevCount;
        private int prevPrice;
        public Modify(string username, string bidNumber, string vendorCode, int count, int price)
        {
            InitializeComponent();

            this.username = username;
            prevCount = count;
            prevPrice = price;

            tbBidNumber.Text = bidNumber;
            tbVendorCode.Text = vendorCode;
            tbCount.Text = count.ToString();
            tbPrice.Text = price.ToString();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.product._Product);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string bidNumber = tbBidNumber.Text;
            string vendorCode = tbVendorCode.Text;
            int count = 0, price = 0;
            int.TryParse(tbCount.Text, out count);
            int.TryParse(tbPrice.Text, out price);

            if (count <= 0)
            {
                MessageBox.Show("Количество товара введено неверно", "Информация");
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Цена товара введена неверно", "Информация");
            }

            using(DBCtx db = new DBCtx())
            {
                Bid bid = (from b in db.Bid
                           where b.bid_number == bidNumber
                           select b).FirstOrDefault();

                if(bid == null)
                {
                    MessageBox.Show("Указанная заявка не найдена", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                   where p.vendor_code == vendorCode && p.deleted == null
                                   select p).FirstOrDefault();

                if(product == null)
                {
                    MessageBox.Show("Указанный товар не найден", "Информация");
                    return;
                }

                BidProduct bp = (from _bp in db.BidProduct
                                 where _bp.bid_id == bid.id && _bp.product_id == product.id && _bp.product_count == prevCount && _bp.product_price == prevPrice
                                 select _bp).FirstOrDefault();

                if (bp == null)
                {
                    MessageBox.Show("Указанная позиция не найдена", "Информация");
                    return;
                }

                if (product.remainder < count - prevCount)
                {
                    MessageBox.Show("Количество товара на складе меньше чем указано, указать такое большое количество товара нельзя", "Информация");
                    return;
                }

                if (price != product.recommended_price)
                {
                    DialogResult result = MessageBox.Show("Рекомендованная цена отличается от введенной, оставить цену такой (нажмите да) или изменить (нажмите нет)", "Информация", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                bp.product_count = count;
                bp.product_price = price;

                product.remainder -= count - prevCount;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Modify product to bid: bidNumber - {0}, vendorCode - {1}, count - {2}, price - {3}, prevCount - {4}, prevPrice - {5}",
                                           bid.bid_number, product.vendor_code, count, price, prevCount, prevPrice);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, товар в заявке не был обновлен", "Информация");
                    return;
                }

                this.productTableAdapter.Fill(this.product._Product);

                MessageBox.Show("Товар в заявке был успешно обновлен", "Информация");
                this.Close();
            }
        }
    }
}
