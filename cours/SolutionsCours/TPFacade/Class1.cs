using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TPFacade
{

    public class ConnexionBD
    {
        public void Connecter()
        {
            // ecrire "Connexion à la base de données..."
            Console.WriteLine("Connexion à la base de données...");
        }
    }

    public class ValidateurClient
    {
        public bool Valider(string nom, string email)
        {

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool isValid = Regex.IsMatch(email, pattern);

            //ecrire Validation des données client..."
            //si nom et mail pas null alors true
            Console.WriteLine("Validation des données client :" + nom + " " + email);
            return isValid;

        }
    }

    public class ClientRepository
    {
        public void Ajouter(string nom, string email)
        {
            Console.WriteLine("Insertion du client dans la base :" + nom + " " + email);

            //ecrire "Insertion du client dans la base : {nom}, {email}"

        }
    }

    public class EmailService
    {
        public void EnvoyerConfirmation(string produit)
        {
            Console.WriteLine("E-mail de confirmation envoyé pour :" + produit);
            //ecrire "E-mail de confirmation envoyé pour : {produit}"
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine( "LOG : " + message);
            //ecrire "LOG : " + message);
        }
    }
}
