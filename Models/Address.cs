using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{

    public class Addresses
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Address>))]
        public List<Address> address { get; set; }
    }

    public class Address
    {
        public int id { get; set; }
        public string primary { get; set; }
        [JsonProperty("street-address1")]
        public string streetaddress1 { get; set; }
        [JsonProperty("street-number")]
        public string streetnumber { get; set; }
        [JsonProperty("street-name")]
        public string streetname { get; set; }
        [JsonProperty("street-line")]
        public string streetline { get; set; }
        [JsonProperty("street-type")]
        public string streettype { get; set; }

        public string suburb { get; set; }
        [JsonProperty("post-code")]
        public string postcode { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string location { get; set; }

    }

}