using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.productattrs
{
    public partial class Add : Form
    {
        private string username;
        public Add(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.dictionaryTableAdapter.Fill(this.attrsForCombobox.Dictionary);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!fillCheck(true))
            {
                MessageBox.Show("Одно или несколько полей не заполнены", "Информация");
                return;
            }
            using (DBCtx db = new DBCtx())
            {
                string vendorCode = tbVendorCode.Text;
                int attr_id = 0;
                int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                if (attr_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                             where p.vendor_code == vendorCode && p.deleted == null
                                             select p).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Товар не найден, возможно он был удален", "Информация");
                    return;
                }

                ProductAttrs pa = (from _pa in db.ProductAttrs
                                         where _pa.product_id == product.id && _pa.attr_id == attr_id && _pa.deleted != null
                                         select _pa).FirstOrDefault();

                if (pa != null) MessageBox.Show("Присутствует в списке удаленных", "Информация");
                else MessageBox.Show("Отсутствует в списке удаленных", "Информация");
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            if (!fillCheck(true))
            {
                MessageBox.Show("Одно или несколько полей не заполнены", "Информация");
                return;
            }
            using (DBCtx db = new DBCtx())
            {
                string vendorCode = tbVendorCode.Text;
                int attr_id = 0;
                int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                if (attr_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                             where p.vendor_code == vendorCode && p.deleted == null
                                             select p).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Товар не найден, возможно он был удален", "Информация");
                    return;
                }

                ProductAttrs pa = (from _pa in db.ProductAttrs
                                         where _pa.product_id == _pa.product_id && _pa.attr_id == attr_id && _pa.deleted != null
                                         select _pa).FirstOrDefault();

                if (pa == null)
                {
                    MessageBox.Show("Отсутствует в списке удаленных", "Информация");
                    return;
                }

                pa.deleted = null;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Recovery product attribute: counterparty(vendorCode - {0}, name - {1}), attribute(attr - {2})",
                                           product.vendor_code, product.name, cbAttr.GetItemText(cbAttr.SelectedItem));
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут товара не был восстановлен", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут товара успешно восстановлен в системе", "Информация");
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!fillCheck())
            {
                MessageBox.Show("Одно или несколько полей не заполнены", "Информация");
                return;
            }
            using (DBCtx db = new DBCtx())
            {
                string vendorCode = tbVendorCode.Text;
                int attr_id = 0;
                int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                string val = tbVal.Text;

                if (attr_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                             where p.vendor_code == vendorCode && p.deleted == null
                                             select p).FirstOrDefault();
                if (product == null)
                {
                    MessageBox.Show("Товар не найден, возможно он был удален", "Информация");
                    return;
                }

                ProductAttrs pa = new ProductAttrs();
                pa.attr_id = attr_id;
                pa.product_id = product.id;
                pa.attr_value = val;
                db.ProductAttrs.Add(pa);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Add product attribute: counterparty(vendorCode - {0}, name - {1}), attribute(attr - {2}, value - {3})",
                                           product.vendor_code, product.name, cbAttr.GetItemText(cbAttr.SelectedItem), val);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут товара не был создан", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут товара успешно создан в системе", "Информация");
                this.Close();
            }
        }

        private bool fillCheck(bool ignValue = false)
        {
            if (ignValue)
            {
                if (tbVendorCode.Text == "" || cbAttr.SelectedValue.ToString() == "") return false;
                return true;
            }
            else
            {
                if (tbVendorCode.Text == "" || cbAttr.SelectedValue.ToString() == "" || tbVal.Text == "") return false;
                return true;
            }
        }
    }
}
