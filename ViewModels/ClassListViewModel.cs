using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class ClassListViewModel
    {
        public string PartyId { get; set; }
        public string FullName { get; set; }
        public bool AvetmissComplete { get; set; }
        public bool IsPresent { get; set; }

        public bool IsMarked { get; set; }

        public string CourseName { get; set; }

        public string EventId { get; set; }

        public bool IsTrainer { get; set; }

    }



}
