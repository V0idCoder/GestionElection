using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionService.Model
{
    public class Commune
    {
        public int communeId { get; set; }
        public  string nom { get; set; }
        public int npa { get; set; }
        public int numero { get; set; }
        public string canton { get; set; }
    }
}
