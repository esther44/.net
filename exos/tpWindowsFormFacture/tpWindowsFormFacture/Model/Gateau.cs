using System;

namespace tpWindowsFormFacture.Model
{
    public enum EGateau
    {
        Choco = 15, 
        Vanille = 20,
        Fraise = 30
    }



    class Gateau:Article
    {
       public EGateau Saveur { get; set; }

        public Gateau(string marque, EGateau saveur) : base(marque)
        {
            Saveur = saveur;
        }


        public override double Prix => (int)Saveur / 10; 

        public override string ToString()
        {
            return $"Gateau {Marque}: {Prix}Eur, saveur : {Saveur}";
        }
    }
}
