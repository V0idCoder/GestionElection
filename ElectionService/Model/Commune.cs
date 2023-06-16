﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionService.Model
{
    public class Commune
    {
        public int CommuneId { get; set; }
        public  string Nom { get; set; }
        public int Npa { get; set; }
        public int Numero { get; set; }
        public string Canton { get; set; }

        // Navigation Properties
        public List<Election> Elections { get; set; }
    }
}
