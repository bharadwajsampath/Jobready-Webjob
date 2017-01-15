using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Models
{
    public class PartyFeeHelpRoot
    {
        [JsonProperty("party-vet-fee-help")]
        public Partyvetfeehelp PartyVetFeeHelp { get; set; }
    }



    public class Partyvetfeehelp
    {
        [JsonProperty("fee-type")]
        public string Feetype { get; set; }

        [JsonProperty("chessn")]
        public string Chessn { get; set; }

        [JsonProperty("tax-file-number")]
        public string Taxfilenumber { get; set; }

        [JsonProperty("tfn-status")]
        public string Tfnstatus { get; set; }

        [JsonProperty("visa")]
        public string Visa { get; set; }

        [JsonProperty("year-of-arrival")]
        public string Yearofarrival { get; set; }
    }
}