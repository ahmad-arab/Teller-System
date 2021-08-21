using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellerDesktop
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Currency MainCurrency { get; set; }
        public FinancialAccount FinancialAccount { get; set; }

        public Branch()
        {
            Id = -1;
            Name = "";
            MainCurrency = new Currency();
            FinancialAccount = new FinancialAccount(FinancialAccountType.Branch);
        }
        public Branch(int id, string name, Currency mainCurrency, FinancialAccount account)
        {
            Id = id;
            Name = name;
            MainCurrency = mainCurrency;
            FinancialAccount = account;
        }
        public Branch(Branch branch)
        {
            Id = branch.Id;
            Name = branch.Name;
            MainCurrency = branch.MainCurrency;
            FinancialAccount = branch.FinancialAccount;
        }

        public bool EqualsByName(string name)
        {
            return Name == name;
        }
        public bool EqualsByName(Branch branch)
        {
            return Name == branch.Name;
        }
    }
}
