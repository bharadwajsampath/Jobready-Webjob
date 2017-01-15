using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{

    public class ElementRoot
    {
        [JsonProperty("elements")]
        public Elements Elements { get; set; }
    }


    public class Elements
    {
        [JsonProperty("element")]
        public List<Element> Element { get; set; }
    }

    public class Element
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("outcome")]
        public string Outcome { get; set; }

        [JsonProperty("outcome-date")]
        public string Outcomedate { get; set; }

        [JsonProperty("start-date")]
        public string Startdate { get; set; }

        [JsonProperty("end-date")]
        public string Enddate { get; set; }
    }
}