using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_2
{
    class Program
    {
        static bool LaNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }

        static void Main()
        {
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay.", thang);
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay.", thang);
                    break;

                case 2:
                    if (LaNamNhuan(nam))
                    {
                        Console.WriteLine("Thang 2 co 29 ngay.");
                    }
                    else
                    {
                        Console.WriteLine("Thang 2 co 28 ngay.");
                    }
                    break;

                default:
                    Console.WriteLine("Loi: Thang phai tu 1 den 12.");
                    break;
            }
        }
    }
}
