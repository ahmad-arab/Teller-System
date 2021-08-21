using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellerDesktop
{
    public class CurrencyBalance
    {
        public Currency Currency { get; set; }
        public decimal DebtorValue { get; set; }
        public decimal CreditorValue { get; set; }

        public CurrencyBalance()
        {
            Currency = new Currency();
            DebtorValue = 0;
            CreditorValue = 0;
        }
        public CurrencyBalance(Currency currency, decimal value)
        {
            Currency = currency;
            if(value >= 0) { DebtorValue = value; CreditorValue = 0; }
            else { DebtorValue = 0; CreditorValue = 0-value; }
        }
        public CurrencyBalance(string currency, decimal value)
        {
            Currency = new Currency();
            Currency.Name = currency;
            if (value >= 0) { DebtorValue = value; CreditorValue = 0; }
            else { DebtorValue = 0; CreditorValue = 0-value; }
        }
    }
}
