using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace TPWcfAccesBase.Models
{
    [DataContract]
    public class ArticleDto
    {
        [DataMember]
        public int Ref { get; set; }
        [DataMember]
        public string Marque { get; set; }
        [DataMember]
        public int Prix { get; set; }
    }
}
