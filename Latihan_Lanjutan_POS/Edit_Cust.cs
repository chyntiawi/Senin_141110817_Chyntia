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
    public partial class Edit_Cust : Form
    {
        Form2 parentform;
        public Edit_Cust(Form2 pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        { }

        private void simpanCust_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update lat_pos.daftar_customer set Kode='" + this.kodeCust.Text + "',Nama='" + this.namaCust.Text + "',Alamat='" + this.alamatCust.Text + "',Telp='" + this.telpCust.Text + "',HP='" + this.hpCust.Text + "' where ID='" + this.idCust.Text + "';";
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("1 Record Updated");
                idCust.Clear();
                kodeCust.Clear();
                namaCust.Clear();
                alamatCust.Clear();
                telpCust.Clear();
                hpCust.Clear();
                while (reader.Read())
                { }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            idCust.Clear();
            kodeCust.Clear();
            namaCust.Clear();
            alamatCust.Clear();
            telpCust.Clear();
            hpCust.Clear();
        }

        private void Edit_Cust_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }
    }
}
