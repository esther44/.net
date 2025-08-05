using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetObserver
{
    class Professor
    {
        public string Nom { get; set; }
        int score;
        public int Score {
            get => score;
            set {
                score = value;
                NotifyAll();
            }
        }
           
        List<Student> eleves = new List<Student>(10);

        public Professor(string nom)
        {
            Nom = nom;
        }

        public void Attach(Student s)
        {
            eleves.Add(s);
        }

        void NotifyAll()
        {
            foreach(Student eleve in eleves){
                eleve.Notify();
            }
        }
    }
}
