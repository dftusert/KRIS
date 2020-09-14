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

namespace KRIS.windows.counterparty
{
    public partial class Modify : Form
    {
        private string username;
        private Counterparty oldCounterparty;
        public Modify(string username, Counterparty oldCounterparty)
        {
            InitializeComponent();

            this.username = username;
            this.oldCounterparty = oldCounterparty;

            tbName.Text = oldCounterparty.name;
            tbINN.Text = oldCounterparty.inn;
            tbKPP.Text = oldCounterparty.kpp;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string inn = tbINN.Text;
            string kpp = tbKPP.Text;

            if (name == "" || inn == "" || kpp == "")
            {
                MessageBox.Show("Одно или несколько полей незаполнены, изменение невозможно", "Информация");
                return;
            }

            using (DBCtx db = new DBCtx())
            {
                Counterparty counterparty = (from c in db.Counterparty
                                             where c.name == oldCounterparty.name && c.inn == oldCounterparty.inn && c.kpp == oldCounterparty.kpp
                                             select c).FirstOrDefault();
                if(counterparty == null)
                {
                    MessageBox.Show("При изменении покупателя или поставщика произошла ошибка, изменение отклонено", "Информация");
                    return;
                }

                counterparty.name = name;
                counterparty.inn = inn;
                counterparty.kpp = kpp;

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Update counterparty: prev (name - {0}, inn - {1}, kpp - {2}), new (name - {3}, inn - {4}, kpp - {5})",
                                           oldCounterparty.name, oldCounterparty.inn, oldCounterparty.kpp,
                                           counterparty.name, counterparty.inn, counterparty.kpp);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, покупатель или поставщик не был обновлен", "Информация");
                    return;
                }

                MessageBox.Show("Покупатель или поставщик успешно обновлен в системе", "Информация");
            }
        }
    }
}
