using System;
using System.Collections.Generic;
using System.Linq;
using tpWcfAccesBase_ArticlesDll;
using TPWcfAccesBase.Models;  

namespace TPWcfAccesBase
{
    public class AccesBaseService : IAccesBaseService
    {
        private readonly DaoArticles _dao = new DaoArticles();

        public ArticleDto SelectById(int id)
        {
            var article = _dao.SelectByRef(id);
            if (article == null) return null;

            return new ArticleDto
            {
                Ref = article.Reference,
                Marque = article.Marque,
                Prix = article.Prix
            };
        }

        public List<ArticleDto> SelectAll()
        {
            return _dao.SelectAll()
                       .Select(a => new ArticleDto
                       {
                           Ref = a.Reference,
                           Marque = a.Marque,
                           Prix = a.Prix
                       })
                       .ToList();
        }

        public void Insert(ArticleDto dto)
        {
            var article = new Article(dto.Ref, dto.Marque, dto.Prix);
            _dao.Insert(article);
        }
    }
}
