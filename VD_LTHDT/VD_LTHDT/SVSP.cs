using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_LTHDT
{
    class SVSP:SV
    {
        private string noiTT;
        private float diemTT;
        public SVSP():base()
        {
            this.noiTT = "";
            this.diemTT = 0.0f;
        }
        public SVSP (string ht, int ns, float dtb, string noitt, float diemtt):base (ht,ns, dtb)
        {
            this.noiTT = noitt;
            this.diemTT = diemtt;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap noi thuc tap: ");
            this.noiTT = Console.ReadLine();
            Console.WriteLine("Nhap diem thuc tap: ");
            this.diemTT = float.Parse(Console.ReadLine());
        }
        public override void hienThi()
        {
            base.hienThi();
            Console.WriteLine("Noi thuc tap:{0}", this.noiTT);
            Console.WriteLine("Diem thuc tap: {0}", this.diemTT);
        }
        public override string loaiSV()
        {
            return "SP";
        }
        public override bool duocTN()
        {
            return DTB >= 5 && diemTT >= 5;
        }
    }
}
