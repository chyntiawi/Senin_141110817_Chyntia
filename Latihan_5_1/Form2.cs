using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form2 : Form
    {
        Form1 parentform;
        public Form2(Form1 pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tree.SelectedNode.Text == "Background Color")
                bgcolor_panel.Visible = true;
            else
                bgcolor_panel.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bgcolor_panel.Visible = false;
            foreach (KnownColor bg_color in Enum.GetValues(typeof(KnownColor)))
            {
                bgcolor.Items.Add(bg_color);
            }
        }

        private void bgcolor_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void tree_MouseClick(object sender, MouseEventArgs e)
        { }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        { }

        private void savebutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            parentform.textboxparent = Color.FromName(bgcolor.SelectedItem.ToString());
        }

        private void savebutton_Click(object sender, EventArgs e)
        { }
    }
}
