namespace FileIO_Employee
{
    partial class Form1
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
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.lbEid = new System.Windows.Forms.Label();
            this.lbEname = new System.Windows.Forms.Label();
            this.lbESalary = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(97, 337);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(161, 45);
            this.btWrite.TabIndex = 0;
            this.btWrite.Text = "Write";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(314, 337);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(161, 45);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbEid
            // 
            this.lbEid.AutoSize = true;
            this.lbEid.Location = new System.Drawing.Point(103, 83);
            this.lbEid.Name = "lbEid";
            this.lbEid.Size = new System.Drawing.Size(83, 16);
            this.lbEid.TabIndex = 2;
            this.lbEid.Text = "Employee Id";
            // 
            // lbEname
            // 
            this.lbEname.AutoSize = true;
            this.lbEname.Location = new System.Drawing.Point(103, 173);
            this.lbEname.Name = "lbEname";
            this.lbEname.Size = new System.Drawing.Size(109, 16);
            this.lbEname.TabIndex = 3;
            this.lbEname.Text = "Employee Name";
            // 
            // lbESalary
            // 
            this.lbESalary.AutoSize = true;
            this.lbESalary.Location = new System.Drawing.Point(103, 263);
            this.lbESalary.Name = "lbESalary";
            this.lbESalary.Size = new System.Drawing.Size(111, 16);
            this.lbESalary.TabIndex = 4;
            this.lbESalary.Text = "Employee Salary";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(314, 80);
            this.txId.Multiline = true;
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(162, 45);
            this.txId.TabIndex = 5;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(314, 156);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(162, 45);
            this.txName.TabIndex = 6;
            // 
            // txSalary
            // 
            this.txSalary.Location = new System.Drawing.Point(314, 234);
            this.txSalary.Multiline = true;
            this.txSalary.Name = "txSalary";
            this.txSalary.Size = new System.Drawing.Size(162, 45);
            this.txSalary.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.txSalary);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lbESalary);
            this.Controls.Add(this.lbEname);
            this.Controls.Add(this.lbEid);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btWrite);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbEid;
        private System.Windows.Forms.Label lbEname;
        private System.Windows.Forms.Label lbESalary;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txSalary;
    }
}

