using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.counterparty
{
    public partial class Add : Form
    {
        private string username;
        public Add(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!fillCheck())
            {
                MessageBox.Show("Одно или несколько полей не заполнены", "Информация");
                return;
            }
            if (check()) MessageBox.Show("Присутствует в списке удаленных", "Информация");
            else MessageBox.Show("Отсутствует в списке удаленных", "Информация");
        }

        private bool check()
        {
            string name = tbName.Text;
            string inn = tbINN.Text;
            string kpp = tbKPP.Text;

            bool flag = false;
            using (DBCtx db = new DBCtx())
            {
                Counterparty counterparty = (from c in db.Counterparty
                                            where c.name == name && c.inn == inn && c.kpp == kpp && c.deleted != null
                                            select c).FirstOrDefault();
                if (counterparty != null) flag = true;
            }
            return flag;
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            if (!fillCheck())
            {
                MessageBox.Show("Одно или несколько полей не заполнены, восстановление невозможно", "Информация");
                return;
            }

            string name = tbName.Text;
            string inn = tbINN.Text;
            string kpp = tbKPP.Text;

            using (DBCtx db = new DBCtx())
            {
                Counterparty counterparty = (from c in db.Counterparty
                                             where c.name == name && c.inn == inn && c.kpp == kpp && c.deleted != null
                                             select c).FirstOrDefault();
                if (counterparty == null)
                {
                    MessageBox.Show("Покупатель или поставщик отсутствует в списке удаленных, восстановление невозможно", "Информация");
                    return;
                }

                counterparty.deleted = null;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = "Recovery counterparty: " + counterparty.name + ", " + counterparty.inn + ", " + counterparty.kpp;
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                } catch(Exception)
                {
                    MessageBox.Show("Произошла ошибка, покупатель или поставщик не был восстановлен", "Информация");
                    return;
                }

                MessageBox.Show("Покупатель или поставщик успешно восстановлен в системе", "Информация");
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!fillCheck())
            {
                MessageBox.Show("Одно или несколько полей не заполнены, восстановление невозможно", "Информация");
                return;
            }

            string name = tbName.Text;
            string inn = tbINN.Text;
            string kpp = tbKPP.Text;

            using (DBCtx db = new DBCtx())
            {
                Counterparty counterparty = (from c in db.Counterparty
                                             where c.name == name && c.inn == inn && c.kpp == kpp && c.deleted == null
                                             select c).FirstOrDefault();

                if(counterparty != null)
                {
                    MessageBox.Show("Данный покупатель или поставщик существует и не находится в списке удаленных, добавление невозможно", "Информация");
                    return;
                }

                counterparty = new Counterparty();
                counterparty.name = name;
                counterparty.inn = inn;
                counterparty.kpp = kpp;

                db.Counterparty.Add(counterparty);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = "Added counterparty: " + counterparty.name + ", " + counterparty.inn + ", " + counterparty.kpp;
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, покупатель или поставщик не был добавлен", "Информация");
                    return;
                }
            }

            MessageBox.Show("Покупатель или поставщик успешно добавлен в систему", "Информация");
            this.Close();
        }

        private bool fillCheck()
        {
            if (tbName.Text == "" || tbINN.Text == "" || tbKPP.Text == "") return false;
            return true;
        }
    }
}
