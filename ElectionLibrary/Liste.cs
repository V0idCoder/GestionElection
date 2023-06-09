using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionLibrary
{
    public class Liste
    {
        public int ListeId { get; set; }
        public int Numero { get; set; }
        public string? Nom { get; set; }
        public string? Abreviation { get; set; }
        public int NbBulletinCompact { get; set; }

        public List<Bulletin> Bulletins {get; set; } 

        public List<Candidat> Candidats { get; set;}
    }
}
