using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.bidproduct
{
    public partial class Add : Form
    {
        private string username;
        public Add(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bidNumber = tbBidNumber.Text;
            string vendorCode = tbVendorCode.Text;
            int count = 0, price = 0;
            int.TryParse(tbCount.Text, out count);
            int.TryParse(tbPrice.Text, out price);

            if(count <= 0)
            {
                MessageBox.Show("Количество товара введено неверно", "Информация");
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Цена товара введена неверно", "Информация");
                return;
            }

            using (DBCtx db = new DBCtx())
            {
                Bid bid = (from b in db.Bid
                           where b.bid_number == bidNumber
                           select b).FirstOrDefault();

                if(bid == null)
                {
                    MessageBox.Show("Заявка не найдена", "Информация");
                    return;
                }

                Dictionary status = (from d in db.Dictionary
                                     from _e in db.Entity
                                     where d.id == bid.status_id && d.target == "STATUS" && _e.id == d.entity_id && _e.name == "bid" && d.deleted == null
                                     select d).FirstOrDefault();

                if(status == null)
                {
                    MessageBox.Show("Статус заявки не найден", "Информация");
                    return;
                }

                if(status.term_name == "Закрыт")
                {
                    MessageBox.Show("Нельзя добавлять товар в закрытую заявку", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                   where p.vendor_code == vendorCode && p.deleted == null
                                   select p).FirstOrDefault();

                if(product == null)
                {
                    MessageBox.Show("Товар с указанным артикулом не найден", "Информация");
                    return;
                }

                if(product.remainder < count)
                {
                    MessageBox.Show("Количество товара на складе меньше чем указано, добавить такое большое количество товара нельзя", "Информация");
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

                BidProduct bp = new BidProduct();
                bp.bid_id = bid.id;
                bp.product_id = product.id;
                bp.product_count = count;
                bp.product_price = price;

                product.remainder -= count;

                db.BidProduct.Add(bp);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Add product to bid: bidNumber - {0}, vendorCode - {1}, count - {2}, price - {3}",
                                           bid.bid_number, product.vendor_code, count, price);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, товар не был добавлен в заявку", "Информация");
                    return;
                }
               
                this.productTableAdapter.Fill(this.product._Product);
                this.bidTableAdapter.Fill(this.bid._Bid);

                MessageBox.Show("Товар был успешно добавлен в заявку", "Информация");
                this.Close();
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {      
            this.productTableAdapter.Fill(this.product._Product);
            this.bidTableAdapter.Fill(this.bid._Bid);
        }
    }
}
