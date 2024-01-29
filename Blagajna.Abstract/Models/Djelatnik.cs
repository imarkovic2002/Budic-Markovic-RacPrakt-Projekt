using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budić_Marković_RacPrakt_Projekt
{
    public class Djelatnik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string OIB { get; set; }
        public string Email { get; set; }
        public string BrojMobitela { get; set; }
        public string Role { get; set; }
        public DateTime DatumZaposlenja { get; set; }

    }
}
