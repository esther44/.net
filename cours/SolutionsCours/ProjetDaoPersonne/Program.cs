using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDaoPersonne
{
    class Program
    {
        static void Main(string[] args)
        {
            TestUpdate();
        }

        static void TestDelete()
        {
            new DaoPersonne().Delete(24);
        }

        static void TestUpdate()
        {
            new DaoPersonne().Update(new Personne(24, "AA", "BB", 11));
        }

        static void TestInsert()
        {
            new DaoPersonne().Insert(new Personne(24, "aa", "bb", 10));
        }

        static void TestSelectById()
        {
            Personne p = new DaoPersonne().SelectById(1);
            Console.WriteLine(p);
        }

        static void TestSelectAll()
        {
            //   List<Personne> x = new DaoPersonne().SelectAll();
            foreach (Personne p in new DaoPersonne().SelectAll())
                Console.WriteLine(p);
        }
    }
}
