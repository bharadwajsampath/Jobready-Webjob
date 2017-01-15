using Models.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Models
{
    public class ContactDetails
    {
        [JsonProperty("contact-detail")]
        [JsonConverter(typeof(SingleOrArrayConverter<ContactDetail>))]

        public List<ContactDetail> contactdetail { get; set; }
    }

    public class ContactDetail
    {
        public string id { get; set; }
        public string primary { get; set; }
        public string value { get; set; }
        [JsonProperty("contact-type")]

        public string contacttype { get; set; }
        public string location { get; set; }
    }



}