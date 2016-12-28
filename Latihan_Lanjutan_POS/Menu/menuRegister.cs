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
using Latihan_Lanjutan_POS.Class;

namespace Latihan_Lanjutan_POS
{
    public partial class menuRegister : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        menuHome parentform;
        public menuRegister(menuHome pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void menuRegister_Load(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            idSup.Text = sup.showIdSup();
        }

        private void menuRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.connection.Dispose();
            parentform.Enabled = true;
        }

        private void butSaveBrg_Click(object sender, EventArgs e)
        {
            Barang brg = new Barang();
            brg.setkodeBrg(kodeBrg.Text);
            brg.setnamaBrg(namaBrg.Text);
            brg.setjlhAwalBrg(int.Parse(jlhAwalBrg.Text));
            brg.sethrgHppBrg(decimal.Parse(hrgHppBrg.Text));
            brg.sethrgJualBrg(decimal.Parse(hrgJualBrg.Text));
            brg.setcreated_at(DateTime.Now);
            brg.setupdated_at(DateTime.Now);
            brg.InsertBrg();
            MessageBox.Show("1 Record Succesfully Saved");
            kodeBrg.Clear();
            namaBrg.Clear();
            jlhAwalBrg.Clear();
            hrgHppBrg.Clear();
            hrgJualBrg.Clear();
        }

        private void butCancelBrg_Click(object sender, EventArgs e)
        {
            kodeBrg.Clear();
            namaBrg.Clear();
            jlhAwalBrg.Clear();
            hrgHppBrg.Clear();
            hrgJualBrg.Clear();
        }

        private void butSaveCust_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.setkodeCust(kodeCust.Text);
            cust.setnamaCust(namaCust.Text);
            cust.setalamatCust(alamatCust.Text);
            cust.settelpCust(telpCust.Text);
            cust.sethpCust(hpCust.Text);
            cust.InsertCust();
            MessageBox.Show("1 Record Succesfully Saved");
            kodeCust.Clear();
            namaCust.Clear();
            alamatCust.Clear();
            telpCust.Clear();
            hpCust.Clear();
        }

        private void butCancelCust_Click(object sender, EventArgs e)
        {
            kodeCust.Clear();
            namaCust.Clear();
            alamatCust.Clear();
            telpCust.Clear();
            hpCust.Clear();
        }

        private void butSaveSup_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.setkodeSup(kodeSup.Text);
            sup.setnamaSup(namaSup.Text);
            sup.setalamatSup(alamatSup.Text);
            sup.settelpSup(telpSup.Text);
            sup.sethpSup(hpSup.Text);
            sup.InsertSup();
            MessageBox.Show("1 Record Succesfully Saved");
            kodeSup.Clear();
            namaSup.Clear();
            alamatSup.Clear();
            telpSup.Clear();
            hpSup.Clear();
        }

        private void butCancelSup_Click(object sender, EventArgs e)
        {
            kodeSup.Clear();
            namaSup.Clear();
            alamatSup.Clear();
            telpSup.Clear();
            hpSup.Clear();
        }

        private void register_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (register.SelectedTab.Text == tabBrg.Text)
            {
                Barang brg = new Barang();
                idBrg.Text = brg.showIdBrg();
            }
            else if (register.SelectedTab.Text == tabCust.Text)
            {
                Customer cust = new Customer();
                idCust.Text = cust.showIdCust();
            }
            else if (register.SelectedTab.Text == tabSup.Text)
            {
                Supplier sup = new Supplier();
                idSup.Text = sup.showIdSup();
            }
        }
    }
}
