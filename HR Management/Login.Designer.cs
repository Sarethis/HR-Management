namespace HR_Management
{
    partial class LoginWindowForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbLoginName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(55, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(170, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Location = new System.Drawing.Point(55, 240);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(225, 35);
            this.btnCreateNewUser.TabIndex = 2;
            this.btnCreateNewUser.Text = "Create new User";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // lbLoginName
            // 
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Location = new System.Drawing.Point(145, 40);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(36, 13);
            this.lbLoginName.TabIndex = 3;
            this.lbLoginName.Text = "Login:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(135, 85);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // txbLoginName
            // 
            this.txbLoginName.Location = new System.Drawing.Point(55, 55);
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.Size = new System.Drawing.Size(225, 20);
            this.txbLoginName.TabIndex = 5;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(55, 100);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(225, 20);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.Enter += new System.EventHandler(this.txbPassword_Enter);
            // 
            // LoginWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbLoginName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.btnCreateNewUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "LoginWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Manager : Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Label lbLoginName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbLoginName;
        private System.Windows.Forms.TextBox txbPassword;
    }
}

