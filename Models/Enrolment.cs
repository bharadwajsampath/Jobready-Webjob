using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace Models
{

    public class EnrolmentRoot
    {
        public Enrolment enrolment { get; set; }
    }
    public class Enrolment
    {
        [JsonProperty("id")]

        public int EnrolmentId { get; set; }
        [JsonProperty("enrolment-identifier")]
        public string enrolmentidentifier { get; set; }
        [JsonProperty("party-identifier")]
        public string partyidentifier { get; set; }

        [JsonProperty("course-number")]

        public string coursenumber { get; set; }
        [JsonProperty("start-date")]
        public string startdate { get; set; }
        [JsonProperty("target-end-date")]
        public string targetenddate { get; set; }
        [JsonProperty("end-date")]
        public string enddate { get; set; }
        [JsonProperty("study-reason")]
        public string studyreason { get; set; }
        [JsonProperty("study-mode")]
        public string studymode { get; set; }
        [JsonProperty("enrolment-status")]
        public string enrolmentstatus { get; set; }
        [JsonProperty("vet-in-schools")]

        public string vetinschools { get; set; }
        [JsonProperty("employment-basis")]

        public string employmentbasis { get; set; }

        [JsonProperty("enabled")]
        public string enabled { get; set; }
        [JsonProperty("invoice-option")]

        public string invoiceoption { get; set; }
        [JsonProperty("worker-type")]

        public string workertype { get; set; }
        [JsonProperty("traineeship")]

        public string traineeship { get; set; }
        [JsonProperty("qualification-issued")]

        public string qualificationissued { get; set; }

        public string location { get; set; }
        [JsonProperty("course-type")]

        public string coursetype { get; set; }

        [JsonProperty("fee-exemption-state")]
        public string feeexemptionstate { get; set; }

        public string language { get; set; }

        [JsonProperty("statement-issued")]
        public string statementissued { get; set; }
        [JsonProperty("reporting-enabled")]

        public string reportingenabled { get; set; }

        public string priority { get; set; }

        [JsonProperty("funding-source-state")]
        public string fundingsourcestate { get; set; }

        [JsonProperty("funding-source-national")]
        public string fundingsourcenational { get; set; }

        [JsonProperty("delivery-mode")]
        public string deliverymode { get; set; }

        public string contract { get; set; }

        public string trainer { get; set; }

        [JsonProperty("other-trainer")]
        public string othertrainer { get; set; }

        [JsonProperty("status-date")]
        public string statusdate { get; set; }

        [JsonProperty("created-on")]
        public DateTime createdon { get; set; }

        [JsonProperty("updated-on")]
        public DateTime updatedon { get; set; }

        public Units units { get; set; }

        public string subjects { get; set; }

        [JsonProperty("invoice-options")]

        public InvoiceOptions invoiceoptions { get; set; }

        [JsonProperty("adhoc-fields")]
        public string adhocfields { get; set; }

        public int? OnlineBookingId { get; set; }
    }

}