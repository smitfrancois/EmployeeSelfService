using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Company
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public List<Department> Departments { get; set; }
        public Country Country { get; set; }
    }
}
