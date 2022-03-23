using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlisv
{
    public class ChucNang
    {
        public ChucNang() { }
        private static DLSV Data = new DLSV();
        
        public static List<SV> Load_DGV_Thongtin(string str)
        {
            List<SV> sVs = new List<SV>();
            if (str.Trim() != "")
            {
                for (int i = 0; i < Data.data.Count(); i++)
                    if (Data.data[i].LopSH == str)
                        sVs.Add(Data.data[i]);
            }
            else
                foreach (SV sv in Data.data)
                {
                    sVs.Add((SV)sv);
                }
            return sVs;
        }
        public static List<SV> Load_DGV_Thongtin_Search(string str)
        {
            List<SV> sVs = new List<SV>();
            if (str.Trim() != "")
            {
                foreach (SV i in Data.data)
                    if ((i.MSSV +i.Name + i.LopSH + i.DTB.ToString() + i.Ngaysinh).ToUpper().Contains(str.ToUpper()))
                        sVs.Add(i);
            }
            return sVs;
        }
        public static List<string> Load_ComboBox_LopSH()
        {
            List<string> list = new List<string>();
            foreach(SV sv in Data.data)
            {
                if (list.Contains(sv.LopSH)) ;
                else list.Add(sv.LopSH);
            }    
            return list;
        }    
        public static List<SV> Load_DGV_Thongtin_Sort(string str)
        {
            List<SV> sVs = new List<SV>();
            foreach (SV sv in Data.data)
            {
                sVs.Add((SV)sv);
            }
            List<SV> svs;
            switch (str)
            {
                case "MSSV":
                    svs = sVs.OrderBy(sV => sV.MSSV).ToList();
                    return svs;
                    break;
                case "Name":
                    svs = sVs.OrderBy(sV => sV.Name).ToList();
                    return svs;
                    break;
                case "LopSH":
                    svs = sVs.OrderBy(sV => sV.LopSH).ToList();
                    return svs;
                    break;
                case "Ngaysinh":
                    svs = sVs.OrderBy(sV => sV.Ngaysinh).ToList();
                    return svs;
                    break;
                case "DTB":
                    svs = sVs.OrderBy(sV => sV.DTB).ToList();
                    return svs;
                    break;
                case "Gender":
                    svs = sVs.OrderBy(sV => sV.Gender).ToList();
                    return svs;
                    break;
                case "Anh":
                    svs = sVs.OrderBy(sV => sV.Anh).ToList();
                    return svs;
                    break;
                case "HocBa":
                    svs = sVs.OrderBy(sV => sV.HocBa).ToList();
                    return svs;
                    break;
                case "CMND":
                    svs = sVs.OrderBy(sV => sV.CMND).ToList();
                    return svs;
                    break;
                default:break;
            }
            return sVs;
        }
        public static List<SV> Load_DGV_Thongtin_Del(string str)
        {
            List<SV> sVs = new List<SV>();
            for(int i=0;i<Data.data.Count();i++)
                if(Data.data[i].MSSV == str)
                    Data.data.RemoveAt(i);
            foreach(SV i in Data.data)
                sVs.Add(i);
            return sVs;
        }
        public static SV chuyen_SV(string str)
        {
            SV sV = new SV();
            for (int i = 0; i < Data.data.Count(); i++)
                if (Data.data[i].MSSV == str)
                    sV = Data.data[i];
            return sV;
                    
        }
        public static List<SV> Load_DGV_Thongtin_Update(SV sV)
        {
            List<SV> sVs = new List<SV>();
            for (int i = 0; i < Data.data.Count(); i++)
                if (Data.data[i].MSSV == sV.MSSV)
                    Data.data[i] = sV;
            foreach (SV i in Data.data)
                sVs.Add(i);
            return sVs;
        }
        public static List<SV> Load_DGV_Thongtin_Add(SV sV)
        {
            List<SV> sVs = new List<SV>();
            foreach (SV i in Data.data)
                sVs.Add(i);
            for (int i = 0; i < Data.data.Count(); i++)
                    if (Data.data[i].MSSV == sV.MSSV)
                        return sVs;
            Data.data.Add(sV);
            sVs.Clear();
            foreach (SV i in Data.data)
                sVs.Add(i);
            return sVs;

        }

    }
}
