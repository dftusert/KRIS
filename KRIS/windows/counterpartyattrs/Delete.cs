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
    public partial class Delete : Form
    {
        private string username;
        private string inn;
        private string attr_name;
        private string attr_value;

        public Delete(string username, string inn, string attr_name, string attr_value)
        {
            InitializeComponent();

            this.username = username;
            this.inn = inn;
            this.attr_name = attr_name;
            this.attr_value = attr_value;

            tbINN.Text = inn;
            tbAttr.Text = attr_name;
            tbVal.Text = attr_value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                Counterparty counterparty = (from c in db.Counterparty
                                            where c.inn == inn && c.deleted == null
                                            select c).FirstOrDefault();
                if(counterparty == null)
                {
                    MessageBox.Show("Не удалось найти покупателя или поставщика, удаление невозможно", "Информация");
                    return;
                }

                Dictionary dict = (from _d in db.Dictionary
                                   from _e in db.Entity
                                   where _d.entity_id == _e.id && _d.term_name == attr_name && _e.name == "counterparty"
                                   select _d).FirstOrDefault();

                if (dict == null)
                {
                    MessageBox.Show("Не удалось найти атрибут, удаление невозможно", "Информация");
                    return;
                }

                CounterpartyAttrs cpa = (from _cpa in db.CounterpartyAttrs
                                         where _cpa.counterparty_id == counterparty.id && _cpa.attr_id == dict.id && _cpa.attr_value == attr_value && _cpa.deleted == null
                                         select _cpa).FirstOrDefault();
                if (cpa == null)
                {
                    MessageBox.Show("Ошибка получения атрибута, возможно он был удален");
                    return;
                }

                cpa.deleted = "Y";

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Delete counterparty attrs: counterparty(name - {0}, inn - {1}, kpp - {2}), attr (name - {3} id - {4}, value - {5})",
                                           counterparty.name, counterparty.inn, counterparty.kpp,
                                           dict.term_name, cpa.attr_id, cpa.attr_value);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, атрибут покупателя или поставщика не был удален", "Информация");
                    return;
                }

                MessageBox.Show("Атрибут покупателя или поставщика успешно удален из системы", "Информация");
            }
        }
    }
}
