using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicePersonne.Model;

namespace WcfServicePersonne
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Personne GetPersonne()
        {
            return new Personne("aa", "bb", 10);
        }

        public Personne Update(Personne p)
        {
            p.Age++;
            return p;
        }

        public Personne GetPersonneParam(string nom, string prenom, int age)
        {
            return new Personne(nom, prenom, age);
        }

        public List<Personne> GetListPersonne()
        {
            List<Personne> liste = new List<Personne>();

            liste.Add(new Personne("aa", "bb", 10));
            liste.Add(new Personne("cc", "dd", 10));
            liste.Add(new Personne("ee", "ff", 10));

            return liste;
        }
    }
}
