using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommercial
{
    enum Pole
    {
        Auto,
        Banque,
        Assurance
    }

    class Client
    {
        public string Nom { get; set; }
        public int NbSalaries { get; set; }
        public Pole Pole { get; set; }

        public Client(string nom, int nbSalarie, Pole pole)
        {
            Nom = nom;
            NbSalaries = nbSalarie;
            Pole = pole;
        }

        public override string ToString()
        {
            return $"Client {Nom}, salariés {NbSalaries} (Pole: {Pole})";
        }
    }
}
