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
    public partial class menuEdit : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        menuHome parentform;
        public menuEdit(menuHome pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Barang brg = new Barang();
            brg.setidBrg(int.Parse(idBrg.Text));
            brg.setkodeBrg(kodeBrg.Text);
            brg.setnamaBrg(namaBrg.Text);
            brg.setjlhAwalBrg(int.Parse(jlhAwalBrg.Text));
            brg.sethrgHppBrg(decimal.Parse(hrgHppBrg.Text));
            brg.sethrgJualBrg(decimal.Parse(hrgJualBrg.Text));
            brg.setcreated_at(DateTime.Now);
            brg.setupdated_at(DateTime.Now);
            brg.UpdateBrg();
            MessageBox.Show("1 Record Succesfully Updated");
            idBrg.Clear();
            kodeBrg.Clear();
            namaBrg.Clear();
            jlhAwalBrg.Clear();
            hrgHppBrg.Clear();
            hrgJualBrg.Clear();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            idBrg.Clear();
            kodeBrg.Clear();
            namaBrg.Clear();
            jlhAwalBrg.Clear();
            hrgHppBrg.Clear();
            hrgJualBrg.Clear();
        }

        private void butSaveCust_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.setidCust(int.Parse(idCust.Text));
            cust.setkodeCust(kodeCust.Text);
            cust.setnamaCust(namaCust.Text);
            cust.setalamatCust(alamatCust.Text);
            cust.settelpCust(telpCust.Text);
            cust.sethpCust(hpCust.Text);
            cust.UpdateCust();
            MessageBox.Show("1 Record Succesfully Updated");
            idCust.Clear();
            kodeCust.Clear();
            namaCust.Clear();
            alamatCust.Clear();
            telpCust.Clear();
            hpCust.Clear();
        }

        private void butCancelCust_Click(object sender, EventArgs e)
        {
            idCust.Clear();
            kodeCust.Clear();
            namaCust.Clear();
            alamatCust.Clear();
            telpCust.Clear();
            hpCust.Clear();
        }

        private void butSaveSup_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.setidSup(int.Parse(idSup.Text));
            sup.setkodeSup(kodeSup.Text);
            sup.setnamaSup(namaSup.Text);
            sup.setalamatSup(alamatSup.Text);
            sup.settelpSup(telpSup.Text);
            sup.sethpSup(hpSup.Text);
            sup.UpdateSup();
            MessageBox.Show("1 Record Succesfully Updated");
            idSup.Clear();
            kodeSup.Clear();
            namaSup.Clear();
            alamatSup.Clear();
            telpSup.Clear();
            hpSup.Clear();
        }

        private void butCancelSup_Click(object sender, EventArgs e)
        {
            idSup.Clear();
            kodeSup.Clear();
            namaSup.Clear();
            alamatSup.Clear();
            telpSup.Clear();
            hpSup.Clear();
        }

        private void menuEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.connection.Dispose();
            parentform.Enabled = true;
        }
    }
}
