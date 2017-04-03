using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESS.Core.Tables;
using ESS.Core.Tables.Mappings;

namespace ESS.Core
{
    public class EssDbInitializer: DropCreateDatabaseIfModelChanges<EssDbContexts>
    {
        protected override void Seed(EssDbContexts context)
        {
            var genders = CreateGenders();
            var maritalStatus = CreateMaritalStatus();
            var languages = CreateLanguages();
            var contactNumberTypes = CreateContactNumberTypes();
            var countries = createCountries();
            var addressTypes = CreateAddressTypes();
            var accountTypes = CreateAccountTypes();

            context.AccountTypes.AddRange(accountTypes);
            context.AddressTypes.AddRange(addressTypes);
            context.Countries.AddRange(countries);
            context.ContactNumberTypes.AddRange(contactNumberTypes);
            context.Languages.AddRange(languages);
            context.MaritalStatuses.AddRange(maritalStatus);
            context.Genders.AddRange(genders);
            

            base.Seed(context);
        }

        private List<AccountType> CreateAccountTypes()
        {
            List<AccountType> accountTypes = new List<AccountType>();

            accountTypes.Add(new AccountType() {Id=Guid.NewGuid(),TypeName = "Savings"});
            accountTypes.Add(new AccountType() { Id = Guid.NewGuid(), TypeName = "Current" });

            return accountTypes;
        }

        private List<AddressType> CreateAddressTypes()
        {
            List<AddressType> addressTypes = new List<AddressType>();

            addressTypes.Add(new AddressType() {Id=Guid.NewGuid(),Type = "Postal"});
            addressTypes.Add(new AddressType() { Id = Guid.NewGuid(), Type = "Residential" });

            return addressTypes;
        }

        private List<Country> createCountries()
        {
            List<Country> countries = new List<Country>();

            countries.Add(new Country() {Id=Guid.NewGuid(),CountryName = "South Africa"});

            return countries;
        }

        private List<ContactNumberType> CreateContactNumberTypes()
        {
            List<ContactNumberType> contactNumberTypes = new List<ContactNumberType>();

            contactNumberTypes.Add(new ContactNumberType() {Id=Guid.NewGuid(),NumberType = "Cell"});
            contactNumberTypes.Add(new ContactNumberType() { Id = Guid.NewGuid(), NumberType = "Home" });
            contactNumberTypes.Add(new ContactNumberType() { Id = Guid.NewGuid(), NumberType = "Work" });
            contactNumberTypes.Add(new ContactNumberType() { Id = Guid.NewGuid(), NumberType = "Fax" });

            return contactNumberTypes;
        }

        private List<Language> CreateLanguages()
        {
            List<Language> languages = new List<Language>();

            languages.Add(new Language() {Id = Guid.NewGuid(),LanguageName = "English"});
            languages.Add(new Language() { Id = Guid.NewGuid(), LanguageName = "Afrikaans" });
            languages.Add(new Language() { Id = Guid.NewGuid(), LanguageName = "Zulu" });

            return languages;
        }

        private List<MaritalStatus> CreateMaritalStatus()
        {
            List<MaritalStatus> maritalStatuses = new List<MaritalStatus>();

            maritalStatuses.Add(new MaritalStatus() {Id =Guid.NewGuid(),Status = "Married"});
            maritalStatuses.Add(new MaritalStatus() { Id = Guid.NewGuid(), Status = "Single" });
            maritalStatuses.Add(new MaritalStatus() { Id = Guid.NewGuid(), Status = "Divorced" });
            maritalStatuses.Add(new MaritalStatus() { Id = Guid.NewGuid(), Status = "Widowed" });

            return maritalStatuses;
        }

        private List<Gender> CreateGenders()
        {
            List<Gender> gender = new List<Gender>();

            gender.Add(new Gender() {Id = Guid.NewGuid(),Name = "Male"});
            gender.Add(new Gender() { Id = Guid.NewGuid(), Name = "Female" });

            return gender;
        }
    }
}
