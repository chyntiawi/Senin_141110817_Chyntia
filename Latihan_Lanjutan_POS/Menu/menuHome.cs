using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_Lanjutan_POS
{
    public partial class menuHome : MetroFramework.Forms.MetroForm
    {
        public menuHome()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            menuRegister register = new menuRegister(this);
            menuHome parent = new menuHome();
            register.MdiParent = this.ParentForm;
            register.Show();
            this.Enabled = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            menuEdit edit = new menuEdit(this);
            menuHome parent = new menuHome();
            edit.MdiParent = this.ParentForm;
            edit.Show();
            this.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            menuDelete del = new menuDelete(this);
            menuHome parent = new menuHome();
            del.MdiParent = this.ParentForm;
            del.Show();
            this.Enabled = false;
        }

        private void list_Click(object sender, EventArgs e)
        {
            menuList list = new menuList(this);
            menuHome parent = new menuHome();
            list.MdiParent = this.ParentForm;
            list.Show();
            this.Enabled = false;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            menuTransaction transaction = new menuTransaction(this);
            menuHome parent = new menuHome();
            transaction.MdiParent = this.ParentForm;
            transaction.Show();
            this.Enabled = false;
        }

        private void register_MouseClick(object sender, MouseEventArgs e)
        { }
    }
}
