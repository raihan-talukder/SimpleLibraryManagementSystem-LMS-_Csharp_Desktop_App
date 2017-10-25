namespace LMS.UILayer.Common_UI
{
    partial class LoginForm
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
            this.rootPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.btbSingIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rootPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rootPanel.Controls.Add(this.groupBox1);
            this.rootPanel.Controls.Add(this.label1);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Size = new System.Drawing.Size(784, 461);
            this.rootPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.lblPasswordError);
            this.groupBox1.Controls.Add(this.lblUsernameError);
            this.groupBox1.Controls.Add(this.btbSingIn);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(172, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Here";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(19, 21);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(407, 16);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Username is required!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(99, 126);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(309, 16);
            this.lblPasswordError.TabIndex = 9;
            this.lblPasswordError.Text = "Password is required!";
            this.lblPasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPasswordError.Visible = false;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(99, 77);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(309, 16);
            this.lblUsernameError.TabIndex = 8;
            this.lblUsernameError.Text = "Username is required!";
            this.lblUsernameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsernameError.Visible = false;
            // 
            // btbSingIn
            // 
            this.btbSingIn.Location = new System.Drawing.Point(264, 145);
            this.btbSingIn.Name = "btbSingIn";
            this.btbSingIn.Size = new System.Drawing.Size(144, 30);
            this.btbSingIn.TabIndex = 7;
            this.btbSingIn.Text = "Login";
            this.btbSingIn.UseVisualStyleBackColor = true;
            this.btbSingIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(99, 145);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(144, 30);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register New Account";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(414, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(99, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(309, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(414, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(99, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(309, 27);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System (LMS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.rootPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System (LMS)";
            this.rootPanel.ResumeLayout(false);
            this.rootPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rootPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btbSingIn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblError;
    }
}