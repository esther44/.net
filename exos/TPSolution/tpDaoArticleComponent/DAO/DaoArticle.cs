using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpDaoArticleComponent.DAL;

namespace tpDaoArticleComponent.DAO
{
    class DaoArticle
    {
        public List<Article> SelectAll()
        {
            return new Db().SelectAll();
        }
    }
}
