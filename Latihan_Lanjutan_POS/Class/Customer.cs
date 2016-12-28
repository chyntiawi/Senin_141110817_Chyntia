using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_Lanjutan_POS.Class
{
    class Customer
    {
        private int idCust;
        private string kodeCust;
        private string namaCust;
        private string alamatCust;
        private string telpCust;
        private string hpCust;

        private Database db = new Database();

        public int getidCust()
        {
            return this.idCust;
        }

        public Customer setidCust(int idCust)
        {
            this.idCust = idCust;
            return this;
        }

        public string getkodeCust()
        {
            return this.kodeCust;
        }

        public Customer setkodeCust(string kodeCust)
        {
            this.kodeCust = kodeCust;
            return this;
        }

        public string getnamaCust()
        {
            return this.namaCust;
        }

        public Customer setnamaCust(string namaCust)
        {
            this.namaCust = namaCust;
            return this;
        }

        public string getalamatCust()
        {
            return this.alamatCust;
        }

        public Customer setalamatCust(string alamatCust)
        {
            this.alamatCust = alamatCust;
            return this;
        }

        public string gettelpCust()
        {
            return this.telpCust;
        }

        public Customer settelpCust(string telpCust)
        {
            this.telpCust = telpCust;
            return this;
        }

        public string gethpCust()
        {
            return this.hpCust;
        }

        public Customer sethpCust(string hpCust)
        {
            this.hpCust = hpCust;
            return this;
        }

        public string showIdCust()
        {
            string query = "SELECT COALESCE(MAX(ID)+1,1) FROM lat_pos.daftar_customer;";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idCust = reader.GetInt32(0);
            }
            db.closeConnection();
            return idCust.ToString();
        }

        public void InsertCust()
        {
            db.openConnection();
            string custInsert = String.Concat("INSERT INTO daftar_customer(Kode,Nama,Alamat,Telp,HP)VALUES(@Kode,@Nama,@Alamat,@Telp,@HP)");
            MySqlCommand custInsertCmd = new MySqlCommand(custInsert, db.connection);
            custInsertCmd.Parameters.AddWithValue("@Kode", this.kodeCust);
            custInsertCmd.Parameters.AddWithValue("@Nama", this.namaCust);
            custInsertCmd.Parameters.AddWithValue("@Alamat", this.alamatCust);
            custInsertCmd.Parameters.AddWithValue("@Telp", this.telpCust);
            custInsertCmd.Parameters.AddWithValue("@HP", this.hpCust);
            custInsertCmd.ExecuteNonQuery();
            db.closeConnection();
        }

        public void UpdateCust()
        {
            string query = "update lat_pos.daftar_customer set Kode='" + this.kodeCust + "',Nama='" + this.namaCust + "',Alamat='" + this.alamatCust + "',Telp='" + this.telpCust + "',HP='" + this.hpCust+ "' where ID='" + this.idCust + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public void DeleteCust()
        {
            string query = "delete from lat_pos.daftar_customer where ID='" + this.idCust + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public DataTable showDataCust()
        {
            DataTable table_cust = new DataTable();
            using (db.connection)
            {
                db.openConnection();
                using (MySqlDataAdapter data_cust = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_customer", db.connection))
                {
                    data_cust.Fill(table_cust);
                }
                db.closeConnection();
            }
            return table_cust;
        }
    }
}
