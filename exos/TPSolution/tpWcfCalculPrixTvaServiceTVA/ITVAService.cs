using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace tpWcfCalculPrixTvaServiceTVA
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ITVAService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ITVAService
    {
        [OperationContract]
        double CalculTVA(double prixTTC, TVAService.ETVA cat);
    }

    [DataContract]
        public enum ETVA
    {
        [EnumMember]
        Normal = 2000,   // 20.00 %
        [EnumMember]
        Restau = 1000,   // 10.00 %
        [EnumMember]
        Epicerie = 550,  // 5.50 %
        [EnumMember]
        Medoc = 210      // 2.10 %
    }
}
