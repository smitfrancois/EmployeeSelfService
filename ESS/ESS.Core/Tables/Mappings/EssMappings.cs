using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.Core.Tables.Mappings
{
    internal class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(x => x.Id);
            ToTable("Employees");
            HasOptional(x => x.Gender).WithMany(x => x.Employees);
            HasOptional(x => x.MaritalStatus).WithMany(x => x.Employees);
            HasOptional(x => x.Language).WithMany(x => x.Employees);
            HasMany(x => x.Addresses).WithOptional(x => x.Employee);
            HasMany(x => x.ContactNumbers).WithOptional(x => x.Employee);
            HasRequired(x => x.BankDetails).WithRequiredPrincipal(x => x.Employee);
            HasRequired(x => x.Authenticate).WithRequiredPrincipal(x => x.Employee);
        }
    }

    internal class GenderMap : EntityTypeConfiguration<Gender>
    {
        public GenderMap()
        {
            HasKey(x => x.Id);
            ToTable("Genders");
        }
    }

    internal class MaritalStatusMap : EntityTypeConfiguration<MaritalStatus>
    {
        public MaritalStatusMap()
        {
            HasKey(x => x.Id);
            ToTable("MaritalStatuses");
        }
    }

    internal class LanguageMap : EntityTypeConfiguration<Language>
    {
        public LanguageMap()
        {
            HasKey(x => x.Id);
            ToTable("Languages");

        }
    }

    internal class ContactNumberMap : EntityTypeConfiguration<ContactNumber>
    {
        public ContactNumberMap()
        {
            HasKey(x => x.Id);
            ToTable("ContactNumbers");
            HasRequired(x => x.TypeOfNumber).WithMany(x => x.TypeOfNumber);
        }
    }

    internal class ContactNumberTypeMap : EntityTypeConfiguration<ContactNumberType>
    {
        public ContactNumberTypeMap()
        {
            HasKey(x => x.Id);
            ToTable("ContactNumberTypes");
        }
    }

    internal class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            HasKey(x => x.Id);
            ToTable("Addresses");

            HasRequired(x => x.AddressType).WithMany(x => x.Addresses);
            HasRequired(x => x.Country).WithMany(x => x.Addresses);
            
        }
    }

    internal class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            HasKey(x => x.Id);
            ToTable("Countries");
        }
    }

    internal class AddressTypeMap : EntityTypeConfiguration<AddressType>
    {
        public AddressTypeMap()
        {
            HasKey(x => x.Id);
            ToTable("AddressTypes");
        }
    }

    internal class BankDetailMap : EntityTypeConfiguration<BankDetail>
    {
        public BankDetailMap()
        {
            HasKey(x => x.Id);
            ToTable("BankDetails");
        }
    }

    internal class AccountTypeMap : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeMap()
        {
            HasKey(x => x.Id);
            ToTable("AccountTypes");
        }
    }

    internal class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            HasKey(x => x.Id);
            ToTable("Companies");
            HasMany(x => x.Departments).WithRequired(x=>x.Company);
            HasRequired(x => x.Country).WithMany(x => x.Companies);
        }
    }

    internal class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            HasKey(x => x.Id);
            ToTable("Departments");
            HasMany(x => x.CostCenters).WithRequired(x => x.Department);
        }
    }

    internal class CostCenterMap : EntityTypeConfiguration<CostCenter>
    {
        public CostCenterMap()
        {
            HasKey(x => x.Id);
            ToTable("CostCenters");
            HasMany(x => x.Employees).WithRequired(x => x.CostCenter);
        }
    }

    internal class AuthenticateMap : EntityTypeConfiguration<Authenticate>
    {
        public AuthenticateMap()
        {
            HasKey(x => x.Id);
            ToTable("Authenticate");
           
        }
    }
}
