using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace projetWcfServiceCalcul
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public double Calcule(string op, double a, double b)
        {
            switch (op)
            {
                case "+": return Sum(a, b);
                case "-": return Difference(a, b);
                case "*": return Product(a, b);
                case "/": return Division(a, b);
                default: return 0;
            }
        }

        private double Sum(double a, double b) { return a + b; }
        private double Difference(double a, double b) { return a - b; }
        private double Product(double a, double b) { return a * b; }
        private double Division(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroException x = new DivideByZeroException("anomalie technique attention denom a zero");
                throw x;
            }


            return a / b;

        }
    }
}
