using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlisv
{
    public class DLSV
    {
        SV[] sv = new SV[]
        {
            new SV("1022001","Nguyen Van A","20T1","01/01/2002",8.0,true,true,true,true),
            new SV("1022002","Nguyen Van B","20T2","05/01/2002",8.5,true,true,false,true),
            new SV("1022003","Nguyen Van C","20T1","08/01/2002",8.3,true,true,true,false),
            new SV("1022004","Nguyen Van D","20T2","09/01/2002",8.7,true,true,true,true),
            new SV("1022005","Nguyen Van E","20T1","14/01/2002",8.3,true,false,true,true),
            new SV("1022006","Nguyen Van F","20T2","20/01/2002",8.4,false,true,false,true),
            new SV("1022007","Nguyen Van G","20T1","04/01/2002",8.6,true,true,true,true),
            new SV("1022008","Nguyen Van H","20T2","07/01/2002",8.8,true,true,false,true),
            new SV("1022009","Nguyen Van I","20T1","06/01/2002",8.9,true,false,true,true),
            new SV("1022010","Nguyen Van J","20T2","29/01/2002",8.7,true,true,true,true),
            new SV("1022011","Nguyen Van K","20T1","08/01/2002",8.5,true,false,true,false),
            new SV("1022012","Nguyen Van L","20T1","24/01/2002",8.4,true,true,true,true),
            new SV("1022013","Nguyen Van M","20T1","27/01/2002",8.5,false,true,true,false),
            new SV("1022014","Nguyen Van N","20T1","18/01/2002",8.6,true,true,true,true),
            new SV("1022015","Nguyen Van P","20T2","23/01/2002",8.7,false,true,true,true),
            new SV("1022016","Nguyen Van Q","20T1","11/01/2002",8.8,true,true,true,true),
            new SV("1022017","Nguyen Van R","20T2","22/01/2002",8.9,false,true,false,true),
            new SV("1022018","Nguyen Van S","20T1","19/01/2002",8.3,true,true,true,true)

        };
        public List<SV> data =  new List<SV>();
        public DLSV()
        {
            data.Add(sv[0]);
            data.Add(sv[1]);
            data.Add(sv[2]);
            data.Add(sv[3]);
            data.Add(sv[4]);
            data.Add(sv[5]);
            data.Add(sv[6]);
            data.Add(sv[7]);
            data.Add(sv[8]);
            data.Add(sv[9]);
            data.Add(sv[10]);
            data.Add(sv[11]);
            data.Add(sv[12]);
            data.Add(sv[13]);
            data.Add(sv[14]);
            data.Add(sv[15]);
            data.Add(sv[16]);
            data.Add(sv[17]);
        }


    }
}
