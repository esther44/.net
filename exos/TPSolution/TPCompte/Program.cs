using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        static void Test2()
        {
            CompteSimple simple = new CompteSimple("esther", 100);
            CompteCB cb = new CompteCB("Bob", 200, CB.visa);
            CompteVIP vip = new CompteVIP("Charlie", 300);

            simple.Virement(50, cb);
            cb.Virement(100, vip);
            vip.Virement(250, simple);

            foreach(var compte in new CompteSimple[] { simple, cb, vip })
            {
                Console.WriteLine(compte);
            }
        }

        static void Test()
        {
            CompteSimple s1 = new CompteSimple("jacky", 1000);
            CompteSimple s2 = new CompteSimple("celine");

            s1.Virement(500, s2);
        }
    }
}
