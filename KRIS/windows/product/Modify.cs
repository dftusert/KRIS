using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.product
{
    public partial class Modify : Form
    {
        private string username;
        private Product oldProduct;
        public Modify(string username, Product oldProduct)
        {
            InitializeComponent();

            this.username = username;
            this.oldProduct = oldProduct;

            this.dictionaryTableAdapter1.Fill(this.typeForCombobox.Dictionary);
            this.dictionaryTableAdapter.Fill(this.oKEIForCombobox.Dictionary);

            tbVendorCode.Text = oldProduct.vendor_code;
            tbName.Text = oldProduct.name;
            tbRecPrice.Text = oldProduct.recommended_price.ToString();
            tbRemainder.Text = oldProduct.remainder.ToString();

            using (DBCtx db = new DBCtx())
            {
                Dictionary okei = (from d in db.Dictionary
                                   where d.id == oldProduct.okei_id
                                   select d).FirstOrDefault();

                if (okei == null)
                {
                    MessageBox.Show("Ошибка получения атрибута", "Информация");
                    this.Close();

                }

                if (okei.deleted == null)
                {
                    cbOKEI.SelectedIndex = cbOKEI.FindStringExact(okei.term_name);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Возможно данный атрибут устарел, редактировать только значение (нажать да) или обновить на новый атрибут (нажать нет)", "Информация", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cbOKEI.Enabled = false;
                    }
                    else
                    {
                        cbOKEI.SelectedIndex = 0;
                    }
                }

                Dictionary type = (from d in db.Dictionary
                                   where d.id == oldProduct.type_id
                                   select d).FirstOrDefault();

                if (type == null)
                {
                    MessageBox.Show("Ошибка получения атрибута", "Информация");
                    this.Close();

                }

                if (type.deleted == null)
                {
                    cbType.SelectedIndex = cbType.FindStringExact(type.term_name);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Возможно данный атрибут устарел, редактировать только значение (нажать да) или обновить на новый атрибут (нажать нет)", "Информация", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cbType.Enabled = false;
                    }
                    else
                    {
                        cbType.SelectedIndex = 0;
                    }
                }
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                int recPrice = 0;
                int.TryParse(tbRecPrice.Text, out recPrice);
                if (recPrice == 0)
                {
                    MessageBox.Show("Рекомендованная цена не число", "Информация");
                    return;
                }
                int remainder = 0;
                int.TryParse(tbRemainder.Text, out remainder);
                if (remainder == 0)
                {
                    MessageBox.Show("Остаток на складе не число", "Информация");
                    return;
                }

                Product nwproduct = (from p in db.Product
                                               where p.vendor_code == oldProduct.vendor_code &&
                                                     p.name == oldProduct.name &&
                                                     p.okei_id == oldProduct.okei_id &&
                                                     p.type_id == oldProduct.type_id &&
                                                     p.recommended_price == oldProduct.recommended_price &&
                                                     p.remainder == oldProduct.remainder &&
                                                     p.deleted == null
                                           select p).FirstOrDefault();
                if (nwproduct == null)
                {
                    MessageBox.Show("Ошибка получения атрибута, возможно он был удален");
                    return;
                }

                if (cbOKEI.Enabled)
                {
                    int okei_id = 0;
                    int.TryParse(cbOKEI.SelectedValue.ToString(), out okei_id);
                    if (okei_id == 0)
                    {
                        MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                        return;
                    }

                    nwproduct.okei_id = okei_id;
                }

                if (cbType.Enabled)
                {
                    int type_id = 0;
                    int.TryParse(cbType.SelectedValue.ToString(), out type_id);
                    if (type_id == 0)
                    {
                        MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                        return;
                    }

                    nwproduct.type_id = type_id;
                }

                nwproduct.vendor_code = tbVendorCode.Text;
                nwproduct.name = tbName.Text;
                nwproduct.recommended_price = recPrice;
                nwproduct.remainder = remainder;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Update product: vendor_code - {0}, name - {1}, okei - {2}, type - {3}, recprice - {4}, remainder - {5}, prev vendor_code - {6}, name - {7}, recprice - {8}, remainder - {9}) new (id - {5}, value - {6}",
                                           nwproduct.vendor_code, nwproduct.name, cbOKEI.GetItemText(cbOKEI.SelectedItem), cbType.GetItemText(cbType.SelectedItem), nwproduct.recommended_price, nwproduct.remainder,
                                           oldProduct.vendor_code, oldProduct.name, oldProduct.recommended_price, oldProduct.remainder);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, товар не был обновлен", "Информация");
                    return;
                }

                MessageBox.Show("Товар успешно обновлен в системе", "Информация");
                this.Close();
            }
        }
    }
}
