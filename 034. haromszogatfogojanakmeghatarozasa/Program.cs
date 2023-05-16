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

/*Ez egy C# program, amely kiszámítja egy derékszögű háromszög átfogójának hosszát a megadott befogók alapján. A program bekéri a felhasználótól a háromszög egyik és másik befogójának hosszát, majd elvégzi a szükséges számításokat és kiírja az átfogó hosszát.
Íme, hogyan működik a program lépésről lépésre:
A program importálja a szükséges könyvtárakat.
A program létrehozza a Main függvényt, amely a program belépési pontja.
Deklarálja és inicializálja az a, b és c változókat a megfelelő típussal.
A program kiírja a konzolra az üzenetet, hogy adja meg a háromszög egyik befogójának hosszát.
Beolvassa a felhasználó által megadott értéket a Console.ReadLine metódussal, majd átalakítja double típusba a double.Parse metódus segítségével, és elmenti az a változóba.
A program kiírja a konzolra az üzenetet, hogy adja meg a háromszög másik befogójának hosszát.
Beolvassa a felhasználó által megadott értéket a Console.ReadLine metódussal, majd átalakítja double típusba a double.Parse metódus segítségével, és elmenti a b változóba.
Kiszámítja az átfogó hosszát a Pitagorasz-tétel alapján: c = Math.Sqrt(a * a + b * b).
Lehetőség szerint kerekíti az c változó értékét két tizedesjegyre a Math.Round metódussal.
Kiírja az eredményt a konzolra a Console.WriteLine metódussal.
A program várja, hogy a felhasználó nyomjon meg egy billentyűt a kilépéshez. Ezután a program kilép.*/
