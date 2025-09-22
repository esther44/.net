using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetException2
{
    class NumeratorException : ApplicationException
    {
        private string complement;

        public NumeratorException(string message, string complement) : base(message)
        {
            this.complement = complement;
        }
        public string Complement
        {
            get
            {
                return complement;
            }
        }

        public NumeratorException()
        {

        }
        public NumeratorException(string message) : base(message)
        {

        }

        public override string ToString()
        {
            return "cest ma tostring " + this.Message + "     " + this.complement;
        }
    }
}
