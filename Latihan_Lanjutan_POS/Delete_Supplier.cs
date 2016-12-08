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
    public partial class Delete_Supplier : Form
    {
        Supplier parenform;
        public Delete_Supplier(Supplier pf)
        {
            InitializeComponent();
            parenform = pf;
        }

        private void deleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from lat_pos.daftar_supplier where ID='" + this.idSupplier.Text + "';";
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=lat_pos;Uid=root;Pwd=Oriental190396");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("1 Record Deleted");
                idSupplier.Clear();
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
        }

        private void Delete_Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            parenform.Show();
        }
    }
}
