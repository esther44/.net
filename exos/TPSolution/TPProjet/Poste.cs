namespace TPProjet
{
    public class Poste
    {
        public string Nom { get; }

        public Poste(string nom)
        {
            Nom = nom;
        }

        public void AjouterImprimante(string num, bool statut)
        {
            Centraliseur.Instance.AjouterImprimante(num, statut);
        }

        public void MettreImprimanteHorsService(string num)
        {
            Centraliseur.Instance.MettreImprimanteHorsService(num);
        }

        public void Print(string message)
        {
            Centraliseur.Instance.PrintDepuisPoste(Nom, message);
        }
    }
}
