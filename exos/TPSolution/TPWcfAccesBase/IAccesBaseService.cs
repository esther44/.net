using System.Collections.Generic;
using System.ServiceModel;
using TPWcfAccesBase.Models; // ArticleDto

namespace TPWcfAccesBase
{
    [ServiceContract]
    public interface IAccesBaseService
    {
        [OperationContract]
        ArticleDto SelectById(int id);

        [OperationContract]
        List<ArticleDto> SelectAll();

        [OperationContract]
        void Insert(ArticleDto dto);
    }
}
