using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagajna.Abstract.Models
{
    public class DnevniIzvjestaj
    {
       public  DateTime Datum {  get; set; }   
        public float Utrzak {  get; set; } 
        public float Storno {  get; set; } 
    }
}
