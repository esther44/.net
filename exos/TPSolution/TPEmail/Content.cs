using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmail
{
    class Content
    {

        string titre;
        string message;

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

        public Content(string titre, string message)
        {
            Titre = titre;
            Message = message;
        }
    }
}
