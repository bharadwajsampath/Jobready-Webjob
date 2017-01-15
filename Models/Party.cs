using Models;
using Models.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Models
{

    public class PartyRoot
    {
        [JsonProperty("party")]
        public Party Party { get; set; }
    }

    public class Party
    {
        public string id { get; set; }

        [JsonProperty("party-identifier")]
        public string partyidentifier { get; set; }
        [JsonProperty("party-type")]
        public string partytype { get; set; }
        [JsonProperty("contact-method")]
        public string contactmethod { get; set; }
        public string title { get; set; }


        public string surname { get; set; }
        [JsonProperty("first-name")]

        public string firstname { get; set; }
        [JsonProperty("middle-name")]

        public string middle { get; set; }
        [JsonProperty("birth-date")]

        public string birthdate { get; set; }
        public string gender { get; set; }
        public string login { get; set; }
        [JsonProperty("password-temporary")]

        public string passwordtemporary { get; set; }
        [JsonProperty("logon-enabled")]

        public string logonenabled { get; set; }
        [JsonProperty("created-on")]

        public string createdon { get; set; }
        [JsonProperty("updated-on")]

        public string updatedon { get; set; }
        [JsonProperty("usi-status")]

        public string usistatus { get; set; }


        [JsonProperty("usi-number")]

        public string usinumber { get; set; }

        public virtual Addresses addresses { get; set; }
        [JsonProperty("contact-details")]

        public ContactDetails contactdetails { get; set; }


        public Avetmiss avetmiss { get; set; }
        [JsonProperty("ad-hoc-fields")]
        public AdHocField AdHocFields { get; set; }

    }

}