using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_Lanjutan_POS.Class;

namespace Latihan_Lanjutan_POS
{
    public partial class menuDelete : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        menuHome parentform;
        public menuDelete(menuHome pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void butDelBrg_Click(object sender, EventArgs e)
        {
            Barang brg = new Barang();
            brg.setidBrg(int.Parse(idBrg.Text));
            brg.DeleteBrg();
            MessageBox.Show("1 Record Succesfully Deleted");
            idBrg.Clear();
        }

        private void butDelCust_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.setidCust(int.Parse(idCust.Text));
            cust.DeleteCust();
            MessageBox.Show("1 Record Succesfully Deleted");
            idCust.Clear();
        }

        private void butDelSup_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.setidSup(int.Parse(idSup.Text));
            sup.DeleteSup();
            MessageBox.Show("1 Record Succesfully Deleted");
            idSup.Clear();
        }

        private void menuDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.connection.Dispose();
            parentform.Enabled = true;
        }
    }
}
