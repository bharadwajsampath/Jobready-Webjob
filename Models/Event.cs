using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{

    public class EventsRoot
    {
        [JsonProperty("events")]

        public Events events { get; set; }
    }

    public class Events
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Event>))]
        [JsonProperty("event")]

        public List<Event> Event { get; set; }
    }

    public class EventRoot
    {
        public Event Event { get; set; }
    }
    public class Event
    {

        [JsonProperty("id")]
        public int EventId { get; set; }


        public int OnlineBookingId { get; set; }


        [JsonProperty("course-number")]
        public string coursenumber { get; set; }
        [JsonProperty("timetable-id")]

        public string timetableid { get; set; }

        public string title { get; set; }

        [JsonProperty("event-type")]
        public string eventtype { get; set; }


        public string description { get; set; }

        public string colour { get; set; }

        public string enabled { get; set; }

        [JsonProperty("event-date")]
        public string eventdate { get; set; }
        [JsonProperty("start-time")]
        public string starttime { get; set; }
        [JsonProperty("end-time")]
        public string endtime { get; set; }

        public string allday { get; set; }
        [JsonProperty("location-room")]

        public string locationroom { get; set; }

        public string unit { get; set; }

        public string element { get; set; }
        [JsonProperty("all-staff")]

        public string allstaff { get; set; }
        [JsonProperty("all-students")]

        public string allstudents { get; set; }
        [JsonProperty("minimum-number-of-attendees")]

        public string minimumnumberofattendees { get; set; }
        [JsonProperty("maximum-number-of-attendees")]

        public string maximumnumberofattendees { get; set; }
        [JsonProperty("total-enrolments")]

        public string totalenrolments { get; set; }


        public string trainer { get; set; }
        [JsonProperty("number-of-invitees")]

        public string numberofinvitees { get; set; }

        [JsonProperty("event-repeat-type")]
        public string eventrepeattype { get; set; }

        [JsonProperty("repeat-every")]
        public string repeatevery { get; set; }

        [JsonProperty("repeat-end")]
        public string repeatend { get; set; }

        [JsonProperty("repeat-days")]
        public string repeatdays { get; set; }

        [JsonProperty("created-on")]
        public string createdon { get; set; }
        [JsonProperty("updated-on")]

        public string updatedon { get; set; }

        public string update { get; set; }
        [JsonProperty("event-links")]

        public eventlinks Eventlinks { get; set; }
    }


    public class eventlinks
    {
        [JsonProperty("event-link")]
        [JsonConverter(typeof(SingleOrArrayConverter<eventlink>))]
        public List<eventlink> Eventlink { get; set; }

    }

    public class eventlink
    {
        public int id { get; set; }
        public string course { get; set; }
    }
}