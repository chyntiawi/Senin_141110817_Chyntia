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
    public partial class Daftar_Supplier : Form
    {
        Supplier parenform;
        public Daftar_Supplier(Supplier pf)
        {
            InitializeComponent();
            parenform = pf;
        }

        private void Daftar_Supplier_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396"))
            {
                connection.Open();
                using (MySqlDataAdapter data_cust = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_supplier", connection))
                {
                    DataTable table_supplier = new DataTable();
                    data_cust.Fill(table_supplier);
                    dataGridView_Supplier.DataSource = table_supplier;
                }
            }
        }

        private void Daftar_Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            parenform.Show();
        }
    }
}
