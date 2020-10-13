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
    public partial class Modify : Form
    {
        private string username;
        private Product product;
        private ProductAttrs pa;
        public Modify(string username, Product product, ProductAttrs pa)
        {
            InitializeComponent();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "attrsForCombobox.Dictionary". При необходимости она может быть перемещена или удалена.
            this.dictionaryTableAdapter.Fill(this.attrsForCombobox.Dictionary);

            this.username = username;
            this.product = product;
            this.pa = pa;

            tbVendorCode.Text = product.vendor_code;
            tbVal.Text = pa.attr_value;

            using (DBCtx db = new DBCtx())
            {
                Dictionary attr = (from d in db.Dictionary
                                   where d.id == pa.attr_id
                                   select d).FirstOrDefault();

                if (attr == null)
                {
                    MessageBox.Show("Ошибка получения атрибута", "Информация");
                    this.Close();

                }

                if (attr.deleted == null)
                {
                    cbAttr.SelectedIndex = cbAttr.FindStringExact(attr.term_name);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Возможно данный атрибут устарел, редактировать только значение (нажать да) или обновить на новый атрибут (нажать нет)", "Информация", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cbAttr.Enabled = false;
                    }
                    else
                    {
                        cbAttr.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                ProductAttrs nwpa = (from _pa in db.ProductAttrs
                                           where _pa.product_id == pa.product_id && _pa.attr_id == pa.attr_id && _pa.attr_value == pa.attr_value && _pa.deleted == null
                                           select _pa).FirstOrDefault();
                if (nwpa == null)
                {
                    MessageBox.Show("Ошибка получения атрибута, возможно он был удален");
                    return;
                }

                if (cbAttr.Enabled)
                {
                    int attr_id = 0;
                    int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                    if (attr_id == 0)
                    {
                        MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                        return;
                    }

                    nwpa.attr_id = attr_id;
                }

                nwpa.attr_value = tbVal.Text;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Update product attrs: product(vendorCode - {0}, inn - {1}), prev (id - {2}, value - {3}) new (id - {4}, value - {5})",
                                           product.vendor_code, product.name,
                                           pa.attr_id, pa.attr_value, nwpa.attr_id, nwpa.attr_value);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут товара не был обновлен", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут товара успешно обновлен в системе", "Информация");
            }
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "attrsForCombobox.Dictionary". При необходимости она может быть перемещена или удалена.
            this.dictionaryTableAdapter.Fill(this.attrsForCombobox.Dictionary);
        }
    }
}
