using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClientV1
{
    public class Compte1
    {
        private string banque;
        private int numero;
        private int solde;

        public string Banque
        {
            get => banque;
            set => banque = value;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public int Solde
        {
            get => solde;
            set => solde = value;
        }

        public Compte1(int numero, int solde, string banque)
        {
            Numero = numero;
            Solde = solde;
            Banque = banque;
        }

        public override string ToString()
        {
            return $"N° {Numero}, Solde: {Solde}€, Banque: {Banque}";
        }
    }
}
