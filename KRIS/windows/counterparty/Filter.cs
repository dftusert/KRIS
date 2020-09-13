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
                tbName.Text = values[1];
                tbINN.Text = values[3];
                tbKPP.Text = values[5];
            }
        }

        private void clearFilter(object sender, EventArgs e)
        {
            bs.Filter = "";
            MessageBox.Show("Фильтр сброшен", "Информация");
        }

        private void setupFilter(object sender, EventArgs e)
        {
            string name = tbName.Text;
            if (name == null) name = "";
            string inn = tbINN.Text;
            if (inn == null) inn = "";
            string kpp = tbKPP.Text;
            if (kpp == null) kpp = "";

            if(name == "" && inn == "" && kpp == "")
            {
                MessageBox.Show("Фильтр не указан", "Информация");
                return;
            }

            bs.Filter = String.Format("name like '%{0}%' and inn like '%{1}%' and kpp like '%{2}%'", name, inn, kpp);
            MessageBox.Show("Фильтр установлен", "Информация");
        }
    }
}
