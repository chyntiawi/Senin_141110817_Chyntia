using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = cek(Convert.ToInt64(Txt1.Text), Convert.ToInt64(Txt2.Text)).ToString();
        }
        public static long cek(long a, long b)
        {
            if (a < b)
                return cek(b, a);
            if (a >= (b + 2) && a == 25)
                return nCr1((a + b) - 1, b);
            else if (a == (b + 2) && a >= 26)
                return nCr1(48, 24) * pow(2, (b - 24)) % 1000000007;
            else
                return 0;
        }

        public static long nCr1(long n, long r)
        {
            long h = 1;
            for (long i = 0; i < (n - r); i++)
            {
                h = h * (n - i) / (i + 1);
            }
            return h % 1000000007;
        }

        public static long pow(long b, long n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return b;
            long halfn = pow(b, n / 2);
            if (n % 2 == 0)
                return (halfn * halfn) % 1000000007;
            else
                return ((halfn * halfn) % 1000000007) * b;
        }
    }
}
