using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIS.windows.bidproduct
{
    public partial class Filter : Form
    {
        private BindingSource bs;
        public Filter(ref BindingSource bs)
        {
            InitializeComponent();

            this.bs = bs;

            if (bs.Filter != null && bs.Filter != "")
            {
                string[] values = bs.Filter.Split('%');
                tbBidNumber.Text = values[1];
                tbVendorCode.Text = values[3];
                tbCount.Text = values[5];
                tbPrice.Text = values[7];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bs.Filter = "";
            MessageBox.Show("Фильтр сброшен", "Информация");
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            string bidNumber = tbBidNumber.Text;
            if (bidNumber == null) bidNumber = "";
            string vendorCode = tbVendorCode.Text;
            if (vendorCode == null) vendorCode = "";
            string count = tbCount.Text;
            if (count == null) count = "";
            string price = tbPrice.Text;
            if (price == null) price = "";

            if (bidNumber == "" && vendorCode == "" && count == "" && price == "")
            {
                MessageBox.Show("Фильтр не указан", "Информация");
                return;
            }

            bs.Filter = String.Format("bid_number like '%{0}%' and vendor_code like '%{1}%' and product_count like '%{2}%' and product_price like '%{3}%'",
                                      bidNumber, vendorCode, count, price);
            MessageBox.Show("Фильтр установлен", "Информация");
        }
    }
}
