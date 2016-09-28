using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            min.Text = minbar.Value.ToString();
            range.Text = Math.Abs(minbar.Value + maxbar.Value).ToString();
            DateTime label6 = new DateTime((DateTime.Today.Year - minbar.Value),DateTime.Today.Month,DateTime.Today.Day);
            mindate.Text = label6.ToString("dd/MM/yyyy");
            dateTimePicker1.MinDate = label6;
        }

        private void maxbar_Scroll(object sender, ScrollEventArgs e)
        {
            max.Text = maxbar.Value.ToString();
            range.Text = Math.Abs(minbar.Value + maxbar.Value).ToString();
            DateTime label7 = new DateTime((DateTime.Today.Year + maxbar.Value), DateTime.Today.Month, DateTime.Today.Day);
            maxdate.Text = label7.ToString("dd/MM/yyyy");
            dateTimePicker1.MaxDate = label7;
        }
    }
}
