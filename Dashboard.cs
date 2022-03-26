﻿using QuanLyQuanCafe.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public delegate void Login_show();
    public partial class Dashboard : Form
    {
        public Login_show login_show;
       
        public Dashboard()
        {
            InitializeComponent();
            BT_Refresh_Click_NhanVien(new object(),new EventArgs());
            BT_refresh_DanhMuc_Click(new object(),new EventArgs());
        }

        /// <summary>
        /// Nhân viên
        /// </summary>
        void load_cbb_chucvu()
        {
            cbB_ChucVuNV.Items.Clear();
            cbB_ChucVu.Items.Clear();
            cbB_ChucVuNV.Items.Add("Tất cả");
            foreach (DataRow i in DataNhanVienDAL.data_Chucvu().Rows)
            {
                cbB_ChucVu.Items.Add(i[0].ToString());
                cbB_ChucVuNV.Items.Add(i[0].ToString());
            }
        }    
        public void btLogOut_Click(object sender, EventArgs e)
        {
            login_show();
            this.Close();
        }
        private void TB_TimNhanVien_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            foreach (DataRow i in DataNhanVienDAL.data().Rows)
                if ((i[1].ToString().ToUpper()).Contains(TB_TimNhanVien.Text.ToUpper()))
                    nhanViens.Add(new NhanVien(i));
            DGV_NhanVien.DataSource = nhanViens;                    
        }
        private void cbB_ChucVuNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            foreach (DataRow i in DataNhanVienDAL.data().Rows)
                if ((i[3].ToString().ToUpper() == cbB_ChucVuNV.Text.ToUpper()))
                    nhanViens.Add(new NhanVien(i));
            DGV_NhanVien.DataSource = nhanViens;
        }
        private void BT_Refresh_Click_NhanVien(object sender, EventArgs e)
        {
            DGV_NhanVien.DataSource = DataNhanVienDAL.data();
            load_cbb_chucvu();
            TB_TimNhanVien.Text = "";
        }
        private void DGV_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_IDNV.Text = DGV_NhanVien.CurrentRow.Cells[0].Value.ToString().Trim();
            TB_TenNV.Text = DGV_NhanVien.CurrentRow.Cells[1].Value.ToString().Trim();
            DT_NSNV.Text = DGV_NhanVien.CurrentRow.Cells[2].Value.ToString().Trim();
            TB_ChucVu.Text = DGV_NhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            TB_UserName.Text = DGV_NhanVien.CurrentRow.Cells[4].Value.ToString().Trim();
            TB_PassWord.Text = DGV_NhanVien.CurrentRow.Cells[5].Value.ToString().Trim();
            TB_emailNV.Text = DGV_NhanVien.CurrentRow.Cells[6].Value.ToString().Trim();
        }
        private void BT_Them1_Click(object sender, EventArgs e)
        {
            int dem= 0;
            foreach (DataRow i in DataNhanVienDAL.data().Rows)
                if (i[0].ToString() == TB_IDNV.Text)
                    dem++;
            if(dem== 0)
                    DGV_NhanVien.DataSource = DataNhanVienDAL.capnhatNV(new NhanVien(TB_IDNV.Text.ToString().ToUpper(),TB_TenNV.Text,DT_NSNV.Text,
                                                                  TB_ChucVu.Text,TB_UserName.Text,TB_PassWord.Text, "0" ,TB_emailNV.Text),1);
            BT_Refresh_Click_NhanVien(new object(), new EventArgs());
        }
        private void BT_Xoa1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataNhanVienDAL.data().Rows.Count; i++)
                if (DataNhanVienDAL.data().Rows[i][0].ToString().ToUpper().Trim() == TB_IDNV.Text)
                    DGV_NhanVien.DataSource = DataNhanVienDAL.capnhatNV(new NhanVien(DataNhanVienDAL.data().Rows[i]),2);
            BT_Refresh_Click_NhanVien(new object(), new EventArgs());
        }
        private void BT_Sua1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataNhanVienDAL.data().Rows.Count; i++)
                if (DataNhanVienDAL.data().Rows[i][0].ToString().ToUpper().Trim() == TB_IDNV.Text)
                    DGV_NhanVien.DataSource = DataNhanVienDAL.capnhatNV(new NhanVien(TB_IDNV.Text.ToString().ToUpper(), TB_TenNV.Text, DT_NSNV.Text,
                                                                  TB_ChucVu.Text, TB_UserName.Text, TB_PassWord.Text, "0", TB_emailNV.Text),3);
            BT_Refresh_Click_NhanVien(new object(), new EventArgs());
        }
        private void cbB_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_ChucVu.Text = cbB_ChucVu.Text.Trim();
        }


        ///
        //// Món
        ///
        void load_cbb_danhmuc()
        {
            CBB_DanhMuc.Items.Clear();
            CBB_ChonDanhMuc.Items.Clear();
            foreach(DataRow i in DataDanhMucDAL.data().Rows)
            {
                CBB_ChonDanhMuc.Items.Add(i[1].ToString().Trim());
                CBB_DanhMuc.Items.Add(i[1].ToString().Trim());
            }    
        }
        private void TB_TimDM_TextChanged(object sender, EventArgs e)
        {
            List<DanhMuc> danhMucs = new List<DanhMuc>();
            foreach (DataRow i in DataDanhMucDAL.data().Rows)
                if ((i[1].ToString().ToUpper()).Contains(TB_TimDM.Text.ToUpper()))
                    danhMucs.Add(new DanhMuc(i));
            DGV_DanhMuc.DataSource = danhMucs;
        }
        private void BT_refresh_DanhMuc_Click(object sender, EventArgs e)
        {
            DGV_DanhMuc.DataSource = DataDanhMucDAL.data();
            load_cbb_danhmuc();
            TB_TimDM.Text = "";
            TB_ID_DM.Text = "";
            TB_NhapDanhMuc.Text = "";
        }
        private void DGV_DanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_ID_DM.Text = DGV_DanhMuc.CurrentRow.Cells[0].Value.ToString().Trim();
            TB_NhapDanhMuc.Text = DGV_DanhMuc.CurrentRow.Cells[1].Value.ToString().Trim();
        }
        private void BT_Them3_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (DataRow i in DataDanhMucDAL.data().Rows)
                if (i[0].ToString() == TB_ID_DM.Text)
                    dem++;
            if (dem == 0)
                DGV_DanhMuc.DataSource = DataDanhMucDAL.capnhatDM(new DanhMuc(TB_ID_DM.Text.ToString().ToUpper().Trim(), TB_NhapDanhMuc.Text.ToString().Trim()),1);
            BT_refresh_DanhMuc_Click(new object(), new EventArgs());
        }
        private void BT_Xoa3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataDanhMucDAL.data().Rows.Count; i++)
                if (DataDanhMucDAL.data().Rows[i][0].ToString().ToUpper().Trim() == TB_ID_DM.Text)
                    DGV_DanhMuc.DataSource = DataDanhMucDAL.capnhatDM(new DanhMuc(DataDanhMucDAL.data().Rows[i]), 2);
            BT_refresh_DanhMuc_Click(new object(), new EventArgs());
        }
        private void BT_Sua3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DataDanhMucDAL.data().Rows.Count; i++)
                if (DataDanhMucDAL.data().Rows[i][0].ToString().ToUpper().Trim() == TB_ID_DM.Text.ToString().ToUpper())
                DGV_DanhMuc.DataSource = DataDanhMucDAL.capnhatDM(new DanhMuc(TB_ID_DM.Text.ToString().ToUpper().Trim(), TB_NhapDanhMuc.Text.ToString().Trim()), 3);
            BT_refresh_DanhMuc_Click(new object(), new EventArgs());
        }
    }
}
