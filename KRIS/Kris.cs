using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIS
{
    public partial class Kris : Form
    {
        private string username;
        private List<string> rolenames;

        public Kris(string username, List<string> rolenames)
        {
            InitializeComponent();

            this.username = username;
            this.rolenames = rolenames;

            if(!rolenames.Contains("counterparty"))
            {
                tabControl.TabPages.Remove(tabCounterparty);
                tabControl.TabPages.Remove(tabCounterpartyAttrs);
            }
            if (!rolenames.Contains("product"))
            {
                tabControl.TabPages.Remove(tabProduct);
                tabControl.TabPages.Remove(tabProductAttrs);
            }
            if (!rolenames.Contains("bid"))
            {
                tabControl.TabPages.Remove(tabBid);
                tabControl.TabPages.Remove(tabBidProduct);
            }
        }

        private void refreshCounterparty(object sender, EventArgs e)
        {
            refreshCounterparty();
        }

        private void refreshCounterparty()
        {
            this.counterpartyTableAdapter.Fill(this.counterpartyDataSet.Counterparty);
            dgvCounterparty.ClearSelection();
        }

        private void filterCounterparty(object sender, EventArgs e)
        {
            windows.counterparty.Filter filter = new windows.counterparty.Filter(ref counterpartyBindingSource);  
            filter.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed

            dgvCounterparty.ClearSelection();
            if (counterpartyBindingSource.Filter != null && counterpartyBindingSource.Filter != "")
                btnFilterC.BackColor = Color.Green;
            else
                btnFilterC.BackColor = ButtonBase.DefaultBackColor;
        }

        private void addCounterparty(object sender, EventArgs e)
        {
            windows.counterparty.Add add = new windows.counterparty.Add(username);
            add.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed

            refreshCounterparty();
        }

        private void Kris_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "counterpartyDataSet.Counterparty". При необходимости она может быть перемещена или удалена.
            this.counterpartyTableAdapter.Fill(this.counterpartyDataSet.Counterparty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "counterpartyDataSet.Counterparty". При необходимости она может быть перемещена или удалена.
            refreshCounterparty(sender, e);
        }
    }
}
