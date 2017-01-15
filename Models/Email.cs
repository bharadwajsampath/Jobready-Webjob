using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Email
    {
        public string From { get; set; }

        public string To { get; set; }

        public string BCC { get; set; }

        public string CC { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }

        public string Attachment { get; set; }

        public string FileName { get; set; }
    }
}
