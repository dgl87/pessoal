using System;
using System.Collections.Generic;

namespace ToolsVucMigration.Models
{
    public class CustomerModel
    {
        public IDictionary<string, string> Id { get; set; } //_Campo CPF(Sem os caracteres) da collection customer_
        public string Name { get; set; }
        public string NickName { get; set; }
        public string PersonType { get; set; }
        public string Gender { get; set; } //dúvida null
        public string MaritalStatus { get; set; } //null
        public DateTime BirthDate { get; set; } 
        public IDictionary<string, string> Documents { get; set; } //
        public List<AddressesModel> Addresses { get; set; }
    }
    public class AddressesModel
    {
        public string Key { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public CountryModel Country { get; set; }
        public IDictionary<double, double> Geocode { get; set; }
        public KindModel Kind { get; set; }
        public bool IsValid { get; set; }
        public List<EmailsModel> Emails { get; set; }
        public List<PhonesModel> Phones { get; set; }
    }
    public class CountryModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class KindModel
    {
        public string Id { get; set; }
    }
    public class EmailsModel
    {
        public string Address { get; set; }
        public IDictionary<string, string> Kind { get; set; }
    }
    public class PhonesModel
    {
        public int MyProperty { get; set; }
        public IDictionary<string, string> Kind { get; set; }
    }
}
