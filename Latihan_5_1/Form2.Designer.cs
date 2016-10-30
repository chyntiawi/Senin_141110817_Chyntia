namespace Latihan_5_1
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tree = new System.Windows.Forms.TreeView();
            this.bgcolor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgcolor_panel = new System.Windows.Forms.Panel();
            this.savebutton = new System.Windows.Forms.Button();
            this.bgcolor_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Background Color";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Theme";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tree.Size = new System.Drawing.Size(143, 357);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            this.tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tree_MouseClick);
            // 
            // bgcolor
            // 
            this.bgcolor.FormattingEnabled = true;
            this.bgcolor.Location = new System.Drawing.Point(126, 37);
            this.bgcolor.Name = "bgcolor";
            this.bgcolor.Size = new System.Drawing.Size(121, 21);
            this.bgcolor.TabIndex = 1;
            this.bgcolor.SelectedIndexChanged += new System.EventHandler(this.bgcolor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Background Color :";
            // 
            // bgcolor_panel
            // 
            this.bgcolor_panel.Controls.Add(this.savebutton);
            this.bgcolor_panel.Controls.Add(this.label1);
            this.bgcolor_panel.Controls.Add(this.bgcolor);
            this.bgcolor_panel.Location = new System.Drawing.Point(141, 0);
            this.bgcolor_panel.Name = "bgcolor_panel";
            this.bgcolor_panel.Size = new System.Drawing.Size(319, 357);
            this.bgcolor_panel.TabIndex = 3;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(231, 322);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            this.savebutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.savebutton_MouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 357);
            this.Controls.Add(this.bgcolor_panel);
            this.Controls.Add(this.tree);
            this.Name = "Form2";
            this.Text = "Theme";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.bgcolor_panel.ResumeLayout(false);
            this.bgcolor_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ComboBox bgcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel bgcolor_panel;
        private System.Windows.Forms.Button savebutton;
    }
}