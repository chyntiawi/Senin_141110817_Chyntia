namespace Latihan_POS
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
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_dftrBrg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.kode = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.jlhAwal = new System.Windows.Forms.TextBox();
            this.hrgHpp = new System.Windows.Forms.TextBox();
            this.hrgJual = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_dftrBrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrasi
            // 
            this.registrasi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barang,
            this.exit});
            this.registrasi.Name = "registrasi";
            this.registrasi.Size = new System.Drawing.Size(69, 20);
            this.registrasi.Text = "Registrasi";
            this.registrasi.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.registrasi_DropDownItemClicked);
            // 
            // barang
            // 
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(152, 22);
            this.barang.Text = "Barang";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(152, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel_dftrBrg
            // 
            this.panel_dftrBrg.Controls.Add(this.btnKeluar);
            this.panel_dftrBrg.Controls.Add(this.btnCancel);
            this.panel_dftrBrg.Controls.Add(this.btnSimpan);
            this.panel_dftrBrg.Controls.Add(this.hrgJual);
            this.panel_dftrBrg.Controls.Add(this.hrgHpp);
            this.panel_dftrBrg.Controls.Add(this.jlhAwal);
            this.panel_dftrBrg.Controls.Add(this.nama);
            this.panel_dftrBrg.Controls.Add(this.kode);
            this.panel_dftrBrg.Controls.Add(this.id);
            this.panel_dftrBrg.Controls.Add(this.label13);
            this.panel_dftrBrg.Controls.Add(this.label12);
            this.panel_dftrBrg.Controls.Add(this.label11);
            this.panel_dftrBrg.Controls.Add(this.label10);
            this.panel_dftrBrg.Controls.Add(this.label9);
            this.panel_dftrBrg.Controls.Add(this.label8);
            this.panel_dftrBrg.Controls.Add(this.label7);
            this.panel_dftrBrg.Controls.Add(this.label6);
            this.panel_dftrBrg.Controls.Add(this.label5);
            this.panel_dftrBrg.Controls.Add(this.label4);
            this.panel_dftrBrg.Controls.Add(this.label3);
            this.panel_dftrBrg.Controls.Add(this.label2);
            this.panel_dftrBrg.Controls.Add(this.label1);
            this.panel_dftrBrg.Location = new System.Drawing.Point(0, 27);
            this.panel_dftrBrg.Name = "panel_dftrBrg";
            this.panel_dftrBrg.Size = new System.Drawing.Size(383, 312);
            this.panel_dftrBrg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jumlah Awal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Harga HPP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Harga Jual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = ":";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(139, 47);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(124, 20);
            this.id.TabIndex = 2;
            // 
            // kode
            // 
            this.kode.Location = new System.Drawing.Point(139, 73);
            this.kode.Name = "kode";
            this.kode.Size = new System.Drawing.Size(124, 20);
            this.kode.TabIndex = 2;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(139, 101);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(124, 20);
            this.nama.TabIndex = 2;
            // 
            // jlhAwal
            // 
            this.jlhAwal.Location = new System.Drawing.Point(139, 129);
            this.jlhAwal.Name = "jlhAwal";
            this.jlhAwal.Size = new System.Drawing.Size(124, 20);
            this.jlhAwal.TabIndex = 2;
            // 
            // hrgHpp
            // 
            this.hrgHpp.Location = new System.Drawing.Point(139, 159);
            this.hrgHpp.Name = "hrgHpp";
            this.hrgHpp.Size = new System.Drawing.Size(124, 20);
            this.hrgHpp.TabIndex = 2;
            // 
            // hrgJual
            // 
            this.hrgJual.Location = new System.Drawing.Point(139, 190);
            this.hrgJual.Name = "hrgJual";
            this.hrgJual.Size = new System.Drawing.Size(124, 20);
            this.hrgJual.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(284, 93);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(284, 151);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 3;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 339);
            this.Controls.Add(this.panel_dftrBrg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_dftrBrg.ResumeLayout(false);
            this.panel_dftrBrg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrasi;
        private System.Windows.Forms.ToolStripMenuItem barang;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Panel panel_dftrBrg;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox hrgJual;
        private System.Windows.Forms.TextBox hrgHpp;
        private System.Windows.Forms.TextBox jlhAwal;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox kode;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

