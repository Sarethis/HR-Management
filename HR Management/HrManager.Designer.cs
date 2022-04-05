namespace HR_Management
{
    partial class HrManagerForm
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
            this.btnAddEmploye = new System.Windows.Forms.Button();
            this.btnEditEmploye = new System.Windows.Forms.Button();
            this.btnFireEmploye = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbEmployePosition = new System.Windows.Forms.ComboBox();
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbAccountLevel = new System.Windows.Forms.Label();
            this.txbAccountLevel = new System.Windows.Forms.TextBox();
            this.txbLoggedUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmploye
            // 
            this.btnAddEmploye.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddEmploye.Location = new System.Drawing.Point(12, 12);
            this.btnAddEmploye.Name = "btnAddEmploye";
            this.btnAddEmploye.Size = new System.Drawing.Size(120, 40);
            this.btnAddEmploye.TabIndex = 0;
            this.btnAddEmploye.Text = "Add Employe";
            this.btnAddEmploye.UseVisualStyleBackColor = false;
            this.btnAddEmploye.Click += new System.EventHandler(this.btnAddEmploye_Click);
            // 
            // btnEditEmploye
            // 
            this.btnEditEmploye.BackColor = System.Drawing.Color.Khaki;
            this.btnEditEmploye.Location = new System.Drawing.Point(138, 12);
            this.btnEditEmploye.Name = "btnEditEmploye";
            this.btnEditEmploye.Size = new System.Drawing.Size(120, 40);
            this.btnEditEmploye.TabIndex = 1;
            this.btnEditEmploye.Text = "Edit Employe";
            this.btnEditEmploye.UseVisualStyleBackColor = false;
            this.btnEditEmploye.Click += new System.EventHandler(this.btnEditEmploye_Click);
            // 
            // btnFireEmploye
            // 
            this.btnFireEmploye.BackColor = System.Drawing.Color.Tomato;
            this.btnFireEmploye.Location = new System.Drawing.Point(264, 12);
            this.btnFireEmploye.Name = "btnFireEmploye";
            this.btnFireEmploye.Size = new System.Drawing.Size(120, 40);
            this.btnFireEmploye.TabIndex = 2;
            this.btnFireEmploye.Text = "Fire Employe";
            this.btnFireEmploye.UseVisualStyleBackColor = false;
            this.btnFireEmploye.Click += new System.EventHandler(this.btnFireEmploye_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.Location = new System.Drawing.Point(1252, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbEmployePosition
            // 
            this.cmbEmployePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmployePosition.FormattingEnabled = true;
            this.cmbEmployePosition.Location = new System.Drawing.Point(1096, 31);
            this.cmbEmployePosition.Name = "cmbEmployePosition";
            this.cmbEmployePosition.Size = new System.Drawing.Size(150, 21);
            this.cmbEmployePosition.TabIndex = 4;
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployes.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployes.Location = new System.Drawing.Point(12, 58);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployes.Size = new System.Drawing.Size(1360, 641);
            this.dgvEmployes.TabIndex = 5;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(1129, 15);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(86, 13);
            this.lbPosition.TabIndex = 6;
            this.lbPosition.Text = "Chosen Position:";
            // 
            // lbAccountLevel
            // 
            this.lbAccountLevel.AutoSize = true;
            this.lbAccountLevel.Location = new System.Drawing.Point(494, 15);
            this.lbAccountLevel.Name = "lbAccountLevel";
            this.lbAccountLevel.Size = new System.Drawing.Size(111, 13);
            this.lbAccountLevel.TabIndex = 7;
            this.lbAccountLevel.Text = "Current account level:";
            // 
            // txbAccountLevel
            // 
            this.txbAccountLevel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbAccountLevel.Location = new System.Drawing.Point(494, 31);
            this.txbAccountLevel.Name = "txbAccountLevel";
            this.txbAccountLevel.ReadOnly = true;
            this.txbAccountLevel.Size = new System.Drawing.Size(110, 20);
            this.txbAccountLevel.TabIndex = 8;
            this.txbAccountLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLoggedUser
            // 
            this.txbLoggedUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbLoggedUser.Location = new System.Drawing.Point(390, 31);
            this.txbLoggedUser.Name = "txbLoggedUser";
            this.txbLoggedUser.ReadOnly = true;
            this.txbLoggedUser.Size = new System.Drawing.Size(98, 20);
            this.txbLoggedUser.TabIndex = 10;
            this.txbLoggedUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(390, 15);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(98, 13);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "Current loged User:";
            // 
            // HrManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.txbLoggedUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txbAccountLevel);
            this.Controls.Add(this.lbAccountLevel);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.dgvEmployes);
            this.Controls.Add(this.cmbEmployePosition);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFireEmploye);
            this.Controls.Add(this.btnEditEmploye);
            this.Controls.Add(this.btnAddEmploye);
            this.Name = "HrManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HrManagerForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmploye;
        private System.Windows.Forms.Button btnEditEmploye;
        private System.Windows.Forms.Button btnFireEmploye;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbEmployePosition;
        private System.Windows.Forms.DataGridView dgvEmployes;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbAccountLevel;
        private System.Windows.Forms.TextBox txbAccountLevel;
        private System.Windows.Forms.TextBox txbLoggedUser;
        private System.Windows.Forms.Label lbUser;
    }
}