using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFacade
{
    class Facade
    {

        private Logger logger;
        private ClientRepository clientRepository;
        private ValidateurClient validateurClient;
        private EmailService emailService;
        private ConnexionBD connexionBD;

        public bool IsValid{
            get;
            set;
            }

        public Facade()
        {
            logger = new Logger();
            clientRepository = new ClientRepository();
            validateurClient = new ValidateurClient();
            emailService = new EmailService();
            connexionBD = new ConnexionBD();
        }

        public void AjouterClient(string nom, string email)
        {
            connexionBD.Connecter();
            bool isValid = validateurClient.Valider(nom, email);

            if (isValid)
            {
                clientRepository.Ajouter(nom, email);
                logger.Log($"Client ajouté : {nom}, {email}");
            }
            else
            {
                logger.Log($"Échec validation client : {nom}, {email}");
            }
        }

        public void PasserCommande(string produit)
        {
            logger.Log(produit);
            emailService.EnvoyerConfirmation(produit);
        }
    }
}
