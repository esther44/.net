using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpDaoArticleComponent.DAO;

namespace tpDaoArticleComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            testSelectAll();
        }

        static void testSelectAll()
        {
            foreach (Article a in new DaoArticle().SelectAll())
                Console.WriteLine(a);
        }
    }
}
