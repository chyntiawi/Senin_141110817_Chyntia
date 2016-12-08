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
    public partial class Daftar_Brg : Form
    {
        Barang parentform;
        public Daftar_Brg(Barang pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void Daftar_Brg_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396"))
            {
                connection.Open();
                using (MySqlDataAdapter data_brg = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_brg", connection))
                {
                    DataTable table_brg = new DataTable();
                    data_brg.Fill(table_brg);
                    dataGridView_Cust.DataSource = table_brg;
                }
            }
        }

        private void Daftar_Brg_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }
    }
}
