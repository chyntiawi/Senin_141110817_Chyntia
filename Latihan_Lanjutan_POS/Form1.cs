using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_Lanjutan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cust_Click(object sender, EventArgs e)
        { }

        private void registrasi_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "barang")
            {
                Barang input_brg = new Barang(this);
                Form1 parent = new Form1();
                input_brg.MdiParent = this.ParentForm;
                input_brg.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "cust")
            {
                Form2 input_cust = new Form2(this);
                Form1 parent = new Form1();
                input_cust.MdiParent = this.ParentForm;
                input_cust.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Name == "supplier")
            {
                Supplier input_supplier = new Supplier(this);
                Form1 parent = new Form1();
                input_supplier.MdiParent = this.ParentForm;
                input_supplier.Show();
                this.Hide();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        { }

        private void btnCancel_Click(object sender, EventArgs e)
        { }

        private void btnKeluar_Click(object sender, EventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cust_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }
    }
}
