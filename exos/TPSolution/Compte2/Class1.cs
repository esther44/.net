using System;

namespace Model
{
    public class Compte2
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

        public Compte2(int numero, int solde, string banque)
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
