using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_LTHDT
{
    class SVTH:SV
    {
        private string tenDT;
        private float diemDT;
        public SVTH() : base()
        {
            this.tenDT = "";
            this.diemDT = 0.0f;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap ten de tai: ");
            this.tenDT = Console.ReadLine();
            Console.WriteLine("Nhap diem de tai: ");
            this.diemDT = float.Parse(Console.ReadLine());
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("Ten de tai: {0}", this.tenDT);
            Console.WriteLine("Diem de tai: {0}", this.diemDT);
        }
        public override string loaiSV()
        {
            return "TH";
        }
        public override bool duocTN()
        {
            return DTB >= 5 && diemDT >= 7;
        }
    }
}
