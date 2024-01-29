using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna.Abstract.Models
{
    public class Transakcija
    {
        public DateTime Datum_transakcije { get; set; }
        public float Ukupni_iznos { get; set; }
    }
}
