using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Articles;

namespace WcfServiceArticle
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceArticle" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceArticle.svc ou ServiceArticle.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceArticle : IServiceArticle
    {
        private DaoArticleSqlServer dao = new DaoArticleSqlServer();
        public void Insert(Article article)
        {
            dao.Insert(article);
        }

        public List<Article> SelectAll()
        {
            return dao.SelectAll();
        }

        public Article SelectByRef(int id)
        {
            return dao.FindByRef(id);
        }
    }
}
