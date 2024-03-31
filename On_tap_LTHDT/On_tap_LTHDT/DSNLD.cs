using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace On_tap_LTHDT
{
    class DSNLD
    {
        private ArrayList ds;
        public DSNLD()
        {
            ds = new ArrayList();
        }
        //them nguoi lao dong
        public void themnguoilaodong(nguoilaodong A)
        {
            if (!ds.Contains(A))
                ds.Add(A);
        }
        //hien thi danh sach
        public void lietke()
        {
            foreach (nguoilaodong A in ds)
                A.hienthi();
        }
    }
}
