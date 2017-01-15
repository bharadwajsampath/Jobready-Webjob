using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class PostAttendanceViewModel
    {
        public string InTime { get; set; }

        public string  OutTime { get; set; }

        public string Notes { get; set; }

        public string AbsentReason { get; set; }

        public bool Attended { get; set; }

        public string CourseNumber { get; set; }

        public string EventId { get; set; }

        public string PartyId { get; set; }
    }
}
