﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        private bool txtchange;
        public Form1()
        {
            InitializeComponent();
            bold.Font = new Font(bold.Font, FontStyle.Bold);
            italic.Font = new Font(italic.Font, FontStyle.Italic);
            underline.Font = new Font(underline.Font, FontStyle.Underline);
            txtchange = false;
        }

        private void bold_Click(object sender, EventArgs e)
        {
            if (textbox.SelectionFont.Bold)
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style ^ FontStyle.Bold);
                bold.Checked = false;
            }
            else
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style | FontStyle.Bold);
                bold.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fontcolor
            foreach (KnownColor fontcolor in Enum.GetValues(typeof(KnownColor)))
            {
                color.Items.Add(fontcolor);
            }

            //backcolor
            foreach (KnownColor back_color in Enum.GetValues(typeof(KnownColor)))
            {
                backcolor.Items.Add(back_color);
            }

            //fontsize
            for (int i = 2; i <= 74; i += 2)
            {
                size.Items.Add(i + " px");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtchange)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        textbox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    textbox.Clear();
                }
                else if (result == DialogResult.No)
                {
                    textbox.Clear();
                }
            }
            else
            {
                textbox.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textbox.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if(save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                textbox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtchange)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        textbox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if(result == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.SelectionColor = Color.FromName(color.Text);
        }

        private void backcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.SelectionBackColor = Color.FromName(backcolor.Text);
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        { }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            txtchange = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtchange)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        textbox.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (textbox.SelectionFont.Italic)
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style ^ FontStyle.Italic);
                italic.Checked = false;
            }
            else
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style | FontStyle.Italic);
                italic.Checked = true;
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (textbox.SelectionFont.Underline)
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style ^ FontStyle.Underline);
                underline.Checked = false;
            }
            else
            {
                textbox.SelectionFont = new Font(textbox.SelectionFont, textbox.SelectionFont.Style | FontStyle.Underline);
                underline.Checked = true;
            }
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.SelectionFont = new System.Drawing.Font(textbox.SelectionFont.FontFamily, Convert.ToInt32(size.Text.Split(' ')[0]), textbox.SelectionFont.Style);
        }
    }
}
