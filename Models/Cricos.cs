using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Models
{
    public class CricosRoot
    {
        public Cricos cricos { get; set; }
    }



    public class Cricos
    {
        [JsonProperty("visa-status")]
        public string Visastatus { get; set; }

        [JsonProperty("visa-type")]
        public string Visatype { get; set; }

        [JsonProperty("visa-subtype")]
        public string Visasubtype { get; set; }

        [JsonProperty("visa-education-sector")]
        public string Visaeducationsector { get; set; }

        [JsonProperty("svp-assessment-level")]
        public string Svpassessmentlevel { get; set; }

        [JsonProperty("english-test-type")]
        public string Englishtesttype { get; set; }

        [JsonProperty("english-test-delivery-method")]
        public string Englishtestdeliverymethod { get; set; }

        [JsonProperty("english-test-score")]
        public string Englishtestscore { get; set; }

        [JsonProperty("english-test-date")]
        public string Englishtestdate { get; set; }

        [JsonProperty("agent-party-identifier")]
        public string Agentpartyidentifier { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("country-of-birth")]
        public string Countryofbirth { get; set; }

        [JsonProperty("country-of-passport")]
        public string Countryofpassport { get; set; }

        [JsonProperty("oshc")]
        public string Oshc { get; set; }

        [JsonProperty("oshc-provider")]
        public string Oshcprovider { get; set; }

        [JsonProperty("oshc-member-number")]
        public string Oshcmembernumber { get; set; }

        [JsonProperty("oshc-expiry-date")]
        public string Oshcexpirydate { get; set; }

        [JsonProperty("created-on")]
        public string Createdon { get; set; }

        [JsonProperty("updated-on")]
        public string Updatedon { get; set; }
    }
}