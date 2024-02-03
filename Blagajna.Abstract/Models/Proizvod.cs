using System;
using System.Collections.Generic;
using System.Drawing;
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

        public float Cijena {  get; set; }
        public Image Image { get; set; }

    }
}
