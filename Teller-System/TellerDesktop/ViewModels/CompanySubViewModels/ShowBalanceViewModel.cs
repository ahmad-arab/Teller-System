using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TellerDesktop
{
    public class ShowBalanceViewModel: BaseViewModel
    {
        public string Title { get; set; }
        public FinancialAccount TheAccount { get; set; }
        public ObservableCollection<CurrencyBalance> Balances { get; set; }

        public ShowBalanceViewModel(FinancialAccount account)
        {
            TheAccount = account;
            Title = "رصيد الحساب : "+ account.Name;
            Balances = account.Balances;
        }
    }
}
