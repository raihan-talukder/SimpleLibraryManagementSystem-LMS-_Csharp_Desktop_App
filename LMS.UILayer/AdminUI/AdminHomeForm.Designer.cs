namespace LMS.UILayer.AdminUI
{
    partial class AdminHomeForm
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMembersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.rentedBooksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = global::LMS.UILayer.Properties.Resources.if_Streamline_18_185038__1_;
            this.homeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMembersListToolStripMenuItem,
            this.addNewMemberToolStripMenuItem,
            this.editMemberToolStripMenuItem,
            this.deleteMemberToolStripMenuItem});
            this.membersToolStripMenuItem.Image = global::LMS.UILayer.Properties.Resources.if_jee_100_2180872__1_;
            this.membersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // allMembersListToolStripMenuItem
            // 
            this.allMembersListToolStripMenuItem.Name = "allMembersListToolStripMenuItem";
            this.allMembersListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.allMembersListToolStripMenuItem.Text = "All Members List";
            this.allMembersListToolStripMenuItem.Click += new System.EventHandler(this.allMembersListToolStripMenuItem_Click);
            // 
            // addNewMemberToolStripMenuItem
            // 
            this.addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            this.addNewMemberToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewMemberToolStripMenuItem.Text = "Add New Member";
            // 
            // editMemberToolStripMenuItem
            // 
            this.editMemberToolStripMenuItem.Name = "editMemberToolStripMenuItem";
            this.editMemberToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editMemberToolStripMenuItem.Text = "Edit Member";
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Image = global::LMS.UILayer.Properties.Resources.if_15_2388602__1_;
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(75, 36);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // rentedBooksToolStripMenuItem
            // 
            this.rentedBooksToolStripMenuItem.Name = "rentedBooksToolStripMenuItem";
            this.rentedBooksToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.rentedBooksToolStripMenuItem.Text = "Rented Books";
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 490);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMembersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentedBooksToolStripMenuItem;
    }
}