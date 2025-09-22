using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpWindowsFormFacture.Model
{
    class Facture
    {
        string Client { get; set; }
        List<Ligne> lignes = new List<Ligne>();
        double PrixTotal { get; set; }

        public Facture(string nom)
        {
            Client = nom;
        }

        public override string ToString()
        {
            string res = $"Facture client: {Client}";
            foreach (var ligne in lignes)
                res += ligne + "\n";
            return $"{res} {PrixTotal}";
        }

        public void Ajouter(Ligne ligne)
        {
            PrixTotal += ligne.PrixLigne;
            lignes.Add(ligne);
        }

   
    }
}
