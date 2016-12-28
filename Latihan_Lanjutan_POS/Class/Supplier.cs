using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_Lanjutan_POS.Class
{
    class Supplier
    {
        private int idSup;
        private string kodeSup;
        private string namaSup;
        private string alamatSup;
        private string telpSup;
        private string hpSup;

        private Database db = new Database();

        public int getidSup()
        {
            return this.idSup;
        }

        public Supplier setidSup(int idSup)
        {
            this.idSup = idSup;
            return this;
        }

        public string getkodeSup()
        {
            return this.kodeSup;
        }

        public Supplier setkodeSup(string kodeSup)
        {
            this.kodeSup = kodeSup;
            return this;
        }

        public string getnamaSup()
        {
            return this.namaSup;
        }

        public Supplier setnamaSup(string namaSup)
        {
            this.namaSup = namaSup;
            return this;
        }

        public string getalamatSup()
        {
            return this.alamatSup;
        }

        public Supplier setalamatSup(string alamatSup)
        {
            this.alamatSup = alamatSup;
            return this;
        }

        public string gettelpSup()
        {
            return this.telpSup;
        }

        public Supplier settelpSup(string telpSup)
        {
            this.telpSup = telpSup;
            return this;
        }

        public string gethpSup()
        {
            return this.hpSup;
        }

        public Supplier sethpSup(string hpSup)
        {
            this.hpSup = hpSup;
            return this;
        }

        public string showIdSup()
        {
            string query = "SELECT COALESCE(MAX(ID)+1,1) FROM lat_pos.daftar_supplier;";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idSup = reader.GetInt32(0);
            }
            db.closeConnection();
            return idSup.ToString();
        }

        public void InsertSup()
        {
            db.openConnection();
            string supInsert = String.Concat("INSERT INTO daftar_supplier(Kode,Nama,Alamat,Telp,HP)VALUES(@Kode,@Nama,@Alamat,@Telp,@HP)");
            MySqlCommand supInsertCmd = new MySqlCommand(supInsert, db.connection);
            supInsertCmd.Parameters.AddWithValue("@Kode", kodeSup);
            supInsertCmd.Parameters.AddWithValue("@Nama", namaSup);
            supInsertCmd.Parameters.AddWithValue("@Alamat", alamatSup);
            supInsertCmd.Parameters.AddWithValue("@Telp", telpSup);
            supInsertCmd.Parameters.AddWithValue("@HP", hpSup);
            supInsertCmd.ExecuteNonQuery();
            db.closeConnection();
        }

        public void UpdateSup()
        {
            string query = "update lat_pos.daftar_supplier set Kode='" + this.kodeSup + "',Nama='" + this.namaSup + "',Alamat='" + this.alamatSup + "',Telp='" + this.telpSup + "',HP='" + this.hpSup + "' where ID='" + this.idSup + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public void DeleteSup()
        {
            string query = "delete from lat_pos.daftar_supplier where ID='" + this.idSup + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public DataTable showDataSup()
        {
            DataTable table_sup = new DataTable();
            using (db.connection)
            {
                db.openConnection();
                using (MySqlDataAdapter data_cust = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_supplier", db.connection))
                {
                    data_cust.Fill(table_sup);
                }
                db.closeConnection();
            }
            return table_sup;
        }
    }
}
