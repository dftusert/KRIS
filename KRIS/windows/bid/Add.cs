using KRIS.database;
using KRIS.database.entity;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KRIS.windows.bid
{
    public partial class Add : Form
    {
        private string username;
        private string bidNumber;
        public Add(string username)
        {
            InitializeComponent();

            this.username = username;
            this.dictionaryTableAdapter1.Fill(this.typeForCombobox.Dictionary);
            this.dictionaryTableAdapter.Fill(this.statusForCombobox.Dictionary);

            using (DBCtx db = new DBCtx())
            {
                Dictionary attr = (from d in db.Dictionary
                                   from e in db.Entity
                                   where d.entity_id == e.id && d.target == "STATUS" && d.deleted == null && e.name == "bid" && d.term_name == "Создан"
                                   select d).FirstOrDefault();

                if (attr == null)
                {
                    MessageBox.Show("Ошибка получения статуса заявки, не найдено \"Создан\"", "Информация");
                    this.Close();

                }

                cbStatus.SelectedIndex = cbStatus.FindStringExact(attr.term_name);
                bidNumber = Guid.NewGuid().ToString();
                tbBidNumber.Text = bidNumber;
            }

        }

        private void Add_Load(object sender, EventArgs e)
        {
            this.counterpartyTableAdapter.Fill(this.counterpartyDataSet.Counterparty);
            dgvCounterparty.Sort(dgvCounterparty.Columns[0], ListSortDirection.Descending);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbINN.Text == "")
            {
                MessageBox.Show("ИНН не заполнен", "Информация");
                return;
            }
            using (DBCtx db = new DBCtx())
            {
                int status_id, type_id;
                int.TryParse(cbStatus.SelectedValue.ToString(), out status_id);
                int.TryParse(cbType.SelectedValue.ToString(), out type_id);
                if (status_id == 0 || type_id == 0)
                {
                    MessageBox.Show("Ошибка выбора элемента списка", "Информация");
                    return;
                }

                Counterparty counterparty = (from c in db.Counterparty
                                             where c.inn == tbINN.Text && c.deleted == null
                                             select c).FirstOrDefault();
                if(counterparty == null)
                {
                    MessageBox.Show("Ошибка: покупатель или поставщик с заданным инн не существует или удален", "Информация");
                    return;
                }

                DateTime current = DateTime.Now;
                tbCreateDate.Text = current.ToString();
                tbStatusDate.Text = current.ToString();

                Bid bid = new Bid();
                bid.bid_number = bidNumber;
                bid.create_date = current;
                bid.status_id = status_id;
                bid.status_date = current;
                bid.type_id = type_id;
                bid.counterparty_id = counterparty.id;

                db.Bid.Add(bid);

                Logs log = new Logs();
                log.username = username;
                log.acttime = DateTime.Now;
                log.action = String.Format("Add bid: bid_number - {0}, create_date - {1}, type - {2}, counterparty - {3}",
                                            bidNumber, current.ToString(), cbType.GetItemText(cbType.SelectedItem), counterparty.ToString());
                db.Logs.Add(log);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, заявка не была создана", "Информация");
                    return;
                }

                MessageBox.Show("Заявка успешно создана в системе", "Информация");
                this.Close();
            }
        }
    }
}
