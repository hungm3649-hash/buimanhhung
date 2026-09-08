using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Câu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.Write("Nhap ban kinh r: ");
            double r = double.Parse(Console.ReadLine());
            double chuVi = 2 * PI * r;
            double dienTich = PI * r * r;
            Console.WriteLine("Chu vi hinh tron: {0:F2}", chuVi);
            Console.WriteLine("Dien tich hinh tron: {0:F2}");
        }
    }
}
