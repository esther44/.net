using projetDaoPersonneComponent.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoPersonneComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            testSelectAll();
        }

        static void testSelectAll()
        {
            foreach (Personne p in new DaoPersonne().SelectAll())
                Console.WriteLine(p);
        }
    }
}
