using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.counterpartyattrs
{
    public partial class Modify : Form
    {
        private string username;
        private Counterparty counterparty;
        private CounterpartyAttrs cpa;
        public Modify(string username, Counterparty counterparty, CounterpartyAttrs cpa)
        {
            InitializeComponent();

            this.dictionaryTableAdapter.Fill(this.attrsForComboBox.Dictionary);

            this.username = username;
            this.counterparty = counterparty;
            this.cpa = cpa;

            tbINN.Text = counterparty.inn;
            tbVal.Text = cpa.attr_value;

            using (DBCtx db = new DBCtx())
            {
                Dictionary attr = (from d in db.Dictionary
                                   where d.id == cpa.attr_id
                                   select d).FirstOrDefault();

                if(attr == null)
                {
                    MessageBox.Show("Ошибка получения атрибута", "Информация");
                    this.Close();

                }

                if(attr.deleted == null)
                {
                    cbAttr.SelectedIndex = cbAttr.FindStringExact(attr.term_name);
                } else
                {
                    DialogResult result = MessageBox.Show("Возможно данный атрибут устарел, редактировать только значение (нажать да) или обновить на новый атрибут (нажать нет)","Информация", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        cbAttr.Enabled = false;
                    } else
                    {
                        cbAttr.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                CounterpartyAttrs nwcpa = (from _cpa in db.CounterpartyAttrs
                                           where _cpa.counterparty_id == cpa.counterparty_id && _cpa.attr_id == cpa.attr_id && _cpa.attr_value == cpa.attr_value && _cpa.deleted == null
                                           select _cpa).FirstOrDefault();
                if(nwcpa == null)
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

                    nwcpa.attr_id = attr_id;
                }

                nwcpa.attr_value = tbVal.Text;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Update counterparty attrs: counterparty(name - {0}, inn - {1}, kpp - {2}), prev (id - {3}, value - {4}) new (id - {5}, value - {6})",
                                           counterparty.name, counterparty.inn, counterparty.kpp,
                                           cpa.attr_id, cpa.attr_value, nwcpa.attr_id, nwcpa.attr_value);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут покупателя или поставщика не был обновлен", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут покупателя или поставщика успешно обновлен в системе", "Информация");
                this.Close();
            }
        }
    }
}
