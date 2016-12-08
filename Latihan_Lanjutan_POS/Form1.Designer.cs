namespace Latihan_Lanjutan_POS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrasi = new System.Windows.Forms.ToolStripMenuItem();
            this.barang = new System.Windows.Forms.ToolStripMenuItem();
            this.cust = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrasi
            // 
            this.registrasi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barang,
            this.cust,
            this.supplier,
            this.exit});
            this.registrasi.Name = "registrasi";
            this.registrasi.Size = new System.Drawing.Size(69, 20);
            this.registrasi.Text = "Registrasi";
            this.registrasi.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.registrasi_DropDownItemClicked);
            // 
            // barang
            // 
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(126, 22);
            this.barang.Text = "Barang";
            // 
            // cust
            // 
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(126, 22);
            this.cust.Text = "Customer";
            this.cust.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cust_DropDownItemClicked);
            this.cust.Click += new System.EventHandler(this.cust_Click);
            // 
            // supplier
            // 
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(126, 22);
            this.supplier.Text = "Supplier";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 339);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrasi;
        private System.Windows.Forms.ToolStripMenuItem barang;
        private System.Windows.Forms.ToolStripMenuItem cust;
        private System.Windows.Forms.ToolStripMenuItem supplier;
        private System.Windows.Forms.ToolStripMenuItem exit;
    }
}

