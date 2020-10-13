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

namespace KRIS.windows.productattrs
{
    public partial class Delete : Form
    {
        private string username;
        private string vendorCode;
        private string attr_name;
        private string attr_value;

        public Delete(string username, string vendorCode, string attr_name, string attr_value)
        {
            InitializeComponent();

            this.username = username;
            this.vendorCode = vendorCode;
            this.attr_name = attr_name;
            this.attr_value = attr_value;

            tbVendorCode.Text = vendorCode;
            tbAttr.Text = attr_name;
            tbVal.Text = attr_value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                Product product = (from p in db.Product
                                             where p.vendor_code == vendorCode && p.deleted == null
                                             select p).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Не удалось найти покупателя или поставщика, удаление невозможно", "Информация");
                    return;
                }

                Dictionary dict = (from _d in db.Dictionary
                                   from _e in db.Entity
                                   where _d.entity_id == _e.id && _d.term_name == attr_name && _e.name == "product"
                                   select _d).FirstOrDefault();

                if (dict == null)
                {
                    MessageBox.Show("Не удалось найти атрибут, удаление невозможно", "Информация");
                    return;
                }

                ProductAttrs pa = (from _pa in db.ProductAttrs
                                         where _pa.product_id == product.id && _pa.attr_id == dict.id && _pa.attr_value == attr_value && _pa.deleted == null
                                         select _pa).FirstOrDefault();
                if (pa == null)
                {
                    MessageBox.Show("Ошибка получения атрибута, возможно он был удален");
                    return;
                }

                pa.deleted = "Y";

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Delete product attrs: counterparty(vendorCode - {0}, name - {1}), attr (name - {2} id - {3}, value - {4})",
                                           product.vendor_code, product.name,
                                           dict.term_name, pa.attr_id, pa.attr_value);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут товара не был удален", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут товара успешно удален из системы", "Информация");
            }
        }
    }
}
