using KRIS.database;
using KRIS.database.entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.bid
{
    public partial class Modify : Form
    {
        private string username;
        private Bid oldBid;
        public Modify(string username, Bid oldBid)
        {
            InitializeComponent();

            this.username = username;
            this.oldBid = oldBid;
            this.dictionaryTableAdapter.Fill(this.statusForCombobox.Dictionary);

            tbBidNumber.Text = oldBid.bid_number;
            tbCreateDate.Text = oldBid.create_date.ToString();
            tbStatusDate.Text = oldBid.status_date.ToString();
            tbINN.Text = oldBid.Counterparty.inn;

            using (DBCtx db = new DBCtx())
            {
                Dictionary status = (from d in db.Dictionary
                                     from e in db.Entity
                                     where d.id == oldBid.status_id && d.target == "STATUS" && e.id == d.entity_id && e.name == "bid"
                                     select d).FirstOrDefault();

                if (status == null)
                {
                    MessageBox.Show("Ошибка получения атрибута status", "Информация");
                    this.Close();

                }

                if (status.deleted == null)
                {
                    cbStatus.SelectedIndex = cbStatus.FindStringExact(status.term_name);
                }
                else
                {
                    MessageBox.Show("Атрибут устарел, сброс значения", "Информация");
                    cbStatus.SelectedIndex = 0;
                }

                Dictionary type = (from d in db.Dictionary
                                   from e in db.Entity
                                   where d.id == oldBid.type_id && d.target == "TYPE" && e.id == d.entity_id && e.name == "bid"
                                   select d).FirstOrDefault();

                if (type == null)
                {
                    MessageBox.Show("Ошибка получения атрибута type", "Информация");
                    this.Close();

                }

                if (type.deleted == null)
                {
                    tbType.Text = type.term_name;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            using (DBCtx db = new DBCtx())
            {
                Bid nwbid = (from b in db.Bid
                             where b.bid_number == oldBid.bid_number &&
                                   b.create_date == oldBid.create_date &&
                                   b.status_date == oldBid.status_date &&
                                   b.status_id == oldBid.status_id &&
                                   b.counterparty_id == oldBid.counterparty_id &&
                                   b.type_id == oldBid.type_id
                             select b).FirstOrDefault();
                if (nwbid == null)
                {
                    MessageBox.Show("Ошибка получения атрибута, возможно он был удален");
                    return;
                }

                int status_id = 0;
                int.TryParse(cbStatus.SelectedValue.ToString(), out status_id);
                if (status_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                DateTime status_time = DateTime.Now;
                nwbid.status_id = status_id;
                nwbid.status_date = status_time;
                tbStatusDate.Text = status_time.ToString();

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Update bid: bidNumber - {0}, new status - {1}",
                                          nwbid.bid_number, cbStatus.GetItemText(cbStatus.SelectedItem));
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, заявка не была обновлена", "Информация");
                    return;
                }

                MessageBox.Show("Заявка успешно обновлена в системе", "Информация");
                this.Close();
            }
        }
    }
}
