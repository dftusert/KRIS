using KRIS.database;
using KRIS.database.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIS.windows.product
{
    public partial class Delete : Form
    {
        private string username;
        private string vendor_code;
        private string name;
        private string okei;
        private string type;
        private int recPrice;
        private int remainder;
        public Delete(string username, string vendor_code, string name, string okei, string type, int recPrice, int remainder)
        {
            InitializeComponent();

            this.username = username;
            this.vendor_code = vendor_code;
            this.name = name;
            this.okei = okei;
            this.type = type;
            this.recPrice = recPrice;
            this.remainder = remainder;

            tbVendorCode.Text = vendor_code;
            tbName.Text = name;
            tbOKEI.Text = okei;
            tbType.Text = type;
            tbRecPrice.Text = recPrice.ToString();
            tbRemainder.Text = remainder.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                Dictionary okei_dict = (from _d in db.Dictionary
                                   from _e in db.Entity
                                   where _d.entity_id == _e.id && _d.term_name == okei && _e.name == "product"
                                   select _d).FirstOrDefault();

                Dictionary type_dict = (from _d in db.Dictionary
                                        from _e in db.Entity
                                        where _d.entity_id == _e.id && _d.term_name == type && _e.name == "product"
                                        select _d).FirstOrDefault();

                if(okei_dict == null || type_dict == null)
                {
                    MessageBox.Show("Ошибка справочника", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                   where p.vendor_code == vendor_code &&
                                         p.name == name &&
                                         p.okei_id == okei_dict.id &&
                                         p.type_id == type_dict.id &&
                                         p.recommended_price == recPrice &&
                                         p.remainder == remainder &&
                                         p.deleted == null
                                   select p).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Не удалось найти товар, возможно он был удален, удаление невозможно", "Информация");
                    return;
                }

                product.deleted = "Y";

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Delete product: vendor_code - {0}, name - {1}, okei - {2}, type - {3} recprice - {4}, remainder - {5}",
                                           product.vendor_code, product.name, okei, type, recPrice, remainder);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, товар не был удален", "Информация");
                    return;
                }

                MessageBox.Show("Товар успешно удален из системы", "Информация");
            }
        }
    }
}
