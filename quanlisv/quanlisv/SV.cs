using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlisv
{
    public class SV
    {
        public SV()
        {

        }

        public SV(string mSSV, string name, string lopSH, string ngaysinh, double dTB, bool gender, bool anh, bool hocBa, bool cMND)
        {
            MSSV = mSSV;
            Name = name;
            LopSH = lopSH;
            Ngaysinh = ngaysinh;
            DTB = dTB;
            Gender = gender;
            Anh = anh;
            HocBa = hocBa;
            CMND = cMND;
        }

        public string MSSV { get; set; }
        public string Name { get; set; } 
        public string LopSH { get; set; }
        public string Ngaysinh { get; set; }
        public double DTB { get; set; }
        public bool Gender { get; set; }
        public bool Anh { get; set; }
        public bool HocBa { get; set; }
        public bool CMND { get; set; }
    }
    
}
