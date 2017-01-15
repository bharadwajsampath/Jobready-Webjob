using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{

    public class IdentificationRoot
    {
        [JsonProperty("identifications")]
        public Identifications Identifications { get; set; }
    }

    public class Identifications
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Identification>))]
        [JsonProperty("identification")]
        public List<Identification> Identification { get; set; }
    }





    public class Identification
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identification-type")]
        public string Identificationtype { get; set; }

        [JsonProperty("identification-number")]
        public string Identificationnumber { get; set; }
    }


}