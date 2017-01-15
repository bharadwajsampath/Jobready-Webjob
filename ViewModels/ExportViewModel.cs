using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ExportViewModel
    {
        public Course Course { get; set; }
        public Event Event { get; set; }
        public List<ExportStudent> Students { get; set; }
    }

    public class ExportStudent
    {
        public string PartyId { get; set; }
        public string FullName { get; set; }
        public string IsPresent { get; set; }
        public string Duration { get; set; }
        public string TimeArrived { get; set; }
        public string TimeLeft { get; set; }
        public string AbsentReason { get; set; }
        public string Notes { get; set;}
    }
}
