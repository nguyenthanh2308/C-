using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VD_LTHDT
{
    class DSSV
    {
        private ArrayList ds;
        public DSSV()
        {
            ds = new ArrayList();
        }
        //Them sinh vien
        public void themSV(SV a)
        {
            if (!ds.Contains(a))
                ds.Add(a);
        }
        //Hien thi danh sach SV
        public void lietke()
        {
            foreach (SV a in ds)
                a.hienThi();
        }
        //Hien thi danh sach SV theo loai
        public void lietKe(string loai)
        {
            foreach (SV a in ds)
                if (a.loaiSV().Equals(loai))
                    a.hienThi();
        }
        //Hien thi danh sach SV duoc tot nghiep
        public void lietKeTN()
        {
            foreach (SV a in ds)
                if (a.duocTN())
                    a.hienThi();
        }
    }
}
