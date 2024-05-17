namespace Hospital
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labSalary = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.labSex = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.labDOB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateWork = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Moul Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(212, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "បញ្ជីរាយនាមពេទ្យ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(495, 94);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(54, 31);
            this.labName.TabIndex = 2;
            this.labName.Text = "ឈ្មោះ";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(566, 99);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(156, 22);
            this.textName.TabIndex = 3;
            // 
            // labSalary
            // 
            this.labSalary.AutoSize = true;
            this.labSalary.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSalary.Location = new System.Drawing.Point(495, 150);
            this.labSalary.Name = "labSalary";
            this.labSalary.Size = new System.Drawing.Size(65, 31);
            this.labSalary.TabIndex = 2;
            this.labSalary.Text = "ប្រាក់ខែ";
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(566, 155);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(156, 22);
            this.textSalary.TabIndex = 3;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhone.Location = new System.Drawing.Point(495, 195);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(94, 31);
            this.labPhone.TabIndex = 2;
            this.labPhone.Text = "លេខទូរស័ព្ទ";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(595, 200);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(156, 22);
            this.textPhone.TabIndex = 3;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(601, 257);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 24);
            this.cbSex.TabIndex = 4;
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSex.Location = new System.Drawing.Point(495, 257);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(43, 31);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "ភេទ";
            // 
            // dateDOB
            // 
            this.dateDOB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateDOB.Location = new System.Drawing.Point(601, 324);
            this.dateDOB.MaxDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(200, 22);
            this.dateDOB.TabIndex = 5;
            // 
            // labDOB
            // 
            this.labDOB.AutoSize = true;
            this.labDOB.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDOB.Location = new System.Drawing.Point(478, 321);
            this.labDOB.Name = "labDOB";
            this.labDOB.Size = new System.Drawing.Size(117, 31);
            this.labDOB.TabIndex = 2;
            this.labDOB.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "ថ្ងៃខែឆ្នាំចូលបំរើការងារ";
            // 
            // dateWork
            // 
            this.dateWork.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateWork.Location = new System.Drawing.Point(632, 369);
            this.dateWork.MaxDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            this.dateWork.Name = "dateWork";
            this.dateWork.Size = new System.Drawing.Size(200, 22);
            this.dateWork.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.dateWork);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labDOB);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.labSalary);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labSalary;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.Label labDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateWork;
    }
}

