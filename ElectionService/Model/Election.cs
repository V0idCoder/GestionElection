using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionService.Model

{
    public class Election
    {
        public int ElectionId { get; set; }
        public string Nom { get; set; }
        public DateOnly DateElection { get; set; }
        public int NbSiege { get; set; }
        public string Description { get; set; }
        public int NbBulletin { get; set; }
        public int NbBulletinNull { get; set; }
        public int NbBulletinBlanc { get; set; }

        public int CommuneId { get; set; }

        public Commune Commune { get; set; }

        //Héritage de communeId ? --> 


    }
}
