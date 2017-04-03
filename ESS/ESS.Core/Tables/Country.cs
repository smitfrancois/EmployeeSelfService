using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Country
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Company> Companies { get; set; }
    }
}
