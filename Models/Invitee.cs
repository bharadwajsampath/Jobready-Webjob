using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class Invitee
    {
        [JsonProperty("id")]
        public int? InviteeId { get; set; }



        public string courseNumber { get; set; }
        [JsonProperty("party-identifier")]

        public string partyidentifier { get; set; }
        public string exclusion { get; set; }


        public int? OnlineBookingId { get; set; }
    }


    public class InviteeRoot
    {
        [JsonProperty("invitees")]
        public Invitees Invitees { get; set; }


    }


    public class Invitees
    {
        [JsonProperty("@total")]

        public string total { get; set; }
        [JsonProperty("invitee")]
        [JsonConverter(typeof(SingleOrArrayConverter<Invitee>))]
        public List<Invitee> invitee { get; set; }
    }
}