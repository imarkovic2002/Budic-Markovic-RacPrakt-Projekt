using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna.Abstract.Models
{
    public class Storno
    {
        public int Id { get; set; }
        public float Ukupni_iznos {  get; set; }
        public DateTime Datum_storno { get; set; }  
        public int Id_transakcija {  get; set; }    

    }
}
