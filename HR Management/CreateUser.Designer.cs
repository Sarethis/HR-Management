namespace HR_Management
{
    partial class CreateUserForm
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
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbLoginName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txbPasswordAgain = new System.Windows.Forms.TextBox();
            this.lbPasswordAgain = new System.Windows.Forms.Label();
            this.cmbAccountLevel = new System.Windows.Forms.ComboBox();
            this.lbAccountLvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(55, 100);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(225, 20);
            this.txbPassword.TabIndex = 13;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbLoginName
            // 
            this.txbLoginName.Location = new System.Drawing.Point(55, 55);
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.Size = new System.Drawing.Size(225, 20);
            this.txbLoginName.TabIndex = 12;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(135, 85);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "Password:";
            // 
            // lbLoginName
            // 
            this.lbLoginName.AutoSize = true;
            this.lbLoginName.Location = new System.Drawing.Point(145, 40);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(36, 13);
            this.lbLoginName.TabIndex = 10;
            this.lbLoginName.Text = "Login:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(170, 235);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(55, 235);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 35);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txbPasswordAgain
            // 
            this.txbPasswordAgain.Location = new System.Drawing.Point(55, 140);
            this.txbPasswordAgain.Name = "txbPasswordAgain";
            this.txbPasswordAgain.Size = new System.Drawing.Size(225, 20);
            this.txbPasswordAgain.TabIndex = 15;
            this.txbPasswordAgain.UseSystemPasswordChar = true;
            // 
            // lbPasswordAgain
            // 
            this.lbPasswordAgain.AutoSize = true;
            this.lbPasswordAgain.Location = new System.Drawing.Point(115, 125);
            this.lbPasswordAgain.Name = "lbPasswordAgain";
            this.lbPasswordAgain.Size = new System.Drawing.Size(93, 13);
            this.lbPasswordAgain.TabIndex = 14;
            this.lbPasswordAgain.Text = "Confirm password:";
            // 
            // cmbAccountLevel
            // 
            this.cmbAccountLevel.DropDownHeight = 105;
            this.cmbAccountLevel.DropDownWidth = 225;
            this.cmbAccountLevel.FormattingEnabled = true;
            this.cmbAccountLevel.IntegralHeight = false;
            this.cmbAccountLevel.Location = new System.Drawing.Point(55, 180);
            this.cmbAccountLevel.Name = "cmbAccountLevel";
            this.cmbAccountLevel.Size = new System.Drawing.Size(224, 21);
            this.cmbAccountLevel.TabIndex = 16;
            // 
            // lbAccountLvl
            // 
            this.lbAccountLvl.AutoSize = true;
            this.lbAccountLvl.Location = new System.Drawing.Point(125, 165);
            this.lbAccountLvl.Name = "lbAccountLvl";
            this.lbAccountLvl.Size = new System.Drawing.Size(75, 13);
            this.lbAccountLvl.TabIndex = 17;
            this.lbAccountLvl.Text = "Account level:";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.lbAccountLvl);
            this.Controls.Add(this.cmbAccountLevel);
            this.Controls.Add(this.txbPasswordAgain);
            this.Controls.Add(this.lbPasswordAgain);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbLoginName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbLoginName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLoginName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txbPasswordAgain;
        private System.Windows.Forms.Label lbPasswordAgain;
        private System.Windows.Forms.ComboBox cmbAccountLevel;
        private System.Windows.Forms.Label lbAccountLvl;
    }
}