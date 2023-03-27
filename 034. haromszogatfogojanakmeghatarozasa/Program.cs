using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034.haromszogatfogojanakmeghatarozasa
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Add meg a háromszög egyik befogójának értékét! ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög másik befogójának értékét! ");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(a * a + b * b);

            c = Math.Round(c, 2);

            Console.WriteLine("Az átfogó hossza:{0}", c);

            Console.ReadKey();

        }
    }
}
