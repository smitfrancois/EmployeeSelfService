using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESS.Core.Tables;
using ESS.Core.Tables.Mappings;

namespace ESS.Core
{
    public class EssDbContexts:DbContext
    {
        public EssDbContexts() : base("name=EssConnectionString")
        {
            Database.SetInitializer(new EssDbInitializer());
            Database.Initialize(true);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ContactNumber> ContactNumbers { get; set; }
        public DbSet<ContactNumberType> ContactNumberTypes { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<BankDetail> BankDetails { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<Authenticate> Authenticates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new MaritalStatusMap());
            modelBuilder.Configurations.Add(new LanguageMap());
            modelBuilder.Configurations.Add(new ContactNumberMap());
            modelBuilder.Configurations.Add(new ContactNumberTypeMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AddressTypeMap());
            modelBuilder.Configurations.Add(new BankDetailMap());
            modelBuilder.Configurations.Add(new AccountTypeMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new CostCenterMap());
            modelBuilder.Configurations.Add(new AuthenticateMap());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
