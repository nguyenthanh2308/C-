using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_LTHDT
{
    class Program
    {
        static void Main(string[] args)
        {
            DSSV ds = new DSSV();
            string tieptuc = "C";
            SV a;
            do
            {
                int chon = 0;
                Console.WriteLine("Ban nhap SVSP hay SVTH (0,1):");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        a = new SVSP();
                        a.nhap();
                        ds.themSV(a);
                        break;
                    case 1:
                        a = new SVTH();
                        a.nhap();
                        ds.themSV(a);
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
  