using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TellerDesktop
{
    public class Voucher
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Currency Currency { get; set; }
        public decimal ExchangeRate { get; set; }
        public FinancialAccount Account { get; set; }
        public int SecurityLevel { get; set; }
        public string Note { get; set; }
        public string Editor { get; set; }
        public VoucherType Type { get; set; }
        public ObservableCollection<FinancialAction> Actions { get; set; }

        public Voucher()
        {
            Id = -1;
            Date = DateTime.Now;
            Currency = new Currency();
            ExchangeRate = 0;
            Account = new FinancialAccount();
            SecurityLevel = 0;
            this.Type = VoucherType.JournalVoucher;
            Note = "";
            Editor = "";
            Actions = new ObservableCollection<FinancialAction>();
        }
        public Voucher(int id, DateTime date, Currency currency, decimal exchangeRate,
                              FinancialAccount account, int securityLevel, string note, string editor, VoucherType type,
                              ObservableCollection<FinancialAction> actions)
        {
            Id = id;
            Date = date;
            Currency = currency;
            ExchangeRate = exchangeRate;
            Account = account;
            SecurityLevel = securityLevel;
            Note = note;
            Editor = editor;
            this.Type = type;
            Actions = actions;
        }
        public Voucher(Voucher p)
        {
            Id = p.Id;
            Date = p.Date;
            Currency = p.Currency;
            ExchangeRate = p.ExchangeRate;
            Account = p.Account;
            SecurityLevel = p.SecurityLevel;
            Note = p.Note;
            Editor = p.Editor;
            this.Type = p.Type;
            Actions = p.Actions;
        }
    }
}
