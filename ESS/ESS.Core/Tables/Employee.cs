using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IDNumber { get; set; }
        public string PassportNumber { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int Dependants { get; set; }
        public Language Language { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string EmergencyContactPerson { get; set; }
        public string EmergencyContactPersonNumber { get; set; }
        public BankDetail BankDetails { get; set; }
        public List<ContactNumber> ContactNumbers { get; set; }
        public List<Address> Addresses { get; set; }
        public CostCenter CostCenter { get; set; }
        public Authenticate Authenticate { get; set; }


    }
}
