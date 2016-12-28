namespace Latihan_Lanjutan_POS
{
    partial class menuList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.register = new MetroFramework.Controls.MetroTabControl();
            this.tabBrg = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView_Brg = new MetroFramework.Controls.MetroGrid();
            this.tabCust = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView_Cust = new MetroFramework.Controls.MetroGrid();
            this.tabSup = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView_Sup = new MetroFramework.Controls.MetroGrid();
            this.register.SuspendLayout();
            this.tabBrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Brg)).BeginInit();
            this.tabCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cust)).BeginInit();
            this.tabSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sup)).BeginInit();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register.Controls.Add(this.tabBrg);
            this.register.Controls.Add(this.tabCust);
            this.register.Controls.Add(this.tabSup);
            this.register.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.register.Location = new System.Drawing.Point(2, 63);
            this.register.Name = "register";
            this.register.SelectedIndex = 0;
            this.register.Size = new System.Drawing.Size(614, 389);
            this.register.Style = MetroFramework.MetroColorStyle.Teal;
            this.register.TabIndex = 3;
            this.register.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.register.UseSelectable = true;
            this.register.UseStyleColors = true;
            this.register.SelectedIndexChanged += new System.EventHandler(this.register_SelectedIndexChanged);
            this.register.Selected += new System.Windows.Forms.TabControlEventHandler(this.register_Selected);
            // 
            // tabBrg
            // 
            this.tabBrg.Controls.Add(this.dataGridView_Brg);
            this.tabBrg.HorizontalScrollbarBarColor = true;
            this.tabBrg.HorizontalScrollbarHighlightOnWheel = false;
            this.tabBrg.HorizontalScrollbarSize = 10;
            this.tabBrg.Location = new System.Drawing.Point(4, 38);
            this.tabBrg.Name = "tabBrg";
            this.tabBrg.Size = new System.Drawing.Size(606, 347);
            this.tabBrg.Style = MetroFramework.MetroColorStyle.Teal;
            this.tabBrg.TabIndex = 0;
            this.tabBrg.Text = "Barang";
            this.tabBrg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabBrg.UseStyleColors = true;
            this.tabBrg.VerticalScrollbarBarColor = true;
            this.tabBrg.VerticalScrollbarHighlightOnWheel = false;
            this.tabBrg.VerticalScrollbarSize = 10;
            // 
            // dataGridView_Brg
            // 
            this.dataGridView_Brg.AllowUserToAddRows = false;
            this.dataGridView_Brg.AllowUserToDeleteRows = false;
            this.dataGridView_Brg.AllowUserToResizeRows = false;
            this.dataGridView_Brg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Brg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_Brg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Brg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Brg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Brg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Brg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Brg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Brg.EnableHeadersVisualStyles = false;
            this.dataGridView_Brg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView_Brg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_Brg.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Brg.Name = "dataGridView_Brg";
            this.dataGridView_Brg.ReadOnly = true;
            this.dataGridView_Brg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Brg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Brg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Brg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_Brg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Brg.Size = new System.Drawing.Size(606, 347);
            this.dataGridView_Brg.Style = MetroFramework.MetroColorStyle.Green;
            this.dataGridView_Brg.TabIndex = 2;
            this.dataGridView_Brg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dataGridView_Brg.UseStyleColors = true;
            // 
            // tabCust
            // 
            this.tabCust.Controls.Add(this.dataGridView_Cust);
            this.tabCust.HorizontalScrollbarBarColor = true;
            this.tabCust.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCust.HorizontalScrollbarSize = 10;
            this.tabCust.Location = new System.Drawing.Point(4, 38);
            this.tabCust.Name = "tabCust";
            this.tabCust.Size = new System.Drawing.Size(606, 347);
            this.tabCust.Style = MetroFramework.MetroColorStyle.Green;
            this.tabCust.TabIndex = 1;
            this.tabCust.Text = "Customer";
            this.tabCust.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCust.UseStyleColors = true;
            this.tabCust.VerticalScrollbarBarColor = true;
            this.tabCust.VerticalScrollbarHighlightOnWheel = false;
            this.tabCust.VerticalScrollbarSize = 10;
            this.tabCust.Click += new System.EventHandler(this.tabCust_Click);
            // 
            // dataGridView_Cust
            // 
            this.dataGridView_Cust.AllowUserToAddRows = false;
            this.dataGridView_Cust.AllowUserToDeleteRows = false;
            this.dataGridView_Cust.AllowUserToResizeRows = false;
            this.dataGridView_Cust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Cust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_Cust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Cust.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Cust.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Cust.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Cust.EnableHeadersVisualStyles = false;
            this.dataGridView_Cust.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView_Cust.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_Cust.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cust.Name = "dataGridView_Cust";
            this.dataGridView_Cust.ReadOnly = true;
            this.dataGridView_Cust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cust.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Cust.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Cust.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_Cust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cust.Size = new System.Drawing.Size(606, 347);
            this.dataGridView_Cust.Style = MetroFramework.MetroColorStyle.Green;
            this.dataGridView_Cust.TabIndex = 2;
            this.dataGridView_Cust.TabStop = false;
            this.dataGridView_Cust.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dataGridView_Cust.UseStyleColors = true;
            // 
            // tabSup
            // 
            this.tabSup.Controls.Add(this.dataGridView_Sup);
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
            // dataGridView_Sup
            // 
            this.dataGridView_Sup.AllowUserToAddRows = false;
            this.dataGridView_Sup.AllowUserToDeleteRows = false;
            this.dataGridView_Sup.AllowUserToResizeRows = false;
            this.dataGridView_Sup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Sup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_Sup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Sup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Sup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Sup.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Sup.EnableHeadersVisualStyles = false;
            this.dataGridView_Sup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView_Sup.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView_Sup.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Sup.Name = "dataGridView_Sup";
            this.dataGridView_Sup.ReadOnly = true;
            this.dataGridView_Sup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sup.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Sup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Sup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Sup.Size = new System.Drawing.Size(606, 347);
            this.dataGridView_Sup.Style = MetroFramework.MetroColorStyle.Green;
            this.dataGridView_Sup.TabIndex = 2;
            this.dataGridView_Sup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dataGridView_Sup.UseStyleColors = true;
            // 
            // menuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 453);
            this.Controls.Add(this.register);
            this.Name = "menuList";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "List";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuList_FormClosed);
            this.Load += new System.EventHandler(this.menuList_Load);
            this.register.ResumeLayout(false);
            this.tabBrg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Brg)).EndInit();
            this.tabCust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cust)).EndInit();
            this.tabSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl register;
        private MetroFramework.Controls.MetroTabPage tabBrg;
        private MetroFramework.Controls.MetroTabPage tabCust;
        private MetroFramework.Controls.MetroTabPage tabSup;
        private MetroFramework.Controls.MetroGrid dataGridView_Brg;
        private MetroFramework.Controls.MetroGrid dataGridView_Cust;
        private MetroFramework.Controls.MetroGrid dataGridView_Sup;
    }
}