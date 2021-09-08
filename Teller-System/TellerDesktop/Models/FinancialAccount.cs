using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellerDesktop
{
    
    public class FinancialAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public FinancialAccountType Type { get; set; }
        public ObservableCollection<CurrencyBalance> Balances { get; set; }

        public FinancialAccount()
        {
            Id = -1;
            Name = "";
            Code = "";
            Type = FinancialAccountType.Vault;
            Balances = new ObservableCollection<CurrencyBalance>();
        }
        public FinancialAccount(int id, string name, string code, FinancialAccountType type, ObservableCollection<CurrencyBalance> balances)
        {
            Id = id;
            Name = name;
            Code = code;
            Type = type;
            Balances = balances;
        }
        public FinancialAccount(FinancialAccount account)
        {
            Id = account.Id;
            Name = account.Name;
            Code = account.Code;
            Type = account.Type;
            Balances = account.Balances;
        }
        public FinancialAccount(FinancialAccountType type)
        {
            Id = -1;
            Name = "";
            Code = "";
            Type = type;
            Balances = new ObservableCollection<CurrencyBalance>();
        }

        public static FinancialAccount GetRandomAccount(int seed)
        {
            Random r = new Random(seed);
            ObservableCollection<CurrencyBalance> b = new ObservableCollection<CurrencyBalance> { new CurrencyBalance("ليرة سورية",r.Next(-100000,100000)),
                                                                  new CurrencyBalance("يورو",r.Next(-100000,100000)),
                                                                  new CurrencyBalance("دولار",r.Next(-100000,100000)),
                                                                  new CurrencyBalance("كرون",r.Next(-100000,100000)),};
            return new FinancialAccount
            {
                Id = r.Next(1, 50),
                Name = r.Next(10000, 100000).ToString(),
                Code = r.Next(10000, 100000).ToString(),
                Type = FinancialAccountType.Rep,
                Balances = b
            };
        }
    }
}
