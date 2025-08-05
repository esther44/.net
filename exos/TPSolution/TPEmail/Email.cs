using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmail
{

    class Email
    {
        private string destinataire;
        private string expediteur;
        private string titre;
        private string message;
        private File file;


        public File File
        {
            get => file;
            set => file = value;
        }

        public string Destinataire
        {
            get => destinataire;
            set => destinataire = value;
        }

        public string Expediteur
        {
            get => destinataire;
            set => destinataire = value;
        }

        public string Titre
        {
            get => titre;
            set => titre = value;
        }

        public string Message
        {
            get => message;
            set => message = value;
        }

        private Content content;

        public Email(File file, string dest, string exp, string message, string titre)
        {
            File = file;
            Destinataire = dest;
            Expediteur = exp;
            Titre = titre;
            Message = message;
            content = new Content(titre, message);
        }

        public  override string ToString()
        {
            return $"fichier" + file.Nom + " " + file.Taille + "\n Infos" + Destinataire + " " + Expediteur + "\n Contenu" + content.Titre + " " + content.Message;
        }
    }
}
