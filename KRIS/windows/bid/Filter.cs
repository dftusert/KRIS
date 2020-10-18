using System;
using System.Windows.Forms;

namespace KRIS.windows.bid
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
                string[] values = bs.Filter.Split('%', '\'');
                tbBidNumber.Text = values[2];
                
                if(values[5] == "date")
                {
                    tbStatus.Text = values[14];
                    if(values[17] == "date")
                    {
                        tbType.Text = values[26];
                        tbINN.Text = values[30];
                    } else
                    {
                        dtpStatusDate.Value = DateTime.Parse(values[17]);
                        tbType.Text = values[22];
                        tbINN.Text = values[26];
                    }
                } else
                {
                    dtpCreateDate.Value = DateTime.Parse(values[5]);
                    tbStatus.Text = values[10];

                    if (values[13] == "date")
                    {
                        tbType.Text = values[22];
                        tbINN.Text = values[26];
                    }
                    else
                    {
                        dtpStatusDate.Value = DateTime.Parse(values[13]);
                        tbType.Text = values[18];
                        tbINN.Text = values[22];
                    }
                }
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
            string createDate;
            if (cbCreateDateUse.Checked) createDate = String.Format("create_date >= '{0:yyyy-MM-dd}' AND create_date < '{1:yyyy-MM-dd}'", dtpCreateDate.Value, dtpCreateDate.Value.AddDays(1).ToShortDateString());
            else createDate = "'date' = 'date' AND 'date' = 'date'";
            string status = tbStatus.Text;
            if (status == null) status = "";
            string statusDate;
            if (cbStatusDateUse.Checked) statusDate = String.Format("status_date >= '{0:yyyy-MM-dd}' AND status_date < '{1:yyyy-MM-dd}'", dtpStatusDate.Value, dtpStatusDate.Value.AddDays(1).ToShortDateString());
            else statusDate = "'date' = 'date' AND 'date' = 'date'";
            string type = tbType.Text;
            if (type == null) type = "";
            string inn = tbINN.Text;
            if (inn == null) inn = "";


            if (bidNumber == "" && createDate == "" && status == "" && statusDate == "" && type == "" && inn == "")
            {
                MessageBox.Show("Фильтр не указан", "Информация");
                return;
            }

            MessageBox.Show(String.Format("bid_number like '%{0}%' and {1} and term_name like '%{2}%' " +
                                      "and {3} and Expr1 like '%{4}%' and inn like '%{5}%'",
                                      bidNumber, createDate, status, statusDate, type, inn));

            bs.Filter = String.Format("bid_number like '%{0}%' and {1} and term_name like '%{2}%' " +
                                      "and {3} and Expr1 like '%{4}%' and inn like '%{5}%'",
                                      bidNumber, createDate, status, statusDate, type, inn);
            MessageBox.Show("Фильтр установлен", "Информация");
        }
    }
}
