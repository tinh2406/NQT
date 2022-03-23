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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin("");
            foreach(string i in ChucNang.Load_ComboBox_LopSH())
                cbB_LopSH.Items.Add(i);
        }

        private void BT_Show_Click(object sender, EventArgs e)
        {
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin(cbB_LopSH.Text);
            cbB_LopSH.Text = "";
        }

        private void BT_Search_Click(object sender, EventArgs e)
        {
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin_Search(TB_Search.Text);
            TB_Search.Text = "";
        }

        private void BT_Sort_Click(object sender, EventArgs e)
        {
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin_Sort(cbB_Sort.Text);
            cbB_Sort.Text = "";
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ok = new Form2.OK(ChucNang.Load_DGV_Thongtin_Add);
            form2.ShowDialog();
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin(cbB_LopSH.Text);
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.load(ChucNang.chuyen_SV(DGV_ThongTin.CurrentRow.Cells[0].Value.ToString()));
            form2.ok = new Form2.OK(ChucNang.Load_DGV_Thongtin_Update);
            form2.ShowDialog();
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin(cbB_LopSH.Text);
        }

        private void BT_Del_Click(object sender, EventArgs e)
        {
            DGV_ThongTin.DataSource = ChucNang.Load_DGV_Thongtin_Del(DGV_ThongTin.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
