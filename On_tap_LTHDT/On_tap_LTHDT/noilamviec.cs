using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_tap_LTHDT
{
    class noilamviec:nguoilaodong
    {
        private string Noilamviec;
        private string Vitrilamviec;
        public noilamviec(): base()
        {
            this.Noilamviec = "";
            this.Vitrilamviec = "";
        }
        public noilamviec(string ht, int ns, int tld, string noilamviec, string vitrilamviec):base (ht, ns, tld)
        {
            this.Noilamviec = noilamviec;
            this.Vitrilamviec = vitrilamviec;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhap noi lam viec: ");
            this.Noilamviec = Console.ReadLine();
            Console.WriteLine("Nhap vi tri lam viec: ");
            this.Vitrilamviec = Console.ReadLine();
                
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Noi lam viec: {0}",this.Noilamviec);
            Console.WriteLine("Vi tri lam viec: {0}", this.Vitrilamviec);
        }

    }
}
