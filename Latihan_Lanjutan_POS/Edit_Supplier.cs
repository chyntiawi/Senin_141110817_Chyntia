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
    public partial class Edit_Supplier : Form
    {
        Supplier parentform;
        public Edit_Supplier(Supplier pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void simpanSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update lat_pos.daftar_supplier set Kode='" + this.kodeSupplier.Text + "',Nama='" + this.namaSupplier.Text + "',Alamat='" + this.alamatSupplier.Text + "',Telp='" + this.telpSupplier.Text + "',HP='" + this.hpSupplier.Text + "' where ID='" + this.idSupplier.Text + "';";
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("1 Record Updated");
                idSupplier.Clear();
                kodeSupplier.Clear();
                namaSupplier.Clear();
                alamatSupplier.Clear();
                telpSupplier.Clear();
                hpSupplier.Clear();
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
            idSupplier.Clear();
            kodeSupplier.Clear();
            namaSupplier.Clear();
            alamatSupplier.Clear();
            telpSupplier.Clear();
            hpSupplier.Clear();
        }

        private void Edit_Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }
    }
}
