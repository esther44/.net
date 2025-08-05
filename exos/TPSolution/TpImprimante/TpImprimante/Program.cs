using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImprimante
{
    class Program
    {
        static void Main(string[] args)
        {
            Centraliseur cen = Centraliseur.GetCentraliseur();
            Poste p = new Poste();
            p.Print(cen);
            cen.MiseHS(0);
            p.Print(cen);
            cen.MiseHS(1);
            p.Print(cen);
        }
    }

    class Poste
    {
        public void Print(Centraliseur c)
        {
            c.Impression();
        }
        
    }

    public class Centraliseur
    {
        private Imprimante[] central = { new Imprimante(true), new Imprimante(true) };
        static Centraliseur instance;

        public static Centraliseur GetCentraliseur()
        {
            if (instance == null)
            {
                instance = new Centraliseur();
            }
            return instance;

        }

        public void Impression()
        {
            if(central[1].Operationnel)
            {
                central[1].print();
            }
            else if(central[0].Operationnel)
            {
                central[1] = null;
                central[0].print();
            }
            else
            {
                central[1] = null;
                central[0] = null;
                Console.WriteLine("Les imprimantes sont hs");
            }
        }

        public void MiseHS(int i)
        {
            central[i].Operationnel = false;
        }
    }

    class Imprimante
    {
        bool operationnel;

        public Imprimante(bool Operationnel)
        {
            this.operationnel = Operationnel;
        }

        public bool Operationnel
        {
            get { return operationnel; }
            set { this.operationnel = value; }
        }

        public void print()
        {
            Console.WriteLine("Coucou");
        }

    }
}
