using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TellerDesktop
{
    
    public class FinancialAction
    {
        public int Id { get; set; }
        public int VoucherId { get; set; }
        public VoucherType VoucherType { get; set; }
        public FinancialAccount Account { get; set; }
        public decimal DebtorValue { get; set; }
        public decimal CreditorValue { get; set; }
        public Currency Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Note { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public FinancialAction()
        {
            Id = -1;
            VoucherId = -1;
            Account = new FinancialAccount();
            VoucherType = VoucherType.JournalVoucher;
            DebtorValue = 0;
            CreditorValue = 0;
            Currency = new Currency();
            ExchangeRate = 0;
            Value = 0;
            Note = "";
            Date = DateTime.Now;
        }
        public FinancialAction(int id, int voucherId, FinancialAccount account, VoucherType type, decimal debtorValue, 
            decimal creditorValue, Currency currency, decimal exchangeRate, string note, decimal value, DateTime date)
        {
            Id = id;
            VoucherId = voucherId;
            Account = account;
            VoucherType = type;
            DebtorValue = debtorValue;
            CreditorValue = creditorValue;
            Currency = currency;
            ExchangeRate = exchangeRate;
            Value = value;
            Note = note;
            Date = date;
        }
        public FinancialAction(FinancialAction action)
        {
            Id = action.Id;
            VoucherId = action.VoucherId;
            Account = action.Account;
            VoucherType = action.VoucherType;
            DebtorValue = action.DebtorValue;
            CreditorValue = action.CreditorValue;
            Currency = action.Currency;
            ExchangeRate = action.ExchangeRate;
            Value = action.Value;
            Note = action.Note;
            Date = action.Date;
        }
    }
}
