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
    public partial class Form2 : Form
    {
        Form1 parentform;
        public Form2(Form1 pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel_customer.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentform.Show();
        }

        private void simpanCust_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
            MySqlCommand cmd;
            connection.Open();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO daftar_customer(Kode,Nama,Alamat,Telp,HP)VALUES(@Kode,@Nama,@Alamat,@Telp,@HP)";
                cmd.Parameters.AddWithValue("@Kode", kodeCust.Text);
                cmd.Parameters.AddWithValue("@Nama", namaCust.Text);
                cmd.Parameters.AddWithValue("@Alamat", alamatCust.Text);
                cmd.Parameters.AddWithValue("@Telp", telpCust.Text);
                cmd.Parameters.AddWithValue("@HP", hpCust.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("1 Record tersimpan");
                kodeCust.Clear();
                namaCust.Clear();
                alamatCust.Clear();
                telpCust.Clear();
                hpCust.Clear();
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

        private void daftarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daftar_Cust show_dftrCust = new Daftar_Cust(this);
            show_dftrCust.MdiParent = this.ParentForm;
            show_dftrCust.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            kodeCust.Clear();
            namaCust.Clear();
            alamatCust.Clear();
            telpCust.Clear();
            hpCust.Clear();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        private void menuStrip_Cust_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Input")
            {
                panel_customer.Show();
                try
                {
                    string query = "SELECT COALESCE(MAX(ID)+1,1) FROM lat_pos.daftar_customer;";
                    MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idCust.Text = (reader.GetInt32(0)).ToString();
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
                panel_customer.Hide();
                Edit_Cust edit_cust = new Edit_Cust(this);
                edit_cust.MdiParent = this.ParentForm;
                edit_cust.Show();
                this.Hide();
            }
            else if (e.ClickedItem.Text == "Delete")
            {
                panel_customer.Hide();
                Delete_Cust delete_cust = new Delete_Cust(this);
                delete_cust.MdiParent = this.ParentForm;
                delete_cust.Show();
                this.Hide();
            }
            else
                panel_customer.Hide();
        }
    }
}
