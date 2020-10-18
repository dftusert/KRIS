using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.product
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
            this.dictionaryTableAdapter1.Fill(this.typeForCombobox.Dictionary);
            this.dictionaryTableAdapter.Fill(this.oKEIForCombobox.Dictionary);
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
                string name = tbName.Text;
                int okei_id = 0;
                int type_id = 0;
                int.TryParse(cbOKEI.SelectedValue.ToString(), out okei_id);
                int.TryParse(cbType.SelectedValue.ToString(), out type_id);
                if (okei_id == 0 || type_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                             where p.vendor_code == vendorCode && p.name == name && p.okei_id == okei_id && p.type_id == type_id && p.deleted == null
                                             select p).FirstOrDefault();
                if (product != null) MessageBox.Show("Присутствует в списке удаленных", "Информация");
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
                string name = tbName.Text;
                int okei_id = 0;
                int type_id = 0;
                int.TryParse(cbOKEI.SelectedValue.ToString(), out okei_id);
                int.TryParse(cbType.SelectedValue.ToString(), out type_id);
                if (okei_id == 0 || type_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Product product = (from p in db.Product
                                   where p.vendor_code == vendorCode && p.name == name && p.okei_id == okei_id && p.type_id == type_id && p.deleted == null
                                   select p).FirstOrDefault();

                if (product == null)
                {
                    MessageBox.Show("Отсутствует в списке удаленных", "Информация");
                    return;
                }

                product.deleted = null;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Recovery product: vendor_code - {0}, name - {1}, okei - {2}, type - {3}, recommended_price - {4}, remainder - {5}",
                                           vendorCode, name, cbOKEI.GetItemText(cbOKEI.SelectedItem), cbType.GetItemText(cbType.SelectedItem), product.recommended_price, product.remainder);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут покупателя или поставщика не был восстановлен", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут покупателя или поставщика успешно восстановлен в системе", "Информация");
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
                string name = tbName.Text;
                int okei_id = 0;
                int type_id = 0;
                int.TryParse(cbOKEI.SelectedValue.ToString(), out okei_id);
                int.TryParse(cbType.SelectedValue.ToString(), out type_id);
                if (okei_id == 0 || type_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }
                int recommended_price = 0;
                int remainder = 0;
                int.TryParse(tbRecPrice.Text, out recommended_price);
                int.TryParse(tbRemainder.Text, out remainder);
                if (recommended_price == 0)
                {
                    MessageBox.Show("Цена введена неверно", "Информация");
                    return;
                }
                if (remainder == 0)
                {
                    MessageBox.Show("Остаток на складе введен неверно", "Информация");
                    return;
                }

                Product product = new Product();
                product.vendor_code = vendorCode;
                product.name = name;
                product.okei_id = okei_id;
                product.type_id = type_id;
                product.recommended_price = recommended_price;
                product.remainder = remainder;

                db.Product.Add(product);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Add product: vendor_code - {0}, name - {1}, okei - {2}, type - {3}, recommended_price - {4}, remainder - {5}",
                                            vendorCode, name, cbOKEI.GetItemText(cbOKEI.SelectedItem), cbType.GetItemText(cbType.SelectedItem), product.recommended_price, product.remainder);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, товар не был создан", "Информация");
                    return;
                }

                MessageBox.Show("Товар успешно создан в системе", "Информация");
                this.Close();
            }
        }

        private bool fillCheck(bool ignValue = false)
        {
            if (ignValue)
            {
                if (tbVendorCode.Text == "" || tbName.Text == "" || cbOKEI.SelectedValue.ToString() == "" || cbType.SelectedValue.ToString() == "") return false;
                return true;
            }
            else
            {
                if (tbVendorCode.Text == "" || tbName.Text == "" || cbOKEI.SelectedValue.ToString() == "" || cbType.SelectedValue.ToString() == "" || tbRecPrice.Text == "" || tbRemainder.Text == "") return false;
                return true;
            }
        }
    }
}
