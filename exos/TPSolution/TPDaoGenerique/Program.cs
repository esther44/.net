using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDaoGenerique
{
    class Program
    {
        static IDaoArticle dao = new DaoArticleSQLServer();

        static void Main(string[] args)
        {
            TestDelete();
        }

        static void TestCreate()
        {
            Article a = new Article(10, "Puma", 150);
            dao.Create(a);
            Console.WriteLine("Article inséré : " + a);
        }

        static void TestFindAll()
        {
            foreach (var article in dao.FindAll())
            {
                Console.WriteLine(article);
            }
        }

        static void TestFindById()
        {
            Article found = dao.FindById(10);
            Console.WriteLine(found != null ? found.ToString() : "Article non trouvé");
        }

        static void TestUpdate()
        {
            Article a1 = dao.FindById(10);
            if (a1 != null)
            {
                a1.Marque = "Puma Updated";
                a1.Prix = 175;
                dao.Update(a1);
                Console.WriteLine("Article après modification : " + dao.FindById(10));
            }
            else
            {
                Console.WriteLine("Article introuvable");
            }
        }

        static void TestFindByMarqueLike()
        {
            foreach (var article in dao.FindByMarqueLike("ni"))
            {
                Console.WriteLine(article);
            }
        }

        static void TestFindByPrixMinMax()
        {
            foreach (var article in dao.FindByPrixMinMax(100, 200))
            {
                Console.WriteLine(article);
            }
        }

        static void TestDelete()
        {
            dao.Delete(10);

            foreach (var article in dao.FindAll())
            {
                Console.WriteLine(article);
            }

        }
    }
}
