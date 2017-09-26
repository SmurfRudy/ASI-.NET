﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSConvertisseur.Models
{
    public class Devise
    {
        public Devise()
        {
        }
        public Devise(int id, string deviseName, double taux)
        {
            this.id = id;
            this.deviseName = deviseName;
            this.taux = taux;
        }
        public int id { get; set; }
        public string deviseName { get; set; }
        public double taux { get; set; }
    }
}