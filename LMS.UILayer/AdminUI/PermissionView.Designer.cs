namespace LMS.UILayer.AdminUI
{
    partial class PermissionView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node8");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(718, 492);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Here";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(126, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 363);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Permission";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 29);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node9";
            treeNode1.Text = "Node9";
            treeNode2.Name = "Node10";
            treeNode2.Text = "Node10";
            treeNode3.Name = "Node11";
            treeNode3.Text = "Node11";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Node12";
            treeNode6.Text = "Node12";
            treeNode7.Name = "Node13";
            treeNode7.Text = "Node13";
            treeNode8.Name = "Node14";
            treeNode8.Text = "Node14";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Node2";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Node4";
            treeNode12.Name = "Node15";
            treeNode12.Text = "Node15";
            treeNode13.Name = "Node16";
            treeNode13.Text = "Node16";
            treeNode14.Name = "Node17";
            treeNode14.Text = "Node17";
            treeNode15.Name = "Node5";
            treeNode15.Text = "Node5";
            treeNode16.Name = "Node6";
            treeNode16.Text = "Node6";
            treeNode17.Name = "Node7";
            treeNode17.Text = "Node7";
            treeNode18.Name = "Node8";
            treeNode18.Text = "Node8";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(446, 460);
            this.treeView1.TabIndex = 2;
            // 
            // PermissionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PermissionView";
            this.Size = new System.Drawing.Size(718, 492);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;


    }
}
