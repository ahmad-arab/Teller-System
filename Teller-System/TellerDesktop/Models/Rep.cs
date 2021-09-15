using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellerDesktop
{
    public class Rep : BaseModel, IFinancialAccountOwner
    {
        private string _country;
        private string _city;
        private string _restOfTheAddress;

        public int Id { get; set; }
        public string Name { get; set; }
        public string OfficeName { get; set; }
        public Branch Branch { get; set; }
        public string Country
        { 
            get { return _country; }
            set
            {
                _country = value;
                FullAddress = Country + "/" + City + "/" + RestOfTheAddress;
            }
        }
        public string City 
        {
            get { return _city; }
            set 
            {
                _city = value;
                FullAddress = Country + "/" + City + "/" + RestOfTheAddress;
            } 
        }
        public string RestOfTheAddress
        {
            get { return _restOfTheAddress; }
            set
            {
                _restOfTheAddress = value;
                FullAddress = Country + "/" + City + "/" + RestOfTheAddress;
            }
        }
        public string FullAddress { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string WorkingHours { get; set; }
        public FinancialAccount FinancialAccount { get; set; }

        public Rep()
        {
            Id = -1;
            Name = "";
            OfficeName = "";
            Branch = new Branch();
            Country = "";
            City = "";
            RestOfTheAddress = "";
            FullAddress = "";
            Email = "";
            Phone1 = "";
            Phone2 = "";
            WorkingHours = "";
            FinancialAccount = new FinancialAccount(FinancialAccountType.Rep);
        }
        public Rep(int id, string name, string officeName, Branch branch, string country,
                   string city, string restOfTheAddress, string email, string phone1,
                   string phone2, string workingHours, FinancialAccount account)
        {
            Id = id;
            Name = name;
            OfficeName = officeName;
            Branch = branch;
            Country = country;
            City = city;
            RestOfTheAddress = restOfTheAddress;
            Email = email;
            Phone1 = phone1;
            Phone2 = phone2;
            WorkingHours = workingHours;
            FinancialAccount = account;
        }
        public Rep(Rep rep)
        {
            Id = rep.Id;
            Name = rep.Name;
            OfficeName = rep.OfficeName;
            Branch = rep.Branch;
            Country = rep.Country;
            City = rep.City;
            RestOfTheAddress = rep.RestOfTheAddress;
            Email = rep.Email;
            Phone1 = rep.Phone1;
            Phone2 = rep.Phone2;
            WorkingHours = rep.WorkingHours;
            FinancialAccount = rep.FinancialAccount;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Rep rep)
        {
            return Name == rep.Name;
        }
    }
}
