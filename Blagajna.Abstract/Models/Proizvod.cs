using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blagajna.Abstract.Models
{
   public class Proizvod
    {
        public int ID {  get; set; }
        public string naziv {  get; set; }
        public string kolicina {  get; set; }

        public float cijena {  get; set; }

    }
}
