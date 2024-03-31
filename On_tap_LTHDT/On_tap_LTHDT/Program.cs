using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_tap_LTHDT
{
    class Program
    {

        static void Main(string[] args)
        {
            DSNLD ds = new DSNLD();
            string tieptuc = "C";
            nguoilaodong a;
            do
            {
                int chon = 0;
                Console.WriteLine("ban nhap nguoi lao dong hay nguoi nghi huu (0,1): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        a = new nguoinghihuu();
                        a.nhap();
                        ds.themnguoilaodong(a);
                        break;
                    case 1:
                        a = new noilamviec();
                        a.nhap();
                        ds.themnguoilaodong(a);
                        break;
                }
                Console.WriteLine("Ban co muon nhap tiep khong?");
                tieptuc = Console.ReadLine();
            } while (tieptuc.Equals("C"));
            ds.lietke();
            Console.ReadKey();
        }
    }
}
