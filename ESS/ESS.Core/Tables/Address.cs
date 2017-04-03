using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Address
    {
        public Guid Id { get; set; }
        public int Unit { get; set; }
        public string Complex { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Town { get; set; }
        public int PostCode { get; set; }
        public Country Country { get; set; }
        public AddressType AddressType { get; set; }
        public Employee Employee { get; set; }
    }
}
