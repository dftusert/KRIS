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

namespace KRIS.windows.counterpartyattrs
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "attrsForComboBox.Dictionary". При необходимости она может быть перемещена или удалена.
            this.dictionaryTableAdapter.Fill(this.attrsForComboBox.Dictionary);
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
                string inn = tbINN.Text;
                int attr_id = 0;
                int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                if(attr_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Counterparty counterparty = (from c in db.Counterparty
                                  where c.inn == inn && c.deleted == null
                                  select c).FirstOrDefault();
                if(counterparty == null)
                {
                    MessageBox.Show("Покупатель или поставщик не найден, возможно он был удален", "Информация");
                    return;
                }

                CounterpartyAttrs cpa = (from ca in db.CounterpartyAttrs
                                             where ca.counterparty_id == counterparty.id && ca.attr_id == attr_id && ca.deleted != null
                                             select ca).FirstOrDefault();

                if (cpa != null) MessageBox.Show("Присутствует в списке удаленных", "Информация");
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
                string inn = tbINN.Text;
                int attr_id = 0;
                int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                if (attr_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Counterparty counterparty = (from c in db.Counterparty
                                             where c.inn == inn && c.deleted == null
                                             select c).FirstOrDefault();
                if (counterparty == null)
                {
                    MessageBox.Show("Покупатель или поставщик не найден, возможно он был удален", "Информация");
                    return;
                }

                CounterpartyAttrs cpa = (from ca in db.CounterpartyAttrs
                                         where ca.counterparty_id == counterparty.id && ca.attr_id == attr_id && ca.deleted != null
                                         select ca).FirstOrDefault();

                if (cpa == null)
                {
                    MessageBox.Show("Отсутствует в списке удаленных", "Информация");
                    return;
                }

                cpa.deleted = null;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Recovery counterparty attribute: counterparty(name - {0}, inn - {1}, kpp - {2}), attribute(attr - {3})",
                                           counterparty.name, counterparty.inn, counterparty.kpp, cbAttr.GetItemText(cbAttr.SelectedItem));
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
                string inn = tbINN.Text;
                int attr_id = 0;
                int.TryParse(cbAttr.SelectedValue.ToString(), out attr_id);
                string val = tbVal.Text;

                if (attr_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Counterparty counterparty = (from c in db.Counterparty
                                             where c.inn == inn && c.deleted == null
                                             select c).FirstOrDefault();
                if (counterparty == null)
                {
                    MessageBox.Show("Покупатель или поставщик не найден, возможно он был удален", "Информация");
                    return;
                }

                CounterpartyAttrs cpa = new CounterpartyAttrs();
                cpa.attr_id = attr_id;
                cpa.counterparty_id = counterparty.id;
                cpa.attr_value = val;
                db.CounterpartyAttrs.Add(cpa);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Add counterparty attribute: counterparty(name - {0}, inn - {1}, kpp - {2}), attribute(attr - {3}, value - {4})",
                                           counterparty.name, counterparty.inn, counterparty.kpp, cbAttr.GetItemText(cbAttr.SelectedItem), val);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут покупателя или поставщика не был создан", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут покупателя или поставщика успешно создан в системе", "Информация");
            }
        }


        private bool fillCheck(bool ignValue = false)
        {
            if (ignValue)
            {
                if (tbINN.Text == "" || cbAttr.SelectedValue.ToString() == "") return false;
                return true;
            }
            else
            {
                if (tbINN.Text == "" || cbAttr.SelectedValue.ToString() == "" || tbVal.Text == "") return false;
                return true;
            }
        }
    }
}
