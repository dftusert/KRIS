using KRIS.database.entity;
using KRIS.datasets.product.ProductTableAdapters;
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

        /******************************* REFRESH BASE BLOCK *******************************/
        private void refreshCounterparty()
        {
            counterpartyTableAdapter.Fill(counterpartyDataSet.Counterparty);
            dgvCounterparty.ClearSelection();
        }

        private void refreshCounterpartyAttrs()
        {
            counterpatryAttrsTableAdapter.Fill(counterpartyAttrsDataSet.CounterpatryAttrs);
            dgvCounterpartyAttrs.ClearSelection();
        }

        private void refreshProduct()
        {
            productTableAdapter.Fill(productDataSet._Product);
            dgvProduct.ClearSelection();
        }

        private void refreshProductAttrs()
        {
            productAttrsTableAdapter.Fill(productAttrsDataSet._ProductAttrs);
            dgvProductAttrs.ClearSelection();
        }

        private void refreshBid()
        {
            bidTableAdapter.Fill(bidDataSet._Bid);
            dgvBid.ClearSelection();
        }

        private void refreshBidProduct()
        {
            bidProductTableAdapter.Fill(bidProductDataSet._BidProduct);
            dgvBidProduct.ClearSelection();
        }
        /****************************** REFRESH BASE BLOCK END *****************************/

        /******************************* REFRESH ACTION BLOCK *******************************/
        private void refreshCounterparty(object sender, EventArgs e)
        {
            refreshCounterparty();
        }

        private void refreshCounterpartyAttrs(object sender, EventArgs e)
        {
            refreshCounterpartyAttrs();
        }

        private void refreshProduct(object sender, EventArgs e)
        {
            refreshProduct();
        }

        private void refreshProductAttrs(object sender, EventArgs e)
        {
            refreshProductAttrs();
        }

        private void refreshBid(object sender, EventArgs e)
        {
            refreshBid();
        }

        private void refreshBidProduct(object sender, EventArgs e)
        {
            refreshBidProduct();
        }
        /****************************** REFRESH ACTION BLOCK END *****************************/

        private void filterCounterparty(object sender, EventArgs e)
        {
            windows.counterparty.Filter filter = new windows.counterparty.Filter(ref counterpartyBindingSource);  
            filter.ShowDialog();

            dgvCounterparty.ClearSelection();
            if (counterpartyBindingSource.Filter != null && counterpartyBindingSource.Filter != "")
                btnFilterC.BackColor = Color.Green;
            else
                btnFilterC.BackColor = ButtonBase.DefaultBackColor;
        }

        private void addCounterparty(object sender, EventArgs e)
        {
            windows.counterparty.Add add = new windows.counterparty.Add(username);
            add.ShowDialog();

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
            delete.ShowDialog();

            refreshCounterparty();
        }

        private void Kris_Load(object sender, EventArgs e)
        {
            refreshCounterparty(sender, e);
            refreshCounterpartyAttrs(sender, e);
            refreshProduct(sender, e);
            refreshProductAttrs(sender, e);
            refreshBid(sender, e);
            refreshBidProduct(sender, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selected = tabControl.SelectedTab;

            if (selected == tabCounterparty) refreshCounterparty();
            else if (selected == tabCounterpartyAttrs) refreshCounterpartyAttrs();
            else if (selected == tabProduct) refreshProduct();
            else if (selected == tabProductAttrs) refreshProductAttrs();
            else if (selected == tabBid) refreshBid();
            else if (selected == tabBidProduct) refreshBidProduct();
        }
    }
}
