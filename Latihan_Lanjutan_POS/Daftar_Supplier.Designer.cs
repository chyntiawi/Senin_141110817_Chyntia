namespace Latihan_Lanjutan_POS
{
    partial class Daftar_Supplier
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
            this.dataGridView_Supplier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Supplier
            // 
            this.dataGridView_Supplier.AllowUserToAddRows = false;
            this.dataGridView_Supplier.AllowUserToDeleteRows = false;
            this.dataGridView_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Supplier.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Supplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Supplier.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Supplier.Name = "dataGridView_Supplier";
            this.dataGridView_Supplier.Size = new System.Drawing.Size(682, 400);
            this.dataGridView_Supplier.TabIndex = 1;
            // 
            // Daftar_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 398);
            this.Controls.Add(this.dataGridView_Supplier);
            this.Name = "Daftar_Supplier";
            this.Text = "Daftar Supplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Daftar_Supplier_FormClosed);
            this.Load += new System.EventHandler(this.Daftar_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Supplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Supplier;
    }
}