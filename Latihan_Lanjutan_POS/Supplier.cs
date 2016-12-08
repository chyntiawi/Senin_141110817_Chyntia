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
    public partial class Supplier : Form
    {
        Form1 parentform;
        public Supplier(Form1 pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void simpanSupplier_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO daftar_supplier(Kode,Nama,Alamat,Telp,HP)VALUES(@Kode,@Nama,@Alamat,@Telp,@HP)";
                cmd.Parameters.AddWithValue("@Kode", kodeSupplier.Text);
                cmd.Parameters.AddWithValue("@Nama", namaSupplier.Text);
                cmd.Parameters.AddWithValue("@Alamat", alamatSupplier.Text);
                cmd.Parameters.AddWithValue("@Telp", telpSupplier.Text);
                cmd.Parameters.AddWithValue("@HP", hpSupplier.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("1 Record tersimpan");
                kodeSupplier.Clear();
                namaSupplier.Clear();
                alamatSupplier.Clear();
                telpSupplier.Clear();
                hpSupplier.Clear();
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

        private void Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daftar_Supplier show_dftrSupplier = new Daftar_Supplier(this);
            show_dftrSupplier.MdiParent = this.ParentForm;
            show_dftrSupplier.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            kodeSupplier.Clear();
            namaSupplier.Clear();
            alamatSupplier.Clear();
            telpSupplier.Clear();
            hpSupplier.Clear();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            panel_supplier.Hide();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void menuStrip_Supplier_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Input")
            {
                panel_supplier.Show();
                try
                {
                    string query = "SELECT COALESCE(MAX(ID)+1,1) FROM lat_pos.daftar_supplier;";
                    MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idSupplier.Text = (reader.GetInt32(0)).ToString();
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
                panel_supplier.Hide();
                Edit_Supplier edit_supplier = new Edit_Supplier(this);
                edit_supplier.MdiParent = this.ParentForm;
                edit_supplier.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Text == "Delete")
            {
                panel_supplier.Hide();
                Delete_Supplier delete_supplier = new Delete_Supplier(this);
                delete_supplier.MdiParent = this.ParentForm;
                delete_supplier.Show();
                this.Hide();
            }
            else
                panel_supplier.Hide();
        }
    }
}
