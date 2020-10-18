using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.bidproduct
{
    public partial class Delete : Form
    {
        private string username;
        public Delete(string username, string bidNumber, string vendorCode, int count, int price)
        {
            InitializeComponent();

            this.username = username;

            tbBidNumber.Text = bidNumber;
            tbVendorCode.Text = vendorCode;
            tbCount.Text = count.ToString();
            tbPrice.Text = price.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

            using (DBCtx db = new DBCtx())
            {
                Bid bid = (from b in db.Bid
                           where b.bid_number == bidNumber
                           select b).FirstOrDefault();

                if (bid == null)
                {
                    MessageBox.Show("Указанная заявка не найдена", "Информация");
                    return;
                }

                Dictionary status = (from d in db.Dictionary
                                     where d.id == bid.status_id
                                     select d).FirstOrDefault();

                if (status == null)
                {
                    MessageBox.Show("Ошибка получения статуса", "Информация");
                    return;
                }

                if(status.term_name == "Закрыт")
                {
                    MessageBox.Show("Нельзя удалять товар из закрытой заявки", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                   where p.vendor_code == vendorCode && p.deleted == null
                                   select p).FirstOrDefault();

                if (product == null)
                {
                    MessageBox.Show("Указанный товар не найден", "Информация");
                    return;
                }

                BidProduct bp = (from _bp in db.BidProduct
                                 where _bp.bid_id == bid.id && _bp.product_id == product.id && _bp.product_count == count && _bp.product_price == price
                                 select _bp).FirstOrDefault();

                if (bp == null)
                {
                    MessageBox.Show("Указанная позиция не найдена", "Информация");
                    return;
                }

                product.remainder += bp.product_count;
                db.BidProduct.Remove(bp);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Remove product from bid: bidNumber - {0}, vendorCode - {1}, count - {2}, price - {3}",
                                           bidNumber, vendorCode, count, price);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, товар в заявке не был удален", "Информация");
                    return;
                }

                MessageBox.Show("Товар в заявке был успешно удален", "Информация");
                this.Close();
            }
        }
    }
}
