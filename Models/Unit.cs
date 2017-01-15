using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{

    public class Units
    {
        [JsonProperty("unit")]
        [JsonConverter(typeof(SingleOrArrayConverter<Unit>))]

        public List<Unit> units { get; set; }
    }

    public class Unit
    {

        public string id { get; set; }
        [JsonProperty("unit-scope")]
        public string unitscope { get; set; }
        public string score { get; set; }
        public string outcome { get; set; }
        [JsonProperty("outcome-date")]
        public string outcomedate { get; set; }
        [JsonProperty("start-date")]
        public string startdate { get; set; }
        [JsonProperty("end-date")]
        public string enddate { get; set; }
        [JsonProperty("target-end-date")]
        public string targetenddate { get; set; }
        public string note { get; set; }
        [JsonProperty("delivery-mode")]
        public string deliverymode { get; set; }
        [JsonProperty("funding-source-state")]
        public string fundingsourcestate { get; set; }
        [JsonProperty("scheduled-hours")]
        public string scheduledhours { get; set; }
        [JsonProperty("vet-disable")]
        public string vetdisable { get; set; }
        [JsonProperty("assessment-method")]
        public string assessmentmethod { get; set; }
        public string contract { get; set; }
        [JsonProperty("created-on")]

        public string createdon { get; set; }
        [JsonProperty("updated-on")]

        public string updatedon { get; set; }
    }
}