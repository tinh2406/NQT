namespace quanlisv
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_MSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbB_LopSH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DT_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_DTB = new System.Windows.Forms.TextBox();
            this.BT_OK = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Female = new System.Windows.Forms.RadioButton();
            this.RB_Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_CMND = new System.Windows.Forms.CheckBox();
            this.CB_HocBa = new System.Windows.Forms.CheckBox();
            this.CB_Anh = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // TB_MSSV
            // 
            this.TB_MSSV.Location = new System.Drawing.Point(130, 23);
            this.TB_MSSV.Name = "TB_MSSV";
            this.TB_MSSV.Size = new System.Drawing.Size(121, 20);
            this.TB_MSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(130, 53);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(121, 20);
            this.TB_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lớp SH";
            // 
            // cbB_LopSH
            // 
            this.cbB_LopSH.FormattingEnabled = true;
            this.cbB_LopSH.Location = new System.Drawing.Point(130, 83);
            this.cbB_LopSH.Name = "cbB_LopSH";
            this.cbB_LopSH.Size = new System.Drawing.Size(121, 21);
            this.cbB_LopSH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh";
            // 
            // DT_NgaySinh
            // 
            this.DT_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_NgaySinh.Location = new System.Drawing.Point(530, 23);
            this.DT_NgaySinh.Name = "DT_NgaySinh";
            this.DT_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.DT_NgaySinh.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DTB";
            // 
            // TB_DTB
            // 
            this.TB_DTB.Location = new System.Drawing.Point(530, 83);
            this.TB_DTB.Name = "TB_DTB";
            this.TB_DTB.Size = new System.Drawing.Size(200, 20);
            this.TB_DTB.TabIndex = 10;
            // 
            // BT_OK
            // 
            this.BT_OK.Location = new System.Drawing.Point(278, 381);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(75, 23);
            this.BT_OK.TabIndex = 12;
            this.BT_OK.Text = "OK";
            this.BT_OK.UseVisualStyleBackColor = true;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(452, 381);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancel.TabIndex = 13;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Female);
            this.groupBox1.Controls.Add(this.RB_Male);
            this.groupBox1.Location = new System.Drawing.Point(63, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // RB_Female
            // 
            this.RB_Female.AutoSize = true;
            this.RB_Female.Location = new System.Drawing.Point(113, 51);
            this.RB_Female.Name = "RB_Female";
            this.RB_Female.Size = new System.Drawing.Size(59, 17);
            this.RB_Female.TabIndex = 1;
            this.RB_Female.TabStop = true;
            this.RB_Female.Text = "Female";
            this.RB_Female.UseVisualStyleBackColor = true;
            // 
            // RB_Male
            // 
            this.RB_Male.AutoSize = true;
            this.RB_Male.Location = new System.Drawing.Point(27, 51);
            this.RB_Male.Name = "RB_Male";
            this.RB_Male.Size = new System.Drawing.Size(48, 17);
            this.RB_Male.TabIndex = 0;
            this.RB_Male.TabStop = true;
            this.RB_Male.Text = "Male";
            this.RB_Male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_CMND);
            this.groupBox2.Controls.Add(this.CB_HocBa);
            this.groupBox2.Controls.Add(this.CB_Anh);
            this.groupBox2.Location = new System.Drawing.Point(542, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hồ sơ nộp";
            // 
            // CB_CMND
            // 
            this.CB_CMND.AutoSize = true;
            this.CB_CMND.Location = new System.Drawing.Point(16, 67);
            this.CB_CMND.Name = "CB_CMND";
            this.CB_CMND.Size = new System.Drawing.Size(58, 17);
            this.CB_CMND.TabIndex = 17;
            this.CB_CMND.Text = "CMND";
            this.CB_CMND.UseVisualStyleBackColor = true;
            // 
            // CB_HocBa
            // 
            this.CB_HocBa.AutoSize = true;
            this.CB_HocBa.Location = new System.Drawing.Point(16, 44);
            this.CB_HocBa.Name = "CB_HocBa";
            this.CB_HocBa.Size = new System.Drawing.Size(61, 17);
            this.CB_HocBa.TabIndex = 16;
            this.CB_HocBa.Text = "Học bạ";
            this.CB_HocBa.UseVisualStyleBackColor = true;
            // 
            // CB_Anh
            // 
            this.CB_Anh.AutoSize = true;
            this.CB_Anh.Location = new System.Drawing.Point(16, 21);
            this.CB_Anh.Name = "CB_Anh";
            this.CB_Anh.Size = new System.Drawing.Size(45, 17);
            this.CB_Anh.TabIndex = 15;
            this.CB_Anh.Text = "Ảnh";
            this.CB_Anh.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.TB_DTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DT_NgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbB_LopSH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_MSSV);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_MSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbB_LopSH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_NgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_DTB;
        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Female;
        private System.Windows.Forms.RadioButton RB_Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CB_CMND;
        private System.Windows.Forms.CheckBox CB_HocBa;
        private System.Windows.Forms.CheckBox CB_Anh;
    }
}