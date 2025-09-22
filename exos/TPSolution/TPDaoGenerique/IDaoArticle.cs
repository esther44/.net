using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDaoGenerique
{
    interface IDaoArticle : IDao<Article, int>
    {
        // crud ++
        List<Article> FindByMarqueLike(string nom);
        List<Article> FindByPrixMinMax(int prixMin, int prixMax);
    }
}
