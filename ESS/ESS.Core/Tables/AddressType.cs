using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class AddressType
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
