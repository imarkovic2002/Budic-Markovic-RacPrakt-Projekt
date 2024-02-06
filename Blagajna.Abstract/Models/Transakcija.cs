using System;


namespace Blagajna.Abstract.Models
{
    public class Transakcija
    {
        public int Id {  get; set; }    
        public DateTime DatumTransakcije { get; set; }
        public float UkupniIznos { get; set; }
        public string NacinPlacanja {  get; set; }

    }
}
