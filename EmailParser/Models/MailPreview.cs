using EAGetMail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailParser.Models
{
    public class MailPreview
    {
        public string Subject { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public string From { get; set; }
        public MailInfo MailInfo { get; set; }
        public bool Processed { get; set; }
    }
}
