using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blagajna.Abstract.Models
{
    public class Transakcija
    {
        public int id {  get; set; }    
        public DateTime Datum_transakcije { get; set; }
        public float Ukupni_iznos { get; set; }
        public string nacin_placanja {  get; set; }

    }
}
