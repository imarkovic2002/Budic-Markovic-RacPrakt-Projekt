using System.Drawing;

namespace Blagajna.Abstract.Models
{
    public class Proizvod
    {
        public int ID {  get; set; }
        public string Naziv {  get; set; }
        public string Kolicina {  get; set; }

        public float Cijena { get; set; }
        public Image Image { get; set; }

    }
}
