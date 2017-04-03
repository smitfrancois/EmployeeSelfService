using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class CostCenter
    {
        public Guid Id { get; set; }
        public string CostCenterCode { get; set; }
        public string CostCenterName { get; set; }
        public Department Department { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
