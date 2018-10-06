using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datagridview
{
    class quanlysinhvien
    {
        List<SinhVien> dssv;
        List<string> dc;
        public quanlysinhvien(){
            dssv = new List<SinhVien>();
            SinhVien sv1 = new SinhVien
            {
                mssv = "1",
                name = "manh",
                ngaysinh = DateTime.Now,
                diachi = "ha noi"
            };
            SinhVien sv2 = new SinhVien
            {
                mssv = "2",
                name = "dung",
                ngaysinh = DateTime.Now,
                diachi = "nghe an"
            };
            SinhVien sv3 = new SinhVien
            {
                mssv = "3",
                name = "hung",
                ngaysinh = DateTime.Now,
                diachi = "nghe an"
            };
            SinhVien sv4 = new SinhVien
            {
                mssv = "4",
                name = "lai",
                ngaysinh = DateTime.Now,
                diachi = "da nang"
            };
      
            dssv.Add(sv1);
            dssv.Add(sv2);
            dssv.Add(sv3);
            dssv.Add(sv4);
            dc = new List<string>();
            foreach (SinhVien i in dssv)
            {
                if (!dc.Contains(i.diachi))
                {
                    dc.Add(i.diachi);
                }
                
            }
            //dssv.Add(sv5);




        }
        public List<SinhVien> _dssv
        {
            get
            {
                return dssv;
            }
           
        }
        public List<string> _dc
        {
            get
            {
                return dc;
            }
        }
        
       
        public SinhVien sems(string a)
        {
            foreach (SinhVien i in dssv)
            {
                if (i.mssv == a)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
