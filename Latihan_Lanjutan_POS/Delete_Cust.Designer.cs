namespace Latihan_Lanjutan_POS
{
    partial class Delete_Cust
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
            this.idCust = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.deleteCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idCust
            // 
            this.idCust.Location = new System.Drawing.Point(117, 74);
            this.idCust.Name = "idCust";
            this.idCust.Size = new System.Drawing.Size(172, 20);
            this.idCust.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(101, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // deleteCust
            // 
            this.deleteCust.Location = new System.Drawing.Point(214, 100);
            this.deleteCust.Name = "deleteCust";
            this.deleteCust.Size = new System.Drawing.Size(75, 23);
            this.deleteCust.TabIndex = 7;
            this.deleteCust.Text = "Delete";
            this.deleteCust.UseVisualStyleBackColor = true;
            this.deleteCust.Click += new System.EventHandler(this.deleteCust_Click);
            // 
            // Delete_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 239);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.deleteCust);
            this.Controls.Add(this.idCust);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Name = "Delete_Cust";
            this.Text = "Delete Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_Cust_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idCust;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button deleteCust;
    }
}