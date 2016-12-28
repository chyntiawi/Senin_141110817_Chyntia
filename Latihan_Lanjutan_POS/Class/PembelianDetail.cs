using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_Lanjutan_POS.Class
{
    class PembelianDetail
    {
        private int id;
        private string kode;
        private int id_sup;
        private int id_brg;
        private decimal hrg_brg;
        private int qty;
        private decimal totalHrg;
        private DateTime created_at;
        private DateTime updated_at;

        private Database db = new Database();

        public int getId()
        {
            return this.id;
        }

        public PembelianDetail setId(int id)
        {
            this.id = id;
            return this;
        }

        public string getKode()
        {
            return this.kode;
        }

        public PembelianDetail setKode(string kode)
        {
            this.kode = kode;
            return this;
        }

        public int getidSup()
        {
            return this.id_sup;
        }

        public PembelianDetail setSup(int id_sup)
        {
            this.id_sup = id_sup;
            return this;
        }

        public int getidBrg()
        {
            return this.id_brg;
        }

        public PembelianDetail setidBrg(int id_brg)
        {
            this.id_brg = id_brg;
            return this;
        }

        public decimal gethrgBrg()
        {
            return this.hrg_brg;
        }

        public PembelianDetail sethrgBrg(int hrg_brg)
        {
            this.hrg_brg = hrg_brg;
            return this;
        }

        public int getQty()
        {
            return this.qty;
        }

        public PembelianDetail setQty(int qty)
        {
            this.qty = qty;
            return this;
        }

        public decimal gettotalHrg()
        {
            return this.totalHrg;
        }

        public PembelianDetail settotalHrg(decimal totalHrg)
        {
            this.totalHrg = totalHrg;
            return this;
        }

        public DateTime getcreated_at()
        {
            return this.created_at;
        }

        public PembelianDetail setcreated_at(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getupdated_at()
        {
            return this.updated_at;
        }

        public PembelianDetail setupdated_at(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this;
        }

        public void InsertPembelianDetail()
        {
            db.openConnection();
            string pembeliandetailInsert = String.Concat("INSERT INTO daftar_pembeliandetail(Kode,ID_Supplier,ID_Barang,Harga_Barang,Kuantitas,Total_Harga,created_at,updated_at)VALUES(@Kode,@ID_Supplier,@ID_Barang,@Harga_Barang,@Kuantitas,@Total_Harga,@created_at,@updated_at)");
            MySqlCommand pembeliandetailInsertCmd = new MySqlCommand(pembeliandetailInsert, db.connection);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@Kode", this.kode);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@ID_Supplier", this.id_sup);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@ID_Barang", this.id_brg);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@Harga_Barang", this.hrg_brg);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@Kuantitas", this.qty);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@Total_Harga", this.totalHrg);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@created_at", this.created_at);
            pembeliandetailInsertCmd.Parameters.AddWithValue("@updated_at", this.updated_at);
            pembeliandetailInsertCmd.ExecuteNonQuery();
            db.closeConnection();
        }

        public void UpdatePembelianDetail()
        {
            var query = "update lat_pos.daftar_pembeliandetail set ID_Supplier='" + this.id_sup + "',ID_Barang='" + this.id_brg + "',Harga_Barang='" + this.hrg_brg + "',Kuantitas='" + this.qty + "',Total_Harga='" + this.totalHrg + "',updated_at ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' where Kode='" + this.kode + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public void DeletePembelianDetail()
        {
            string query = "delete from lat_pos.daftar_pembeliandetail where Kode='" + this.kode + "';";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader reader;
            db.openConnection();
            reader = cmd.ExecuteReader();
            db.closeConnection();
        }

        public DataTable showDataPembelianDetail()
        {
            DataTable table_pembeliandetail = new DataTable();
            using (db.connection)
            {
                db.openConnection();
                using (MySqlDataAdapter data_brg = new MySqlDataAdapter("SELECT * FROM lat_pos.daftar_pembeliandetail", db.connection))
                {
                    data_brg.Fill(table_pembeliandetail);
                }
                db.closeConnection();
            }
            return table_pembeliandetail;
        }
    }
}
