using Models.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class InvoiceOptions
    {
        [JsonConverter(typeof(SingleOrArrayConverter<InvoiceOption>))]

        [JsonProperty("invoice-option")]
        public List<InvoiceOption> invoiceoption { get; set; }
    }

    public class InvoiceOption
    {
        public string id { get; set; }
        public string name { get; set; }
        public string enabled { get; set; }
        [JsonProperty("created-on")]
        public DateTime createdon { get; set; }
        [JsonProperty("updated-on")]
        public DateTime updatedon { get; set; }
        [JsonProperty("payment-made")]
        public string paymentmade { get; set; }

        [JsonProperty("date-from")]
        public string datefrom { get; set; }
        [JsonProperty("option-type")]
        public string optiontype { get; set; }
        [JsonProperty("online-enrolment-enabled")]
        public string onlineenrolmentenabled { get; set; }

        public string total { get; set; }
        public string description { get; set; }


    }
}
