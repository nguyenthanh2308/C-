using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_LTHDT
{
    abstract class SV
    {
        private string hoten;
        private int namsinh;
        private float dTB;

        protected string Hoten { get => hoten; set => hoten = value; }
        protected int Namsinh { get => namsinh; set => namsinh = value; }
        protected float DTB { get => dTB; set => dTB = value; }

        public SV()
        {
            this.Hoten = " ";
            this.Namsinh = 2000;
            this.DTB = 0.0f;
        }
        public SV(string ht, int ns, float dtb)
        {
            this.Hoten = ht;
            this.Namsinh = ns;
            this.DTB = dtb;
        }
       public virtual void nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            this.hoten = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            this.namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem TB: ");
            this.dTB = float.Parse(Console.ReadLine());
        }

        // Phương thức hiển thị 
        public virtual void hienThi()
        {
            Console.WriteLine($"Ho ten: {this.Hoten}");

            Console.WriteLine($"Nam sinh: {this.Namsinh}");

            Console.WriteLine($"Diem TB: {this.DTB}");
        }
        //Xet loai SV
        abstract public string loaiSV();

        //Xet tot nghiep
        abstract public bool duocTN();
    }

}
