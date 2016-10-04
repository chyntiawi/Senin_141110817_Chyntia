using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domain.SelectedItem = "Januari";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Note : selected index default = -1
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, domain.SelectedIndex + 1, Convert.ToInt32(numeric.Value)));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime start = new DateTime(2016,1,1);
            DateTime end = new DateTime(2016,12,31);
            TimeSpan range = end - start;
            int day = range.Days;
            for (var i = 0; i <= day;i++)
            {
                var bolddate = start.AddDays(i);
                switch (bolddate.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        monthCalendar1.AddBoldedDate(bolddate);
                        break;
                    case DayOfWeek.Sunday:
                        monthCalendar1.AddBoldedDate(bolddate);
                        break;
                }
            }
            //Tgl Lahir : 1 Maret
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1996,3,1));       
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            numeric.Maximum = 31;
            numeric.Minimum = 1;
        }

        private void domain_SelectedItemChanged(object sender, EventArgs e)
        { }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //Note : selected index default = -1
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, domain.SelectedIndex + 1, Convert.ToInt32(numeric.Value)));
        }
    }
}
