using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class FileNoteRoot
    {
        [JsonProperty("file-note")]
        public FileNote filenote { get; set; }
    }

    public class FileNote
    {

        public string id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        [JsonProperty("follow-update")]
        public string followupdate { get; set; }
        [JsonProperty("specific-time")]
        public string specifictime { get; set; }
        [JsonProperty("public")]
        public string _public { get; set; }
        [JsonProperty("private")]
        public string _private { get; set; }
        [JsonProperty("assigned-user")]
        public string assigneduser { get; set; }
        [JsonProperty("closed-date")]
        public DateTime? closeddate { get; set; }
        [JsonProperty("created-on")]
        public DateTime? createdon { get; set; }
        [JsonProperty("updated-onB")]
        public DateTime? updatedon { get; set; }
    }
}