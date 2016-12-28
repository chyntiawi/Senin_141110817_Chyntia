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
    public partial class menuList : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        menuHome parentform;
        public menuList(menuHome pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void tabCust_Click(object sender, EventArgs e)
        { }

        private void menuList_Load(object sender, EventArgs e)
        {
            Barang brg = new Barang();
            dataGridView_Brg.DataSource = brg.showDataBrg();
        }

        private void register_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (register.SelectedTab.Text == tabBrg.Text)
            {
                Barang brg = new Barang();
                dataGridView_Brg.DataSource = brg.showDataBrg();
            }
            else if (register.SelectedTab.Text == tabCust.Text)
            {
                Customer cust = new Customer();
                dataGridView_Cust.DataSource = cust.showDataCust();
            }
            else if (register.SelectedTab.Text == tabSup.Text)
            {
                Supplier sup = new Supplier();
                dataGridView_Sup.DataSource = sup.showDataSup();
            }
        }

        private void register_Selected(object sender, TabControlEventArgs e)
        { }

        private void menuList_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.connection.Dispose();
            parentform.Enabled = true;
        }
    }
}
