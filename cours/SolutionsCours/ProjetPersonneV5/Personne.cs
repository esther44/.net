﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPersonneV5
{
   public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;

        public int Id
        {
            get { return id; }
        }

        public Personne(int id, string nom, string prenom, int age)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;

        }

        public override string ToString()
        {
            return id + "   " + nom + "   " + prenom + "   " + age;
        }
    }
}
