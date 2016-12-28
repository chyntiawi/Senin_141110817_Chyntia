namespace Latihan_Lanjutan_POS
{
    partial class menuDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuDelete));
            this.register = new MetroFramework.Controls.MetroTabControl();
            this.tabBrg = new MetroFramework.Controls.MetroTabPage();
            this.butDelBrg = new MetroFramework.Controls.MetroTile();
            this.idBrg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabCust = new MetroFramework.Controls.MetroTabPage();
            this.butDelCust = new MetroFramework.Controls.MetroTile();
            this.idCust = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.tabSup = new MetroFramework.Controls.MetroTabPage();
            this.butDelSup = new MetroFramework.Controls.MetroTile();
            this.idSup = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel35 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel36 = new MetroFramework.Controls.MetroLabel();
            this.register.SuspendLayout();
            this.tabBrg.SuspendLayout();
            this.tabCust.SuspendLayout();
            this.tabSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Controls.Add(this.tabBrg);
            this.register.Controls.Add(this.tabCust);
            this.register.Controls.Add(this.tabSup);
            this.register.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.register.Location = new System.Drawing.Point(0, 63);
            this.register.Name = "register";
            this.register.SelectedIndex = 2;
            this.register.Size = new System.Drawing.Size(614, 389);
            this.register.Style = MetroFramework.MetroColorStyle.Teal;
            this.register.TabIndex = 2;
            this.register.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.register.UseSelectable = true;
            this.register.UseStyleColors = true;
            // 
            // tabBrg
            // 
            this.tabBrg.Controls.Add(this.butDelBrg);
            this.tabBrg.Controls.Add(this.idBrg);
            this.tabBrg.Controls.Add(this.metroLabel7);
            this.tabBrg.Controls.Add(this.metroLabel1);
            this.tabBrg.HorizontalScrollbarBarColor = true;
            this.tabBrg.HorizontalScrollbarHighlightOnWheel = false;
            this.tabBrg.HorizontalScrollbarSize = 10;
            this.tabBrg.Location = new System.Drawing.Point(4, 38);
            this.tabBrg.Name = "tabBrg";
            this.tabBrg.Size = new System.Drawing.Size(606, 347);
            this.tabBrg.TabIndex = 0;
            this.tabBrg.Text = "Barang";
            this.tabBrg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabBrg.UseStyleColors = true;
            this.tabBrg.VerticalScrollbarBarColor = true;
            this.tabBrg.VerticalScrollbarHighlightOnWheel = false;
            this.tabBrg.VerticalScrollbarSize = 10;
            // 
            // butDelBrg
            // 
            this.butDelBrg.ActiveControl = null;
            this.butDelBrg.Location = new System.Drawing.Point(324, 179);
            this.butDelBrg.Name = "butDelBrg";
            this.butDelBrg.Size = new System.Drawing.Size(88, 35);
            this.butDelBrg.Style = MetroFramework.MetroColorStyle.Blue;
            this.butDelBrg.TabIndex = 4;
            this.butDelBrg.Text = "Delete";
            this.butDelBrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDelBrg.TileImage = ((System.Drawing.Image)(resources.GetObject("butDelBrg.TileImage")));
            this.butDelBrg.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelBrg.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.butDelBrg.UseSelectable = true;
            this.butDelBrg.UseStyleColors = true;
            this.butDelBrg.UseTileImage = true;
            this.butDelBrg.Click += new System.EventHandler(this.butDelBrg_Click);
            // 
            // idBrg
            // 
            // 
            // 
            // 
            this.idBrg.CustomButton.Image = null;
            this.idBrg.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.idBrg.CustomButton.Name = "";
            this.idBrg.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idBrg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idBrg.CustomButton.TabIndex = 1;
            this.idBrg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idBrg.CustomButton.UseSelectable = true;
            this.idBrg.CustomButton.Visible = false;
            this.idBrg.Lines = new string[0];
            this.idBrg.Location = new System.Drawing.Point(268, 121);
            this.idBrg.MaxLength = 32767;
            this.idBrg.Name = "idBrg";
            this.idBrg.PasswordChar = '\0';
            this.idBrg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idBrg.SelectedText = "";
            this.idBrg.SelectionLength = 0;
            this.idBrg.SelectionStart = 0;
            this.idBrg.ShortcutsEnabled = true;
            this.idBrg.Size = new System.Drawing.Size(144, 23);
            this.idBrg.TabIndex = 3;
            this.idBrg.UseSelectable = true;
            this.idBrg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idBrg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(250, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(12, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = ":";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(168, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // tabCust
            // 
            this.tabCust.Controls.Add(this.butDelCust);
            this.tabCust.Controls.Add(this.idCust);
            this.tabCust.Controls.Add(this.metroLabel23);
            this.tabCust.Controls.Add(this.metroLabel24);
            this.tabCust.HorizontalScrollbarBarColor = true;
            this.tabCust.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCust.HorizontalScrollbarSize = 10;
            this.tabCust.Location = new System.Drawing.Point(4, 38);
            this.tabCust.Name = "tabCust";
            this.tabCust.Size = new System.Drawing.Size(606, 347);
            this.tabCust.TabIndex = 1;
            this.tabCust.Text = "Customer";
            this.tabCust.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCust.UseStyleColors = true;
            this.tabCust.VerticalScrollbarBarColor = true;
            this.tabCust.VerticalScrollbarHighlightOnWheel = false;
            this.tabCust.VerticalScrollbarSize = 10;
            // 
            // butDelCust
            // 
            this.butDelCust.ActiveControl = null;
            this.butDelCust.Location = new System.Drawing.Point(331, 177);
            this.butDelCust.Name = "butDelCust";
            this.butDelCust.Size = new System.Drawing.Size(88, 35);
            this.butDelCust.Style = MetroFramework.MetroColorStyle.Blue;
            this.butDelCust.TabIndex = 19;
            this.butDelCust.Text = "Delete";
            this.butDelCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDelCust.TileImage = ((System.Drawing.Image)(resources.GetObject("butDelCust.TileImage")));
            this.butDelCust.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelCust.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.butDelCust.UseSelectable = true;
            this.butDelCust.UseStyleColors = true;
            this.butDelCust.UseTileImage = true;
            this.butDelCust.Click += new System.EventHandler(this.butDelCust_Click);
            // 
            // idCust
            // 
            // 
            // 
            // 
            this.idCust.CustomButton.Image = null;
            this.idCust.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.idCust.CustomButton.Name = "";
            this.idCust.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idCust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idCust.CustomButton.TabIndex = 1;
            this.idCust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idCust.CustomButton.UseSelectable = true;
            this.idCust.CustomButton.Visible = false;
            this.idCust.Lines = new string[0];
            this.idCust.Location = new System.Drawing.Point(275, 118);
            this.idCust.MaxLength = 32767;
            this.idCust.Name = "idCust";
            this.idCust.PasswordChar = '\0';
            this.idCust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idCust.SelectedText = "";
            this.idCust.SelectionLength = 0;
            this.idCust.SelectionStart = 0;
            this.idCust.ShortcutsEnabled = true;
            this.idCust.Size = new System.Drawing.Size(144, 23);
            this.idCust.TabIndex = 17;
            this.idCust.UseSelectable = true;
            this.idCust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idCust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(257, 122);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(12, 19);
            this.metroLabel23.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel23.TabIndex = 16;
            this.metroLabel23.Text = ":";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel23.UseStyleColors = true;
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(175, 122);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(21, 19);
            this.metroLabel24.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel24.TabIndex = 14;
            this.metroLabel24.Text = "ID";
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel24.UseStyleColors = true;
            // 
            // tabSup
            // 
            this.tabSup.Controls.Add(this.butDelSup);
            this.tabSup.Controls.Add(this.idSup);
            this.tabSup.Controls.Add(this.metroLabel35);
            this.tabSup.Controls.Add(this.metroLabel36);
            this.tabSup.HorizontalScrollbarBarColor = true;
            this.tabSup.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSup.HorizontalScrollbarSize = 10;
            this.tabSup.Location = new System.Drawing.Point(4, 38);
            this.tabSup.Name = "tabSup";
            this.tabSup.Size = new System.Drawing.Size(606, 347);
            this.tabSup.TabIndex = 2;
            this.tabSup.Text = "Supplier";
            this.tabSup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabSup.UseStyleColors = true;
            this.tabSup.VerticalScrollbarBarColor = true;
            this.tabSup.VerticalScrollbarHighlightOnWheel = false;
            this.tabSup.VerticalScrollbarSize = 10;
            // 
            // butDelSup
            // 
            this.butDelSup.ActiveControl = null;
            this.butDelSup.Location = new System.Drawing.Point(321, 173);
            this.butDelSup.Name = "butDelSup";
            this.butDelSup.Size = new System.Drawing.Size(88, 35);
            this.butDelSup.Style = MetroFramework.MetroColorStyle.Blue;
            this.butDelSup.TabIndex = 40;
            this.butDelSup.Text = "Delete";
            this.butDelSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butDelSup.TileImage = ((System.Drawing.Image)(resources.GetObject("butDelSup.TileImage")));
            this.butDelSup.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelSup.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.butDelSup.UseSelectable = true;
            this.butDelSup.UseStyleColors = true;
            this.butDelSup.UseTileImage = true;
            this.butDelSup.Click += new System.EventHandler(this.butDelSup_Click);
            // 
            // idSup
            // 
            // 
            // 
            // 
            this.idSup.CustomButton.Image = null;
            this.idSup.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.idSup.CustomButton.Name = "";
            this.idSup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idSup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idSup.CustomButton.TabIndex = 1;
            this.idSup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idSup.CustomButton.UseSelectable = true;
            this.idSup.CustomButton.Visible = false;
            this.idSup.Lines = new string[0];
            this.idSup.Location = new System.Drawing.Point(265, 112);
            this.idSup.MaxLength = 32767;
            this.idSup.Name = "idSup";
            this.idSup.PasswordChar = '\0';
            this.idSup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idSup.SelectedText = "";
            this.idSup.SelectionLength = 0;
            this.idSup.SelectionStart = 0;
            this.idSup.ShortcutsEnabled = true;
            this.idSup.Size = new System.Drawing.Size(144, 23);
            this.idSup.TabIndex = 38;
            this.idSup.UseSelectable = true;
            this.idSup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idSup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel35
            // 
            this.metroLabel35.AutoSize = true;
            this.metroLabel35.Location = new System.Drawing.Point(247, 116);
            this.metroLabel35.Name = "metroLabel35";
            this.metroLabel35.Size = new System.Drawing.Size(12, 19);
            this.metroLabel35.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel35.TabIndex = 37;
            this.metroLabel35.Text = ":";
            this.metroLabel35.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel35.UseStyleColors = true;
            // 
            // metroLabel36
            // 
            this.metroLabel36.AutoSize = true;
            this.metroLabel36.Location = new System.Drawing.Point(165, 116);
            this.metroLabel36.Name = "metroLabel36";
            this.metroLabel36.Size = new System.Drawing.Size(21, 19);
            this.metroLabel36.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel36.TabIndex = 35;
            this.metroLabel36.Text = "ID";
            this.metroLabel36.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel36.UseStyleColors = true;
            // 
            // menuDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 454);
            this.Controls.Add(this.register);
            this.Name = "menuDelete";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Delete";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuDelete_FormClosed);
            this.register.ResumeLayout(false);
            this.tabBrg.ResumeLayout(false);
            this.tabBrg.PerformLayout();
            this.tabCust.ResumeLayout(false);
            this.tabCust.PerformLayout();
            this.tabSup.ResumeLayout(false);
            this.tabSup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl register;
        private MetroFramework.Controls.MetroTabPage tabBrg;
        private MetroFramework.Controls.MetroTile butDelBrg;
        private MetroFramework.Controls.MetroTextBox idBrg;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tabCust;
        private MetroFramework.Controls.MetroTile butDelCust;
        private MetroFramework.Controls.MetroTextBox idCust;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroTabPage tabSup;
        private MetroFramework.Controls.MetroTile butDelSup;
        private MetroFramework.Controls.MetroTextBox idSup;
        private MetroFramework.Controls.MetroLabel metroLabel35;
        private MetroFramework.Controls.MetroLabel metroLabel36;
    }
}