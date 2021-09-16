using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class Customer : BaseModel, IFinancialAccountOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public FinancialAccount FinancialAccount { get; set; }
        public string TypeName { get; set; } = "الزبائن";

        public Customer()
        {
            Id = -1;
            Name = "";
            Address = "";
            Email = "";
            Phone1 = "";
            Phone2 = "";
            FinancialAccount = new FinancialAccount(FinancialAccountType.Customer);
        }
        public Customer(int id, string name, string address,string email, string phone1,
                   string phone2,FinancialAccount account)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Phone1 = phone1;
            Phone2 = phone2;
            FinancialAccount = account;
        }
        public Customer(Customer cus)
        {
            Id = cus.Id;
            Name = cus.Name;
            Address = cus.Address;
            Email = cus.Email;
            Phone1 = cus.Phone1;
            Phone2 = cus.Phone2;
            FinancialAccount = cus.FinancialAccount;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Customer cus)
        {
            return Name == cus.Name;
        }
    }
}
