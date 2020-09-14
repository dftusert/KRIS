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
    public partial class Delete : Form
    {
        private string username;
        private Counterparty oldCounterparty;
        public Delete(string username, Counterparty oldCounterparty)
        {
            InitializeComponent();

            this.username = username;
            this.oldCounterparty = oldCounterparty;

            tbName.Text = oldCounterparty.name;
            tbINN.Text = oldCounterparty.inn;
            tbKPP.Text = oldCounterparty.kpp;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                Counterparty counterparty = (from c in db.Counterparty
                                             where c.name == oldCounterparty.name && c.inn == oldCounterparty.inn && c.kpp == oldCounterparty.kpp
                                             select c).FirstOrDefault();
                if (counterparty == null)
                {
                    MessageBox.Show("При удалении покупателя или поставщика произошла ошибка, удаление отклонено", "Информация");
                    return;
                }

                counterparty.deleted = "Y";
                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Deleted counterparty: name - {0}, inn - {1}, kpp - {2}", counterparty.name, counterparty.inn, counterparty.kpp);
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, покупатель или поставщик не был удален", "Информация");
                    return;
                }

                MessageBox.Show("Покупатель или поставщик успешно удален из системы", "Информация");
            }
        }
    }
}
