namespace LMS.UILayer.AdminUI
{
    partial class HomeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalCategories = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAuthors = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalPublisher = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBooksInfo = new System.Windows.Forms.Label();
            this.lblTotalActiveMember = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalMember = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMembersInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblTotalCategories);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblTotalAuthors);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.lblTotalPublisher);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblTotalBook);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblBooksInfo);
            this.panel2.Controls.Add(this.lblTotalActiveMember);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTotalMember);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMembersInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 342);
            this.panel2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Authors:";
            // 
            // lblTotalCategories
            // 
            this.lblTotalCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalCategories.AutoSize = true;
            this.lblTotalCategories.Location = new System.Drawing.Point(637, 51);
            this.lblTotalCategories.Name = "lblTotalCategories";
            this.lblTotalCategories.Size = new System.Drawing.Size(36, 17);
            this.lblTotalCategories.TabIndex = 28;
            this.lblTotalCategories.Text = "0000";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total Categories:";
            // 
            // NumberOfBooks
            // 
            this.NumberOfBooks.HeaderText = "Number of Books";
            this.NumberOfBooks.Name = "NumberOfBooks";
            this.NumberOfBooks.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // lblTotalAuthors
            // 
            this.lblTotalAuthors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalAuthors.AutoSize = true;
            this.lblTotalAuthors.Location = new System.Drawing.Point(637, 85);
            this.lblTotalAuthors.Name = "lblTotalAuthors";
            this.lblTotalAuthors.Size = new System.Drawing.Size(36, 17);
            this.lblTotalAuthors.TabIndex = 30;
            this.lblTotalAuthors.Text = "0000";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.NumberOfBooks});
            this.dataGridView1.Location = new System.Drawing.Point(259, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(448, 196);
            this.dataGridView1.TabIndex = 26;
            // 
            // lblTotalPublisher
            // 
            this.lblTotalPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPublisher.AutoSize = true;
            this.lblTotalPublisher.Location = new System.Drawing.Point(407, 85);
            this.lblTotalPublisher.Name = "lblTotalPublisher";
            this.lblTotalPublisher.Size = new System.Drawing.Size(36, 17);
            this.lblTotalPublisher.TabIndex = 25;
            this.lblTotalPublisher.Text = "0000";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Publishers:";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Location = new System.Drawing.Point(407, 51);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(36, 17);
            this.lblTotalBook.TabIndex = 23;
            this.lblTotalBook.Text = "0000";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Books:";
            // 
            // lblBooksInfo
            // 
            this.lblBooksInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBooksInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksInfo.Location = new System.Drawing.Point(281, 8);
            this.lblBooksInfo.Name = "lblBooksInfo";
            this.lblBooksInfo.Size = new System.Drawing.Size(426, 30);
            this.lblBooksInfo.TabIndex = 21;
            this.lblBooksInfo.Text = "Books Info";
            this.lblBooksInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalActiveMember
            // 
            this.lblTotalActiveMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalActiveMember.AutoSize = true;
            this.lblTotalActiveMember.Location = new System.Drawing.Point(171, 85);
            this.lblTotalActiveMember.Name = "lblTotalActiveMember";
            this.lblTotalActiveMember.Size = new System.Drawing.Size(36, 17);
            this.lblTotalActiveMember.TabIndex = 20;
            this.lblTotalActiveMember.Text = "0000";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Active Members:";
            // 
            // lblTotalMember
            // 
            this.lblTotalMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMember.AutoSize = true;
            this.lblTotalMember.Location = new System.Drawing.Point(171, 51);
            this.lblTotalMember.Name = "lblTotalMember";
            this.lblTotalMember.Size = new System.Drawing.Size(36, 17);
            this.lblTotalMember.TabIndex = 18;
            this.lblTotalMember.Text = "0000";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Members:";
            // 
            // lblMembersInfo
            // 
            this.lblMembersInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMembersInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembersInfo.Location = new System.Drawing.Point(8, 8);
            this.lblMembersInfo.Name = "lblMembersInfo";
            this.lblMembersInfo.Size = new System.Drawing.Size(205, 30);
            this.lblMembersInfo.TabIndex = 16;
            this.lblMembersInfo.Text = "Members Info";
            this.lblMembersInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::LMS.UILayer.Properties.Resources.book1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 196);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(722, 342);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalCategories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalAuthors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfBooks;
        private System.Windows.Forms.Label lblTotalPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBooksInfo;
        private System.Windows.Forms.Label lblTotalActiveMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMembersInfo;
        private System.Windows.Forms.PictureBox pictureBox1;



    }
}
