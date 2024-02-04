using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebshopDolg1Gyak.Modells
{
    public class Vasarlasok
    {
        [JsonIgnore]
        public int Id { get; set; }

      
        public int VasarloId { get; set; }

      

        public int TermekId { get; set; }

        public int Mennyiseg { get; set; }

        public DateTime Datum { get; set; }

       


    }
}
