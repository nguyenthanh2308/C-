using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_tap_LTHDT
{
    class nguoinghihuu:nguoilaodong
    {
        private int tuoilaodong;
        private double luonghuu;
        public nguoinghihuu(): base()
        {
            this.tuoilaodong = 50;
            this.luonghuu = 1500000;
        }
        public nguoinghihuu(int tld, double lh)
        {
            this.tuoilaodong = tld;
            this.luonghuu = lh;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap tuoi lao dong: ");
            this.tuoilaodong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap luong huu: ");
            this.luonghuu = double.Parse(Console.ReadLine());
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Tuoi lao dong: {0}", this.tuoilaodong);
            Console.WriteLine("Luong huu: {0}", this.luonghuu);
        }
      
    }
}
