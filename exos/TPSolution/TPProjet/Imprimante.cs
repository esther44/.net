using System;

namespace TPProjet
{
    public class Imprimante
    {
        public string Num { get; set; }
        public bool Statut { get; set; }

        public Imprimante(string num, bool statut)
        {
            Num = num;
            Statut = statut;
        }

        public void Print(string message)
        {
            Console.WriteLine($"[Imprimante {Num}] Impression : {message}");
        }
    }
}
