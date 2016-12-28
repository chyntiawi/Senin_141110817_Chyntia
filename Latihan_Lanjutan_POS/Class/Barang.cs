using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_Lanjutan_POS.Class
{
    class Barang
    {
        private int idBrg;
        private string kodeBrg;
        private string namaBrg;
        private int jlhAwalBrg;
        private decimal hrgHppBrg;
        private decimal hrgJualBrg;
        private DateTime created_at;
        private DateTime updated_at;

        private Database db = new Database();

        public int getidBrg()
        {
            return this.idBrg;
        }

        public Barang setidBrg(int idBrg)
        {
            this.idBrg = idBrg;
            return this;
        }

        public string getkodeBrg()
        {
            return this.kodeBrg;
        }

        public Barang setkodeBrg(string kodeBrg)
        {
            this.kodeBrg = kodeBrg;
            return this;
        }

        public string getnamaBrg()
        {
            return this.namaBrg;
        }

        public Barang setnamaBrg(string namaBrg)
        {
            this.namaBrg = namaBrg;
            return this;
        }

        public int getjlhAwalBrg()
        {
            return this.jlhAwalBrg;
        }

        public Barang setjlhAwalBrg(int jlhAwalBrg)
        {
            this.jlhAwalBrg = jlhAwalBrg;
            return this;
        }

        public decimal gethrgHppBrg()
        {
            return this.hrgHppBrg;
        }

        public Barang sethrgHppBrg(decimal hrgHppBrg)
        {
            this.hrgHppBrg = hrgHppBrg;
            return this;
        }

        public decimal gethrgJualBrg()
        {
            return this.hrgJualBrg;
        }

        public Barang sethrgJualBrg(decimal hrgJualBrg)
        {
            this.hrgJualBrg = hrgJualBrg;
            return this;
        }

        public DateTime getcreated_at()
        {
            return this.created_at;
        }

        public Barang setcreated_at(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getupdated_at()
        {
            return this.updated_at;
        }

        public Barang setupdated_at(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this; 
        }

        public string showIdBrg()
        {
            string query = "SELECT COALESCE(MAX(ID)+1,1) FROM lat_pos.daftar_brg;";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            db.openConnection();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idBrg = reader.GetInt32(0);
            }
            db.closeConnection();
            return idBrg.ToString();
        }

        public void InsertBrg()
        {
            db.openConnection();
            string brgInsert = String.Concat("INSERT INTO daftar_brg(Kode,Nama,Jlh_Awal,Hrg_HPP,Hrg_Jual,created_at,updated_at)VALUES(@Kode,@Nama,@Jlh_Awal,@Hrg_HPP,@Hrg_Jual,@created_at,@updated_at)");
            MySqlCommand brgInsertCmd = new MySqlCommand(brgInsert, db.connection);
            brgInsertCmd.Parameters.AddWithValue("@Kode", this.kodeBrg);
            brgInsertCmd.Parameters.AddWithValue("@Nama", this.namaBrg);
            brgInsertCmd.Parameters.AddWithValue("@Jlh_Awal", this.jlhAwalBrg);
            brgInsertCmd.Parameters.AddWithValue("@Hrg_HPP", this.hrgHppBrg);
            brgInsertCmd.Parameters.AddWithValue("@Hrg_Jual", this.hrgJualBrg);
            brgInsertCmd.Parameters.AddWithValue("@created_at", this.created_at);
            brgInsertCmd.Parameters.AddWithValue("@updated_at", this.updated_at);
            brgInsertCmd.ExecuteNonQuery();
            db.closeConnection();
        }

        public void UpdateBrg()
        {
            var query = "update lat_pos.daftar_brg set Kode='" + this.kodeBrg + "',Nama='" + this.namaBrg + "',Jlh_Awal='" + this.jlhAwalBrg + "',Hrg_HPP='" + this.hrgHppBrg + "',Hrg_Jual='" + this.hrgJualBrg + "',updated_at ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' where ID='" + this.idBrg + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public void DeleteBrg()
        {
            string query = "delete from lat_pos.daftar_brg where ID='" + this.idBrg + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public DataTable showDataBrg()
        {
            DataTable table_brg = new DataTable();
            using (db.connection)
            {
                db.openConnection();
                using (MySqlDataAdapter data_brg = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_brg", db.connection))
                {
                    data_brg.Fill(table_brg);
                }
                db.closeConnection();
            }
            return table_brg;
        }
    }
}
