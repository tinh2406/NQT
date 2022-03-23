namespace quanlisv
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbB_LopSH = new System.Windows.Forms.ComboBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.BT_Search = new System.Windows.Forms.Button();
            this.DGV_ThongTin = new System.Windows.Forms.DataGridView();
            this.BT_Show = new System.Windows.Forms.Button();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Del = new System.Windows.Forms.Button();
            this.BT_Sort = new System.Windows.Forms.Button();
            this.cbB_Sort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp SH";
            // 
            // cbB_LopSH
            // 
            this.cbB_LopSH.FormattingEnabled = true;
            this.cbB_LopSH.Location = new System.Drawing.Point(113, 37);
            this.cbB_LopSH.Name = "cbB_LopSH";
            this.cbB_LopSH.Size = new System.Drawing.Size(149, 21);
            this.cbB_LopSH.TabIndex = 1;
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(529, 41);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(100, 20);
            this.TB_Search.TabIndex = 2;
            // 
            // BT_Search
            // 
            this.BT_Search.Location = new System.Drawing.Point(647, 39);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(75, 23);
            this.BT_Search.TabIndex = 3;
            this.BT_Search.Text = "Search";
            this.BT_Search.UseVisualStyleBackColor = true;
            this.BT_Search.Click += new System.EventHandler(this.BT_Search_Click);
            // 
            // DGV_ThongTin
            // 
            this.DGV_ThongTin.AllowUserToAddRows = false;
            this.DGV_ThongTin.AllowUserToDeleteRows = false;
            this.DGV_ThongTin.AllowUserToOrderColumns = true;
            this.DGV_ThongTin.AllowUserToResizeColumns = false;
            this.DGV_ThongTin.AllowUserToResizeRows = false;
            this.DGV_ThongTin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ThongTin.Location = new System.Drawing.Point(24, 90);
            this.DGV_ThongTin.Name = "DGV_ThongTin";
            this.DGV_ThongTin.ReadOnly = true;
            this.DGV_ThongTin.RowHeadersVisible = false;
            this.DGV_ThongTin.Size = new System.Drawing.Size(748, 259);
            this.DGV_ThongTin.TabIndex = 4;
            // 
            // BT_Show
            // 
            this.BT_Show.Location = new System.Drawing.Point(90, 380);
            this.BT_Show.Name = "BT_Show";
            this.BT_Show.Size = new System.Drawing.Size(75, 23);
            this.BT_Show.TabIndex = 5;
            this.BT_Show.Text = "Show";
            this.BT_Show.UseVisualStyleBackColor = true;
            this.BT_Show.Click += new System.EventHandler(this.BT_Show_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(200, 380);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 23);
            this.BT_Add.TabIndex = 6;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(310, 380);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 7;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // BT_Del
            // 
            this.BT_Del.Location = new System.Drawing.Point(420, 380);
            this.BT_Del.Name = "BT_Del";
            this.BT_Del.Size = new System.Drawing.Size(75, 23);
            this.BT_Del.TabIndex = 8;
            this.BT_Del.Text = "Del";
            this.BT_Del.UseVisualStyleBackColor = true;
            this.BT_Del.Click += new System.EventHandler(this.BT_Del_Click);
            // 
            // BT_Sort
            // 
            this.BT_Sort.Location = new System.Drawing.Point(530, 380);
            this.BT_Sort.Name = "BT_Sort";
            this.BT_Sort.Size = new System.Drawing.Size(75, 23);
            this.BT_Sort.TabIndex = 9;
            this.BT_Sort.Text = "Sort";
            this.BT_Sort.UseVisualStyleBackColor = true;
            this.BT_Sort.Click += new System.EventHandler(this.BT_Sort_Click);
            // 
            // cbB_Sort
            // 
            this.cbB_Sort.FormattingEnabled = true;
            this.cbB_Sort.Items.AddRange(new object[] {
            "MSSV",
            "Name",
            "LopSH",
            "Ngaysinh",
            "DTB",
            "Gender",
            "Anh",
            "HocBa",
            "CMND"});
            this.cbB_Sort.Location = new System.Drawing.Point(640, 380);
            this.cbB_Sort.Name = "cbB_Sort";
            this.cbB_Sort.Size = new System.Drawing.Size(121, 21);
            this.cbB_Sort.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbB_Sort);
            this.Controls.Add(this.BT_Sort);
            this.Controls.Add(this.BT_Del);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.BT_Show);
            this.Controls.Add(this.DGV_ThongTin);
            this.Controls.Add(this.BT_Search);
            this.Controls.Add(this.TB_Search);
            this.Controls.Add(this.cbB_LopSH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbB_LopSH;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.DataGridView DGV_ThongTin;
        private System.Windows.Forms.Button BT_Show;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Del;
        private System.Windows.Forms.Button BT_Sort;
        private System.Windows.Forms.ComboBox cbB_Sort;
    }
}

