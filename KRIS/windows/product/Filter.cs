using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIS.windows.product
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
                tbVendorCode.Text = values[1];
                tbName.Text = values[3];
                tbOKEI.Text = values[5];
                tbType.Text = values[7];
                tbRecPrice.Text = values[9];
                tbRemainder.Text = values[11];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bs.Filter = "";
            MessageBox.Show("Фильтр сброшен", "Информация");
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            string vendorCode = tbVendorCode.Text;
            if (vendorCode == null) vendorCode = "";
            string name = tbName.Text;
            if (name == null) name = "";
            string okei = tbOKEI.Text;
            if (okei == null) okei = "";
            string type = tbType.Text;
            if (type == null) type = "";
            string recPrice = tbRecPrice.Text;
            if (recPrice == null) recPrice = "";
            string remainder = tbRemainder.Text;
            if (remainder == null) remainder = "";

            if (vendorCode == "" && name == "" && okei == "" && type == "" && recPrice == "" && remainder == "")
            {
                MessageBox.Show("Фильтр не указан", "Информация");
                return;
            }

            bs.Filter = String.Format("vendor_code like '%{0}%' and name like '%{1}%' and Expr1 like '%{2}%' and term_name like '%{3}%' and recommended_price like '%{4}%' and remainder like '%{5}%'", vendorCode, name, okei, type, recPrice, remainder);
            MessageBox.Show("Фильтр установлен", "Информация");
        }

    }
}
