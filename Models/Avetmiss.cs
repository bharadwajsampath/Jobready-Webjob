using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class AvetmissRoot
    {
        public Avetmiss avetmiss { get; set; }
    }

    public class Avetmiss
    {
        public int Id { get; set; }

        [JsonProperty("highest-school-level")]
        public string highestschoollevel { get; set; }
        [JsonProperty("year-highest-school-level")]
        public string yearhighestschoollevel { get; set; }
        [JsonProperty("indigenous-status")]
        public string indigenousstatus { get; set; }
        [JsonProperty("main-language")]
        public string mainlanguage { get; set; }
        [JsonProperty("employment-category")]
        public string employmentcategory { get; set; }
        [JsonProperty("labour-force-status")]
        public string labourforcestatus { get; set; }
        [JsonProperty("disability-flag")]
        public string disabilityflag { get; set; }
        [JsonProperty("prior-education-flag")]
        public string prioreducationflag { get; set; }
        [JsonProperty("at-school-flag")]
        public string atschoolflag { get; set; }
        [JsonProperty("spoken-english-proficiency")]
        public string spokenenglishproficiency { get; set; }
        [JsonProperty("country-of-birth")]
        public string countryofbirth { get; set; }
        [JsonProperty("town-of-birth")]
        public string townofbirth { get; set; }
        [JsonProperty("nationality")]
        public string nationality { get; set; }

        [JsonProperty("prior-educations")]

        public PriorEducations prioreducations { get; set; }
        [JsonProperty("disabilities")]

        public Disabilities disabilities { get; set; }

        public virtual Party Party { get; set; }

        public int PartyId { get; set; }
    }

    public class Disabilities
    {
        [JsonProperty("disability")]
        [JsonConverter(typeof(SingleOrArrayConverter<DisabilityType>))]
        public List<DisabilityType> disability { get; set; }
    }

    public class DisabilityType
    {
        [JsonProperty("disability-type")]
        public string disabilitytype { get; set; }
    }

    public class PriorEducations
    {
        [JsonProperty("prior-education")]
        [JsonConverter(typeof(SingleOrArrayConverter<PriorEducation>))]
        public List<PriorEducation> prioreducation { get; set; }
    }

    public class PriorEducation
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("prior-education-type")]
        public string prioreducationtype { get; set; }
    }

}