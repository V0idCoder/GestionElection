using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionLibrary
{
    public class Candidat
    {
        public int CandidatId { get; set; }
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateOnly DateNaissance { get; set; }
        public string Profession { get; set; }
        public int ListeId { get; set; }
    }
}
