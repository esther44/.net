using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Articles;

namespace WcfServiceArticle
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceArticle" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceArticle
    {
        [OperationContract]
        void Insert(Article article);

        [OperationContract]
        List<Article> SelectAll();

        [OperationContract]
        Article SelectByRef(int id);
    }
}
