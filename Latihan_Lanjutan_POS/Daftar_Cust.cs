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
    public partial class Daftar_Cust : Form
    {
        Form2 parentform;
        public Daftar_Cust(Form2 pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void Daftar_Cust_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396"))
            {
                connection.Open();
                using (MySqlDataAdapter data_cust = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_customer", connection))
                {
                    DataTable table_cust = new DataTable();
                    data_cust.Fill(table_cust);
                    dataGridView_Cust.DataSource = table_cust;
                }
            }
        }

        private void Daftar_Cust_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }
    }
}
