using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class Vault : IFinancialAccountOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FinancialAccount FinancialAccount { get; set; }

        public Vault()
        {
            Id = -1;
            Name = "";
            FinancialAccount = new FinancialAccount(FinancialAccountType.Vault);
        }
        public Vault(int id, string name,FinancialAccount account)
        {
            Id = id;
            Name = name;
            FinancialAccount = account;
        }
        public Vault(Vault v)
        {
            Id = v.Id;
            Name = v.Name;
            FinancialAccount = v.FinancialAccount;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Vault v)
        {
            return Name == v.Name;
        }
    }
}
