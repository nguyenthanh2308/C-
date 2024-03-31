using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_tap_LTHDT
{
   abstract class nguoilaodong
    {
        private string Hoten;
        private int namsinh;

        protected string hoten { get => Hoten; set => Hoten = value; }
        protected int Namsinh { get => namsinh; set => namsinh = value; }
        public nguoilaodong()
        {
            this.Hoten = " ";
            this.namsinh = 1980;

        }
           
        public nguoilaodong( string ht, int ns, int tld)
        {
            this.Hoten = ht;
            this.namsinh = ns;
        }
      public virtual void nhap ()
        {
            Console.WriteLine("Nhap ho ten: ");
            this.Hoten = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            this.namsinh = int.Parse(Console.ReadLine());
        }
        public virtual void hienthi()
        {
            Console.WriteLine($"Ho ten: {this.Hoten}");
            Console.WriteLine($"Nam sinh: {this.namsinh}");
        }
    }
}
