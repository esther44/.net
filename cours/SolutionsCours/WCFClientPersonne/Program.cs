using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClientPersonne.NSServicePersonne;

namespace WCFClientPersonne
{
    class Program
    {
        static void Main(string[] args)
        {
            TestUpdatePersonne();
        }

        static void TestGetPersonneParam()
        {
            Service1Client svc = new Service1Client();
            Personne p = svc.GetPersonneParam("AA", "BB", 18);

            Console.WriteLine(p.Nom + "  " + p.Prenom + "  " + p.Age);



        }

        static void TestGetPersonne()
        {
            Service1Client svc = new Service1Client();
            Personne p = svc.GetPersonne();

            Console.WriteLine(p.Nom+ " " + p.Prenom+ " " + p.Age);
            Console.WriteLine(p.ToString());
        }



        static void TestUpdatePersonne()
        {
            Service1Client svc = new Service1Client();
            Personne p = new Personne();
            p.Nom = "AA"; p.Prenom = "BB"; p.Age = 18;
            Personne pUpdate = svc.Update(p);
            Console.WriteLine(pUpdate.Nom + "  " + pUpdate.Prenom + "  " + pUpdate.Age);
        }

        static void TestGetListPersonne()
        {
            Service1Client svc = new Service1Client();
            Personne p = new Personne();

            List<Personne> tab = svc.GetListPersonne();

            foreach (Personne personne in tab)
                Console.WriteLine(personne.Nom + "   " + personne.Prenom + "   " + personne.Age);


        }
    }
}
