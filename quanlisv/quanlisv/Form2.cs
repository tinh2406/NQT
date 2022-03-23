using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlisv
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (string i in ChucNang.Load_ComboBox_LopSH())
                cbB_LopSH.Items.Add(i);
        }
        public delegate List<SV> OK(SV sV);
        public OK ok;
        public void load(SV sV)
        {
            TB_MSSV.Text = sV.MSSV;
            TB_Name.Text = sV.Name;
            cbB_LopSH.Text = sV.LopSH;
            RB_Male.Checked = sV.Gender;
            RB_Female.Checked =!sV.Gender;
            TB_DTB.Text = sV.DTB.ToString();
            DT_NgaySinh.Text = sV.Ngaysinh.ToString();
            CB_Anh.Checked = sV.Anh;
            CB_CMND.Checked = sV.CMND;
            CB_CMND.Checked = sV.HocBa;
        }
        
        private void BT_OK_Click(object sender, EventArgs e)
        {
            SV sV = new SV(TB_MSSV.Text,TB_Name.Text,cbB_LopSH.Text,DT_NgaySinh.Text,Convert.ToDouble(TB_DTB.Text),RB_Male.Checked,CB_Anh.Checked,CB_HocBa.Checked,CB_CMND.Checked);
            ok(sV);
            this.Dispose();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
