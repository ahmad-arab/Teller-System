using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class Partner : IFinancialAccountOwner
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public FinancialAccount FinancialAccount { get; set; }

        public Partner()
        {
            Id = -1;
            Name = "";
            Email = "";
            Phone1 = "";
            Phone2 = "";
            FinancialAccount = new FinancialAccount(FinancialAccountType.Partner);
        }
        public Partner(int id, string name, string email, string phone1,
                   string phone2, FinancialAccount account)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone1 = phone1;
            Phone2 = phone2;
            FinancialAccount = account;
        }
        public Partner(Partner p)
        {
            Id = p.Id;
            Name = p.Name;
            Email = p.Email;
            Phone1 = p.Phone1;
            Phone2 = p.Phone2;
            FinancialAccount = p.FinancialAccount;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Partner p)
        {
            return Name == p.Name;
        }
    }
}
