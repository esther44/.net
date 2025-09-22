using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetMVC1.Models
{
    public class DataInt
    {
        private int? str;
        public int? Str
        {
            get { return str; }
            set { str = value; }
        }
        public DataInt(int? str)
        {
            this.str = str;
        }
    }
}