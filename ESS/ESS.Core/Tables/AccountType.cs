using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class AccountType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public List<BankDetail> BankDetails { get; set; }
    }
}
