using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class ContactNumberType
    {
        public Guid Id { get; set; }
        public string NumberType { get; set; }
        public List<ContactNumber> TypeOfNumber { get; set; }
    }
}
