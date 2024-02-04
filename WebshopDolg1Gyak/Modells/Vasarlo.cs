using System.Text.Json.Serialization;

namespace WebshopDolg1Gyak.Modells
{
    public class Vasarlo
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Nev { get; set; }

    
        public string Email { get; set; }

        public string Lakcim { get; set; }

        public DateTime Szulev { get; set; }


    }



}
