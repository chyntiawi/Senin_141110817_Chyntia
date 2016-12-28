using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_Lanjutan_POS.Class
{
    class PenjualanDetail
    {
        private int id;
        private string kode;
        private int idCust;
        private int idbrg;
        private decimal hrgBrg;
        private int qty;
        private decimal totalHrg;
        private DateTime created_at;
        private DateTime updated_at;

        private Database db = new Database();

        public int getId()
        {
            return this.id;
        }

        public PenjualanDetail setId(int id)
        {
            this.id = id;
            return this;
        }

        public string getKode()
        {
            return this.kode;
        }

        public PenjualanDetail setKode(string kode)
        {
            this.kode = kode;
            return this;
        }

        public int getidCust()
        {
            return this.idCust;
        }

        public PenjualanDetail setidCust(int idCust)
        {
            this.idCust = idCust;
            return this;
        }

        public int getidBrg()
        {
            return this.idbrg;
        }

        public PenjualanDetail setidBrg(int idbrg)
        {
            this.idbrg = idbrg;
            return this;
        }

        public decimal gethrgBrg()
        {
            return this.hrgBrg;
        }

        public PenjualanDetail sethrgBrg(decimal hrgBrg)
        {
            this.hrgBrg = hrgBrg;
            return this;
        }

        public int getQty()
        {
            return this.qty;
        }

        public PenjualanDetail setQty(int qty)
        {
            this.qty = qty;
            return this;
        }

        public decimal gettotalHrg()
        {
            return this.totalHrg;
        }

        public PenjualanDetail settotalHrg(decimal totalHrg)
        {
            this.totalHrg = totalHrg;
            return this;
        }

        public DateTime getcreated_at()
        {
            return this.created_at;
        }

        public PenjualanDetail setcreated_at(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getupdated_at()
        {
            return this.updated_at;
        }

        public PenjualanDetail setupdated_at(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this;
        }

        public decimal hitungSubtotalHrg(int qty, decimal hrgBrg)
        {
            return this.qty * this.hrgBrg;
        }

        public void InsertPenjualanDetail()
        {
            db.openConnection();
            string PenjualandetailInsert = String.Concat("INSERT INTO daftar_penjualandetail(Kode,ID_Customer,ID_Barang,Harga_Barang,Kuantitas,Total_Harga,created_at,updated_at)VALUES(@Kode,@ID_Customer,@ID_Barang,@Harga_Barang,@Kuantitas,@Total_Harga,@created_at,@updated_at)");
            MySqlCommand PenjualandetailInsertCmd = new MySqlCommand(PenjualandetailInsert, db.connection);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@Kode", this.kode);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@ID_Customer", this.idCust);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@ID_Barang", this.idbrg);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@Harga_Barang", this.hrgBrg);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@Kuantitas", this.qty);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@Total_Harga", this.totalHrg);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@created_at", this.created_at);
            PenjualandetailInsertCmd.Parameters.AddWithValue("@updated_at", this.updated_at);
            PenjualandetailInsertCmd.ExecuteNonQuery();
            db.closeConnection();
        }

        public void UpdatePenjualanDetail()
        {
            var query = "update lat_pos.daftar_penjualandetail set ID_Customer='" + this.idCust + "',ID_Barang='" + this.idbrg + "',Harga_Barang='" + this.hrgBrg + "',Kuantitas='" + this.qty + "',Total_Harga='" + this.totalHrg + "',updated_at ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' where Kode='" + this.kode + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public void DeletePenjualanDetail()
        {
            string query = "delete from lat_pos.daftar_penjualandetail where Kode='" + this.kode + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public DataTable showDataPenjualanDetail()
        {
            DataTable table_Penjualandetail = new DataTable();
            using (db.connection)
            {
                db.openConnection();
                using (MySqlDataAdapter data_brg = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_penjualandetail", db.connection))
                {
                    data_brg.Fill(table_Penjualandetail);
                }
                db.closeConnection();
            }
            return table_Penjualandetail;
        }
    }
}
