using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class PartyAttendance
    {
        public string PartyId { get; set; }
        public string ArrivedAt { get; set; }
        public string LeftAt { get; set; }
        public string Notes { get; set; }
        public string AbsenceReason { get; set; }
        public bool Attened { get; set; }
    }
}
