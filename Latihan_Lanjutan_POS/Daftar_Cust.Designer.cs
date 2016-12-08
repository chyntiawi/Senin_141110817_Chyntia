namespace Latihan_Lanjutan_POS
{
    partial class Daftar_Cust
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
            this.dataGridView_Cust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cust)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cust
            // 
            this.dataGridView_Cust.AllowUserToAddRows = false;
            this.dataGridView_Cust.AllowUserToDeleteRows = false;
            this.dataGridView_Cust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cust.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Cust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cust.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cust.Name = "dataGridView_Cust";
            this.dataGridView_Cust.Size = new System.Drawing.Size(682, 397);
            this.dataGridView_Cust.TabIndex = 0;
            // 
            // Daftar_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 397);
            this.Controls.Add(this.dataGridView_Cust);
            this.Name = "Daftar_Cust";
            this.Text = "Daftar Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Daftar_Cust_FormClosed);
            this.Load += new System.EventHandler(this.Daftar_Cust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cust;
    }
}