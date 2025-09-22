using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class OperateurException: ApplicationException
    {
        public string OperarteurFautif { get; set; }

        public OperateurException( string op):base(op)
        {
            OperarteurFautif = op;
        }

        public override string ToString()
        {
            return "Opérateur invalide : "+ this.OperarteurFautif;
        }
    }
}
