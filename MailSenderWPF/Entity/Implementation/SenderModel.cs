using MailSenderWPF.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderWPF.Entity.Implementation
{
    public class SenderModel : ISenderEntity
    {
        public string Password { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
    }
}
