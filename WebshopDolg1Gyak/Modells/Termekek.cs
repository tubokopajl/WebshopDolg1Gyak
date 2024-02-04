using System.Text.Json.Serialization;

namespace WebshopDolg1Gyak.Modells
{
    public class Termekek
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Nev { get; set; }

        public decimal Ar { get; set; }

        public string Mertekegyseg { get; set; }



    }

}
