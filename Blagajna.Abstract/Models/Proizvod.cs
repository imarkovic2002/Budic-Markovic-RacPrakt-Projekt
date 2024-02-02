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
        public string Naziv {  get; set; }
        public string Kolicina {  get; set; }

        public string Cijena {  get; set; }

    }
}
