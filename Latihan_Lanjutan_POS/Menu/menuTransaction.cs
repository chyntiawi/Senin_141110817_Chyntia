using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_Lanjutan_POS.Class;

namespace Latihan_Lanjutan_POS
{
    public partial class menuTransaction : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        menuHome parentform;

        public menuTransaction(menuHome pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void butAddPembelian_Click(object sender, EventArgs e)
        {
            PembelianDetail pd = new PembelianDetail();
            pd.setKode(kodePembelian.Text);
            pd.setSup(int.Parse(supPembelian.Text));
            pd.setidBrg(int.Parse(brgPembelian.Text));
            pd.sethrgBrg(int.Parse(hrgBrgPembelian.Text));
            pd.setQty(int.Parse(qtyBrgPembelian.Text));
            pd.settotalHrg(decimal.Parse(TotalPembelian.Text));
            pd.setcreated_at(DateTime.Now);
            pd.setupdated_at(DateTime.Now);
            pd.InsertPembelianDetail();
            MessageBox.Show("1 Record Succesfully Saved");
            kodePembelian.Clear();
            supPembelian.Clear();
            brgPembelian.Clear();
            hrgBrgPembelian.Clear();
            qtyBrgPembelian.Clear();
            TotalPembelian.Clear();
            dataGridView_PembelianDetail.DataSource = pd.showDataPembelianDetail();
            dataGridView_PembelianDetail.Refresh();
        }

        private void butEditPembelian_Click(object sender, EventArgs e)
        {
            PembelianDetail pd = new PembelianDetail();
            pd.setKode(kodePembelian.Text);
            pd.setSup(int.Parse(supPembelian.Text));
            pd.setidBrg(int.Parse(brgPembelian.Text));
            pd.sethrgBrg(int.Parse(hrgBrgPembelian.Text));
            pd.setQty(int.Parse(qtyBrgPembelian.Text));
            pd.settotalHrg(decimal.Parse(TotalPembelian.Text));
            pd.setupdated_at(DateTime.Now);
            pd.UpdatePembelianDetail();
            MessageBox.Show("1 Record Succesfully Updated");
            kodePembelian.Clear();
            supPembelian.Clear();
            brgPembelian.Clear();
            hrgBrgPembelian.Clear();
            qtyBrgPembelian.Clear();
            TotalPembelian.Clear();
            dataGridView_PembelianDetail.DataSource = pd.showDataPembelianDetail();
            dataGridView_PembelianDetail.Refresh();
        }

        private void butDelPembelian_Click(object sender, EventArgs e)
        {
            PembelianDetail pd = new PembelianDetail();
            pd.setKode(kodePembelian.Text);
            pd.DeletePembelianDetail();
            MessageBox.Show("1 Record Succesfully Deleted");
            kodePembelian.Clear();
            dataGridView_PembelianDetail.DataSource = pd.showDataPembelianDetail();
            dataGridView_PembelianDetail.Refresh();
        }

        private void btnSavePembelian_Click(object sender, EventArgs e)
        { }

        private void subTotalPembelian_TextChanged(object sender, EventArgs e)
        { }

        private void totalPembelian_TextChanged(object sender, EventArgs e)
        { }

        private void qtyBrgPembelian_TextChanged(object sender, EventArgs e)
        {
            if (qtyBrgPembelian.Text.Trim() == "") TotalPembelian.Text = hrgBrgPembelian.Text;
            else
            {
                TotalPembelian.Text = (int.Parse(qtyBrgPembelian.Text) * decimal.Parse(hrgBrgPembelian.Text)).ToString();
            }
        }

        private void dataGridView_PembelianDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        { }

        private void menuTransaction_Load(object sender, EventArgs e)
        {
            PembelianDetail pembelian = new PembelianDetail();
            PenjualanDetail penjualan = new PenjualanDetail();
            dataGridView_PembelianDetail.DataSource = pembelian.showDataPembelianDetail();
            dataGridView_PenjualanDetail.DataSource = penjualan.showDataPenjualanDetail();
        }

        private void hrgBrgPembelian_TextChanged(object sender, EventArgs e)
        {
            if (hrgBrgPembelian.Text.Trim() == "") TotalPembelian.Text = 0.ToString();
            else TotalPembelian.Text = hrgBrgPembelian.Text;
        }

        private void btnAddPenjualan_Click(object sender, EventArgs e)
        {
            PenjualanDetail pd = new PenjualanDetail();
            pd.setKode(kodePenjualan.Text);
            pd.setidCust(int.Parse(custPenjualan.Text));
            pd.setidBrg(int.Parse(brgPenjualan.Text));
            pd.sethrgBrg(int.Parse(hrgBrgPenjualan.Text));
            pd.setQty(int.Parse(qtyBrgPenjualan.Text));
            pd.settotalHrg(decimal.Parse(TotalPenjualan.Text));
            pd.setcreated_at(DateTime.Now);
            pd.setupdated_at(DateTime.Now);
            pd.InsertPenjualanDetail();
            MessageBox.Show("1 Record Succesfully Saved");
            kodePenjualan.Clear();
            custPenjualan.Clear();
            brgPenjualan.Clear();
            hrgBrgPenjualan.Clear();
            qtyBrgPenjualan.Clear();
            TotalPenjualan.Clear();
            dataGridView_PenjualanDetail.DataSource = pd.showDataPenjualanDetail();
            dataGridView_PenjualanDetail.Refresh();
        }

        private void butEditPenjualan_Click(object sender, EventArgs e)
        {
            PenjualanDetail pd = new PenjualanDetail();
            pd.setKode(kodePenjualan.Text);
            pd.setidCust(int.Parse(custPenjualan.Text));
            pd.setidBrg(int.Parse(brgPenjualan.Text));
            pd.sethrgBrg(int.Parse(hrgBrgPenjualan.Text));
            pd.setQty(int.Parse(qtyBrgPenjualan.Text));
            pd.settotalHrg(decimal.Parse(TotalPenjualan.Text));
            pd.setupdated_at(DateTime.Now);
            pd.UpdatePenjualanDetail();
            MessageBox.Show("1 Record Succesfully Updated");
            kodePenjualan.Clear();
            custPenjualan.Clear();
            brgPenjualan.Clear();
            hrgBrgPenjualan.Clear();
            qtyBrgPenjualan.Clear();
            TotalPenjualan.Clear();
            dataGridView_PenjualanDetail.DataSource = pd.showDataPenjualanDetail();
            dataGridView_PenjualanDetail.Refresh();
        }

        private void btnDelPenjualan_Click(object sender, EventArgs e)
        {
            PenjualanDetail pd = new PenjualanDetail();
            pd.setKode(kodePenjualan.Text);
            pd.DeletePenjualanDetail();
            MessageBox.Show("1 Record Succesfully Deleted");
            kodePenjualan.Clear();
            dataGridView_PenjualanDetail.DataSource = pd.showDataPenjualanDetail();
            dataGridView_PenjualanDetail.Refresh();
        }

        private void hrgBrgPenjualan_TextChanged(object sender, EventArgs e)
        {
            if (hrgBrgPenjualan.Text.Trim() == "") TotalPenjualan.Text = 0.ToString();
            else TotalPenjualan.Text = hrgBrgPenjualan.Text;
        }

        private void qtyBrgPenjualan_TextChanged(object sender, EventArgs e)
        {
            if (qtyBrgPenjualan.Text.Trim() == "") TotalPenjualan.Text = hrgBrgPenjualan.Text;
            else
            {
                TotalPenjualan.Text = (int.Parse(qtyBrgPenjualan.Text) * decimal.Parse(hrgBrgPenjualan.Text)).ToString();
            }
        }

        private void dataGridView_PenjualanDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        { }

        private void menuTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.connection.Dispose();
            parentform.Enabled = true;
        }
    }
}
