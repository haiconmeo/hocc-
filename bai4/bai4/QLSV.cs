using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class QLSV
    {
        List<SV> listSV;
        public QLSV()
        {
            this.listSV = new List<SV>();
            SV sv1 = new SV
            {
                MSSV = "1",
                Name = "mamh",
                Address = "na",
                Birthday = DateTime.Now,
                Sex = true
            };
            SV sv2 = new SV
            {
                MSSV = "2",
                Name = "mamh",
                Address = "na",
                Birthday = DateTime.Now,
                Sex = true
            };
            SV sv3 = new SV
            {
                MSSV = "3",
                Name = "mamh",
                Address = "na",
                Birthday = DateTime.Now,
                Sex = true
            };
            SV sv4 = new SV
            {
                MSSV = "4",
                Name = "mamh",
                Address = "na",
                Birthday = DateTime.Now,
                Sex = true
            };
            this.listSV.Add(sv1);
            this.listSV.Add(sv2);
            this.listSV.Add(sv3);
            this.listSV.Add(sv4);

      
        }
       
  
    }
}
