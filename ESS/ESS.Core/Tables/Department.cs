using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Department
    {
        public Guid Id { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public Company Company { get; set; }
        public List<CostCenter> CostCenters { get; set; }
    }
}
