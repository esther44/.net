using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDaoArticles
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelete();
        }

        static void TestDelete()
        {
            new DaoArticle().Delete(24);
        }

        static void TestUpdate()
        {
            new DaoArticle().Update(new Article(24, "AA", 11));
        }

        static void TestInsert()
        {
            new DaoArticle().Insert(new Article(24, "aa", 10));
        }

        static void TestSelectById()
        {
            Article a = new DaoArticle().SelectById(1);

            Console.WriteLine(a);
        }

        static void TestSelectAll()
        {
            //   List<Personne> x = new DaoPersonne().SelectAll();
            foreach (Article a in new DaoArticle().SelectAll())
                Console.WriteLine(a);
        }
    }

}
