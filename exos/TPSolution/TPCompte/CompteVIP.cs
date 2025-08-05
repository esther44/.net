using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    class CompteVIP:CompteSimple
    {
        public CompteVIP(string titulaire, int solde):base(titulaire, solde)
        {

        }

        protected override int Commission => 0;
        protected override bool EstDecouvertAutorise => true;

        public override string ToString()
        {
            return $"[Compte VIP] Titulaire : {Titulaire}, Solde : {Solde}";
        }
    }
}
