using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Articles;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInsert();
        }

        static void TestSelectAll()
        {
            ServiceArticleClient svc = new ServiceArticleClient();

            List<Article> articles = svc.SelectAll();

            foreach (Article a in articles)
            {
                Console.WriteLine(a.Marque + " " + a.Price);
            }
        }

        static void TestSelectByRef()
        {
            ServiceArticleClient svc = new ServiceArticleClient();

            int id = 45;

            Article article = svc.SelectByRef(id);

            Console.WriteLine(article.Id + "   " + article.Marque + "    " + article.Price);
        }

        static void TestInsert()
        {
            ServiceArticleClient svc = new ServiceArticleClient();

            Article article = new Article();

            article.Id = 99;
            article.Marque = "Marque";
            article.Price = 999;

            svc.Insert(article);
        }
    }
}
