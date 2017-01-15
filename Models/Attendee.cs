using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Models
{
    public class AttendeesRoot
    {
        [JsonProperty("attendees")]

        public Attendees Attendees { get; set; }
    }

    public class Attendees
    {

        [JsonConverter(typeof(SingleOrArrayConverter<Attendee>))]
        [JsonProperty("attendee")]
        public List<Attendee> Attendee { get; set; }

    }

    public class Attendee
    {

        [JsonProperty("party-identifier")]

        public string partyId { get; set; }

        public string attended { get; set; }
        [JsonProperty("arrived-at")]

        public string arrivedAt { get; set; }
        [JsonProperty("left-at")]

        public string leftAt { get; set; }
        [JsonProperty("notes")]
        public string notes { get; set; }
        [JsonProperty("duration")]
        public string duration { get; set; }
        [JsonProperty("absence-reason")]
        public string absencereason { get; set; }
    }

}