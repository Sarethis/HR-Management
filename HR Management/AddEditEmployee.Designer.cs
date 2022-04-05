namespace HR_Management
{
    partial class AddEditEmployee
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
            this.lbID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbFName = new System.Windows.Forms.TextBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.txbSName = new System.Windows.Forms.TextBox();
            this.lbSName = new System.Windows.Forms.Label();
            this.txbSalary = new System.Windows.Forms.TextBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtpEmploymentStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEmploymentEnd = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.ckbFireEmployee = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(30, 50);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(73, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Employee ID: ";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(150, 47);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(40, 20);
            this.txbID.TabIndex = 1;
            // 
            // txbFName
            // 
            this.txbFName.Location = new System.Drawing.Point(150, 87);
            this.txbFName.Name = "txbFName";
            this.txbFName.Size = new System.Drawing.Size(155, 20);
            this.txbFName.TabIndex = 3;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(30, 90);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(60, 13);
            this.lbFName.TabIndex = 2;
            this.lbFName.Text = "First Name:";
            // 
            // txbSName
            // 
            this.txbSName.Location = new System.Drawing.Point(150, 127);
            this.txbSName.Name = "txbSName";
            this.txbSName.Size = new System.Drawing.Size(155, 20);
            this.txbSName.TabIndex = 5;
            // 
            // lbSName
            // 
            this.lbSName.AutoSize = true;
            this.lbSName.Location = new System.Drawing.Point(30, 130);
            this.lbSName.Name = "lbSName";
            this.lbSName.Size = new System.Drawing.Size(55, 13);
            this.lbSName.TabIndex = 4;
            this.lbSName.Text = "Surname: ";
            // 
            // txbSalary
            // 
            this.txbSalary.Location = new System.Drawing.Point(150, 167);
            this.txbSalary.Name = "txbSalary";
            this.txbSalary.Size = new System.Drawing.Size(155, 20);
            this.txbSalary.TabIndex = 7;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(30, 210);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(47, 13);
            this.lbPosition.TabIndex = 6;
            this.lbPosition.Text = "Position:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(30, 170);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(39, 13);
            this.lbSalary.TabIndex = 8;
            this.lbSalary.Text = "Salary:";
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Location = new System.Drawing.Point(311, 170);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(36, 13);
            this.lbCurrency.TabIndex = 10;
            this.lbCurrency.Text = "[EUR]";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(150, 207);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(156, 21);
            this.cmbPosition.TabIndex = 11;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(30, 250);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(91, 13);
            this.lbStartDate.TabIndex = 12;
            this.lbStartDate.Text = "Start employment:";
            // 
            // dtpEmploymentStart
            // 
            this.dtpEmploymentStart.Location = new System.Drawing.Point(127, 247);
            this.dtpEmploymentStart.Name = "dtpEmploymentStart";
            this.dtpEmploymentStart.Size = new System.Drawing.Size(200, 20);
            this.dtpEmploymentStart.TabIndex = 13;
            // 
            // dtpEmploymentEnd
            // 
            this.dtpEmploymentEnd.Location = new System.Drawing.Point(127, 273);
            this.dtpEmploymentEnd.Name = "dtpEmploymentEnd";
            this.dtpEmploymentEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEmploymentEnd.TabIndex = 15;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(30, 276);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(88, 13);
            this.lbEndDate.TabIndex = 14;
            this.lbEndDate.Text = "End employment:";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(30, 315);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(59, 13);
            this.lbComments.TabIndex = 16;
            this.lbComments.Text = "Comments:";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(95, 315);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(327, 83);
            this.rtbComments.TabIndex = 17;
            this.rtbComments.Text = "";
            // 
            // ckbFireEmployee
            // 
            this.ckbFireEmployee.AutoSize = true;
            this.ckbFireEmployee.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckbFireEmployee.Location = new System.Drawing.Point(333, 252);
            this.ckbFireEmployee.Name = "ckbFireEmployee";
            this.ckbFireEmployee.Size = new System.Drawing.Size(95, 31);
            this.ckbFireEmployee.TabIndex = 18;
            this.ckbFireEmployee.Text = "Dissmis Employee";
            this.ckbFireEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ckbFireEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(127, 419);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(110, 30);
            this.btnAccept.TabIndex = 19;
            this.btnAccept.Text = "Confirm";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.ckbFireEmployee);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.dtpEmploymentEnd);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.dtpEmploymentStart);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.txbSalary);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.txbSName);
            this.Controls.Add(this.lbSName);
            this.Controls.Add(this.txbFName);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbID);
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "AddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbFName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.TextBox txbSName;
        private System.Windows.Forms.Label lbSName;
        private System.Windows.Forms.TextBox txbSalary;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpEmploymentStart;
        private System.Windows.Forms.DateTimePicker dtpEmploymentEnd;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.CheckBox ckbFireEmployee;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}