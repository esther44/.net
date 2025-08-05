using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpEqualsArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }

        static void Test2()
        {
            Article[] articles = new Article[]
          {
                new Article("NIKE", 30),
                new Article("Zara", 15),
                new Article("ZARA", 20),
                new Article("h&m", 10),
                new Article("Nike", 30),
                new Article("H&M", 12)
          };


            Console.WriteLine("avant tri:");
            foreach (var a in articles)
                Console.WriteLine(a);

            Array.Sort(articles);
            Console.WriteLine("après tri:");
            foreach (var a in articles)
                Console.WriteLine(a);
        }
        static void Test()
        {
            Article a1 = new Article("NIKE", 30);
            Article a2 = new Article("Zara", 15);
     

            if (a1.Equals(a2))
                Console.WriteLine("ok equals");
            else
                Console.WriteLine("NOT  equals");
        }
    }
}
