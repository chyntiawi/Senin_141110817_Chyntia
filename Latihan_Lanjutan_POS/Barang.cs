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
    public partial class Barang : Form
    {
        Form1 parentform;
        public Barang(Form1 pf)
        {
            InitializeComponent();
            parentform = pf;
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
                kode.Clear();
                nama.Clear();
                jlhAwal.Clear();
                hrgHpp.Clear();
                hrgJual.Clear();
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

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void Barang_Load(object sender, EventArgs e)
        {
            panel_dftrBrg.Hide();
        }

        private void menuStrip_Brg_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Input")
            {
                panel_dftrBrg.Show();
                try
                {
                    string query = "SELECT COALESCE(MAX(ID)+1,1) FROM lat_pos.daftar_brg;";
                    MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id.Text = (reader.GetInt32(0)).ToString();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.ClickedItem.Text == "Edit")
            {
                panel_dftrBrg.Hide();
                Edit_Brg edit_brg = new Edit_Brg(this);
                edit_brg.MdiParent = this.ParentForm;
                edit_brg.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Text == "Delete")
            {
                panel_dftrBrg.Hide();
                Delete_Brg delete_brg = new Delete_Brg(this);
                delete_brg.MdiParent = this.ParentForm;
                delete_brg.Show();
                this.Hide();
            }
            else
                panel_dftrBrg.Hide();
        }

        private void Barang_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daftar_Brg show_dftrBrg = new Daftar_Brg(this);
            show_dftrBrg.MdiParent = this.ParentForm;
            show_dftrBrg.Show();
            this.Hide();
        }
    }
}
