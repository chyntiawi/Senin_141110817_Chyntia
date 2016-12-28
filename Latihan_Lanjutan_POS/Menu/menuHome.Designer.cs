namespace Latihan_Lanjutan_POS
{
    partial class menuHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuHome));
            this.register = new MetroFramework.Controls.MetroTile();
            this.edit = new MetroFramework.Controls.MetroTile();
            this.list = new MetroFramework.Controls.MetroTile();
            this.delete = new MetroFramework.Controls.MetroTile();
            this.labelRegister = new MetroFramework.Controls.MetroLabel();
            this.labelDelete = new MetroFramework.Controls.MetroLabel();
            this.labelEdit = new MetroFramework.Controls.MetroLabel();
            this.labelList = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.labelTransaction = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.ActiveControl = null;
            this.register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register.BackColor = System.Drawing.Color.White;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Location = new System.Drawing.Point(54, 141);
            this.register.Name = "register";
            this.register.PaintTileCount = false;
            this.register.Size = new System.Drawing.Size(91, 88);
            this.register.Style = MetroFramework.MetroColorStyle.Red;
            this.register.TabIndex = 0;
            this.register.Theme = MetroFramework.MetroThemeStyle.Light;
            this.register.TileImage = ((System.Drawing.Image)(resources.GetObject("register.TileImage")));
            this.register.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register.UseMnemonic = false;
            this.register.UseSelectable = true;
            this.register.UseTileImage = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            this.register.MouseClick += new System.Windows.Forms.MouseEventHandler(this.register_MouseClick);
            // 
            // edit
            // 
            this.edit.ActiveControl = null;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Location = new System.Drawing.Point(223, 141);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(91, 88);
            this.edit.Style = MetroFramework.MetroColorStyle.Yellow;
            this.edit.TabIndex = 0;
            this.edit.TileImage = ((System.Drawing.Image)(resources.GetObject("edit.TileImage")));
            this.edit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.UseSelectable = true;
            this.edit.UseTileImage = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // list
            // 
            this.list.ActiveControl = null;
            this.list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list.Location = new System.Drawing.Point(138, 270);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(91, 88);
            this.list.Style = MetroFramework.MetroColorStyle.Green;
            this.list.TabIndex = 0;
            this.list.TileImage = ((System.Drawing.Image)(resources.GetObject("list.TileImage")));
            this.list.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.list.UseSelectable = true;
            this.list.UseStyleColors = true;
            this.list.UseTileImage = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // delete
            // 
            this.delete.ActiveControl = null;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(394, 141);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(91, 88);
            this.delete.Style = MetroFramework.MetroColorStyle.Silver;
            this.delete.TabIndex = 0;
            this.delete.TileImage = ((System.Drawing.Image)(resources.GetObject("delete.TileImage")));
            this.delete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.UseSelectable = true;
            this.delete.UseStyleColors = true;
            this.delete.UseTileImage = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRegister.Location = new System.Drawing.Point(67, 119);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(64, 19);
            this.labelRegister.Style = MetroFramework.MetroColorStyle.White;
            this.labelRegister.TabIndex = 1;
            this.labelRegister.Text = "Register";
            this.labelRegister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelRegister.UseStyleColors = true;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelDelete.Location = new System.Drawing.Point(414, 119);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(52, 19);
            this.labelDelete.Style = MetroFramework.MetroColorStyle.White;
            this.labelDelete.TabIndex = 1;
            this.labelDelete.Text = "Delete";
            this.labelDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelDelete.UseStyleColors = true;
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelEdit.Location = new System.Drawing.Point(250, 119);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(34, 19);
            this.labelEdit.Style = MetroFramework.MetroColorStyle.White;
            this.labelEdit.TabIndex = 1;
            this.labelEdit.Text = "Edit";
            this.labelEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelEdit.UseStyleColors = true;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelList.Location = new System.Drawing.Point(168, 248);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(31, 19);
            this.labelList.Style = MetroFramework.MetroColorStyle.White;
            this.labelList.TabIndex = 1;
            this.labelList.Text = "List";
            this.labelList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelList.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(309, 270);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(91, 88);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelTransaction.Location = new System.Drawing.Point(312, 248);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(85, 19);
            this.labelTransaction.Style = MetroFramework.MetroColorStyle.White;
            this.labelTransaction.TabIndex = 1;
            this.labelTransaction.Text = "Transaction";
            this.labelTransaction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelTransaction.UseStyleColors = true;
            // 
            // menuHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelTransaction);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.register);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "menuHome";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Welcome";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile edit;
        private MetroFramework.Controls.MetroTile list;
        private MetroFramework.Controls.MetroTile delete;
        private MetroFramework.Controls.MetroLabel labelRegister;
        private MetroFramework.Controls.MetroLabel labelDelete;
        private MetroFramework.Controls.MetroLabel labelEdit;
        private MetroFramework.Controls.MetroLabel labelList;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel labelTransaction;
        private MetroFramework.Controls.MetroTile register;
    }
}

