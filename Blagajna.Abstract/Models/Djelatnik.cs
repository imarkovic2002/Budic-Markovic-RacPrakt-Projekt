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
        public string Lozinka {get;set;}

        public Djelatnik Clone()
        {
            return new Djelatnik
            {
                ID = this.ID,
                Ime = this.Ime,
                Prezime = this.Prezime,
                DatumRodjenja = this.DatumRodjenja,
                OIB = this.OIB,
                Email = this.Email,
                BrojMobitela = this.BrojMobitela,
                Role = this.Role,
                DatumZaposlenja = this.DatumZaposlenja,
                Lozinka = this.Lozinka
            };
        }
    }
}
