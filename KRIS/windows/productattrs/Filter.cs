using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIS.windows.productattrs
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
                tbAttr.Text = values[3];
                tbVal.Text = values[5];
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
            string attr = tbAttr.Text;
            if (attr == null) attr = "";
            string value = tbVal.Text;
            if (value == null) value = "";

            if (vendorCode == "" && attr == "" && value == "")
            {
                MessageBox.Show("Фильтр не указан", "Информация");
                return;
            }

            bs.Filter = String.Format("vendor_code like '%{0}%' and term_name like '%{1}%' and attr_value like '%{2}%'", vendorCode, attr, value);
            MessageBox.Show("Фильтр установлен", "Информация");
        }
    }
}
