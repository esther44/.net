﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetMVC1.Models
{
    public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;

        public int Id
        {
            get
            {
                return id;
            }
            set { id = value; }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set { age = value; }

        }

        public string Nom
        {
            get
            {
                return nom;
            }
            set { nom = value; }

        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
            set { prenom = value; }
        }

        public Personne(int id, string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.id = id;
        }
        public Personne() { }
        public override string ToString()
        {

            return id + "    " + nom + "    " + prenom + "    " + age;
        }
    }
}
