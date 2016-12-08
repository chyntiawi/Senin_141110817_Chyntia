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
    public partial class Edit_Brg : Form
    {
        Barang parentform;
        public Edit_Brg(Barang pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "update lat_pos.daftar_brg set Kode='" + this.kode.Text + "',Nama='" + this.nama.Text + "',Jlh_Awal='" + this.jlhAwal.Text + "',Hrg_HPP='" + this.hrgHpp.Text + "',Hrg_Jual='" + this.hrgJual.Text + "',updated_at ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' where ID='" + this.id.Text+"';";
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("1 Record Updated");
                id.Clear();
                kode.Clear();
                nama.Clear();
                jlhAwal.Clear();
                hrgHpp.Clear();
                hrgJual.Clear();
                while (reader.Read())
                { }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            id.Clear();
            kode.Clear();
            nama.Clear();
            jlhAwal.Clear();
            hrgHpp.Clear();
            hrgJual.Clear();
        }

        private void Edit_Brg_Load(object sender, EventArgs e)
        { }

        private void Edit_Brg_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }
    }
}
