using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    
    public class Employee : BaseModel, IFinancialAccountOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string WorkTitle { get; set; }
        public SalaryFrequancy SalaryFrequancy { get; set; }
        public Currency Currency { get; set; }
        public decimal Salary { get; set; }
        public FinancialAccount FinancialAccount { get; set; }
        public string TypeName { get; set; } = "العاملون";

        public Employee()
        {
            Id = -1;
            Name = "";
            Address = "";
            Email = "";
            Phone1 = "";
            Phone2 = "";
            WorkTitle = "";
            SalaryFrequancy = SalaryFrequancy.Monthly;
            Currency = new Currency();
            Salary = 0;
            FinancialAccount = new FinancialAccount(FinancialAccountType.Employee);
        }
        public Employee(int id, string name, string address,string email, string phone1,
                   string phone2, string workTitle, SalaryFrequancy freq, Currency currency, decimal salary, FinancialAccount account)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Phone1 = phone1;
            Phone2 = phone2;
            WorkTitle = workTitle;
            SalaryFrequancy = freq;
            Currency = currency;
            Salary = salary;
            FinancialAccount = account;
        }
        public Employee(Employee e)
        {
            Id = e.Id;
            Name = e.Name;
            Address = e.Address;
            Email = e.Email;
            Phone1 = e.Phone1;
            Phone2 = e.Phone2;
            WorkTitle = e.WorkTitle;
            SalaryFrequancy = e.SalaryFrequancy;
            Currency = e.Currency;
            Salary = e.Salary;
            FinancialAccount = e.FinancialAccount;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Employee e)
        {
            return Name == e.Name;
        }
    }
}
