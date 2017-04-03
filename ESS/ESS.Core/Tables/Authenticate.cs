using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Authenticate
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
    }
}
