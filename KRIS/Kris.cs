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

        private void modifyCounterparty(object sender, EventArgs e)
        {
            if((dgvCounterparty.SelectedRows == null || dgvCounterparty.SelectedRows.Count != 1) &&
               (dgvCounterparty.SelectedCells == null || dgvCounterparty.SelectedCells.Count != 1))
            {
                MessageBox.Show("Не выбрана запись для редактирования или выбрано больше одной", "Информация");
                return;
            }

            int rowIndex;
            if (dgvCounterparty.SelectedCells != null && dgvCounterparty.SelectedCells.Count == 1)
                rowIndex = dgvCounterparty.SelectedCells[0].RowIndex;
            else
                rowIndex = dgvCounterparty.SelectedRows[0].Index;

            Counterparty counterparty = new Counterparty();
            counterparty.name = dgvCounterparty.Rows[rowIndex].Cells[0].Value.ToString();
            counterparty.inn = dgvCounterparty.Rows[rowIndex].Cells[1].Value.ToString();
            counterparty.kpp = dgvCounterparty.Rows[rowIndex].Cells[2].Value.ToString();
            
            windows.counterparty.Modify modify = new windows.counterparty.Modify(username, counterparty);
            modify.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            
            refreshCounterparty();
        }

        private void deleteCounterparty(object sender, EventArgs e)
        {
            if ((dgvCounterparty.SelectedRows == null || dgvCounterparty.SelectedRows.Count != 1) &&
               (dgvCounterparty.SelectedCells == null || dgvCounterparty.SelectedCells.Count != 1))
            {
                MessageBox.Show("Не выбрана запись для редактирования или выбрано больше одной", "Информация");
                return;
            }

            int rowIndex;
            if (dgvCounterparty.SelectedCells != null && dgvCounterparty.SelectedCells.Count == 1)
                rowIndex = dgvCounterparty.SelectedCells[0].RowIndex;
            else
                rowIndex = dgvCounterparty.SelectedRows[0].Index;

            Counterparty counterparty = new Counterparty();
            counterparty.name = dgvCounterparty.Rows[rowIndex].Cells[0].Value.ToString();
            counterparty.inn = dgvCounterparty.Rows[rowIndex].Cells[1].Value.ToString();
            counterparty.kpp = dgvCounterparty.Rows[rowIndex].Cells[2].Value.ToString();

            windows.counterparty.Delete delete = new windows.counterparty.Delete(username, counterparty);
            delete.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed

            refreshCounterparty();
        }

        private void Kris_Load(object sender, EventArgs e)
        {
            refreshCounterparty(sender, e);
        }
    }
}
