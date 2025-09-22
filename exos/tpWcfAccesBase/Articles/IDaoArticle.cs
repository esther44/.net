using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    interface IDaoArticle : IDao<Article, int>
    {
        Article FindByRef(int reference);
        void Insert(Article article);
    }
}
