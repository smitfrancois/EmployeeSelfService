using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Language
    {
        public Guid Id { get; set; }
        public string LanguageName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
