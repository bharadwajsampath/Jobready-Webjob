using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Models.Helpers;
using Models.Models;

namespace Models
{
    public class CourseRoot
    {
        public Course course { get; set; }
    }

    public class Course
    {

        [JsonProperty("id")]
        public int CourseId { get; set; }

        public int? OnlineBookingId { get; set; }


        [JsonProperty("course-number")]
        public string coursenumber { get; set; }
        [JsonProperty("course-name")]
        public string coursename { get; set; }
        [JsonProperty("course-scope-code")]
        public string coursescopecode { get; set; }
        [JsonProperty("course-scope-name")]

        public string coursescopename { get; set; }
        [JsonProperty("start-date")]
        public DateTime startdate { get; set; }
        [JsonProperty("end-date")]

        public DateTime enddate { get; set; }
        [JsonProperty("maximum-enrolments")]

        public string maximumenrolments { get; set; }
        [JsonProperty("minimum-enrolments")]

        public string minimumenrolments { get; set; }
        [JsonProperty("total-enrolments")]

        public string totalenrolments { get; set; }

        [JsonProperty("assessment-method")]
        public string assessmentmethod { get; set; }


        public string location { get; set; }

        public string trainer { get; set; }

        public string avetmiss { get; set; }
        [JsonProperty("delivery-mode")]

        public string deliverymode { get; set; }
        [JsonProperty("funding-source-national")]

        public string fundingsourcenational { get; set; }

        public string state { get; set; }
        [JsonProperty("element-grade")]

        public string elementgrade { get; set; }
        [JsonProperty("study-reason")]

        public string studyreason { get; set; }
        [JsonProperty("unit-of-study")]

        public string unitofstudy { get; set; }
        [JsonProperty("invoice-options")]

        public InvoiceOptions invoiceoptions { get; set; }
    }
    public class InvoiceOptions
    {
        [JsonConverter(typeof(SingleOrArrayConverter<InvoiceOptions>))]

        [JsonProperty("invoice-option")]
        public List<InvoiceOption> invoiceoption { get; set; }
    }
}