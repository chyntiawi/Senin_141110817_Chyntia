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

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO daftar_brg(Kode,Nama,Jlh_Awal,Hrg_HPP,Hrg_Jual,created_at,updated_at)VALUES(@Kode,@Nama,@Jlh_Awal,@Hrg_HPP,@Hrg_Jual,@created_at,@updated_at)";
                cmd.Parameters.AddWithValue("@Kode", kode.Text);
                cmd.Parameters.AddWithValue("@Nama", nama.Text);
                cmd.Parameters.AddWithValue("@Jlh_Awal", int.Parse(jlhAwal.Text));
                cmd.Parameters.AddWithValue("@Hrg_HPP", decimal.Parse(hrgHpp.Text));
                cmd.Parameters.AddWithValue("@Hrg_Jual", decimal.Parse(hrgJual.Text));
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("1 Record tersimpan");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            kode.Clear();
            nama.Clear();
            jlhAwal.Clear();
            hrgHpp.Clear();
            hrgJual.Clear();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrasi_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Barang")
                panel_dftrBrg.Visible = true;
            else
                panel_dftrBrg.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_dftrBrg.Visible = false;
        }
    }
}
