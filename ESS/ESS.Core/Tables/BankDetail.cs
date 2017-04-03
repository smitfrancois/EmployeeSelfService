using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class BankDetail
    {
        public Guid Id { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchNumber { get; set; }
        public Employee Employee { get; set; }
    }
}
