using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class ContactNumber
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public ContactNumberType TypeOfNumber { get; set; }
        public Employee Employee { get; set; }
    }
}
