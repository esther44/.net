using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetObserver
{
    class Student
    {
        public string Nom { get; set; }
        public int Note { get; set; }
        public Professor Prof { get; set; }


        public Student(string name)
        {
            Nom = name;
        }

        public void Notify()
        {
            if(Prof != null)
            {
                Note = Prof.Score;
            }
        }

        public override string ToString()
        {
            return $"Elève nommé {Nom} a la note de {Note}";
        }
    }
}
