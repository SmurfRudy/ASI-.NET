using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSConvertisseur.Models
{
    public class Devise
    {
        public int id { get; set; }
        public String name { get; set; }
        public double taux { get; set; }

        public Devise()
        {
        }

        public Devise(int id, String name, double taux)
        {
            this.id = id;
            this.name = name;
            this.taux = taux;
        }
    }
}