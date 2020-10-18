using System;
using System.Windows.Forms;

namespace KRIS.windows.counterpartyattrs
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
                tbINN.Text = values[1];
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
            string inn = tbINN.Text;
            if (inn == null) inn = "";
            string attr = tbAttr.Text;
            if (attr == null) attr = "";
            string value = tbVal.Text;
            if (value == null) value = "";

            if (inn == "" && attr == "" && value == "")
            {
                MessageBox.Show("Фильтр не указан", "Информация");
                return;
            }

            bs.Filter = String.Format("inn like '%{0}%' and term_name like '%{1}%' and attr_value like '%{2}%'", inn, attr, value);
            MessageBox.Show("Фильтр установлен", "Информация");
        }
    }
}
