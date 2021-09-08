using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TellerDesktop
{
    public class StartupVoucherViewModel: BaseViewModel
    {
        public Voucher OriginalVoucher { get; set; }
        public Voucher CurrenctVoucher { get; set; }
        public ObservableCollection<Currency> Currencies { get; set; }

        public int VoucherNumber { get; set; }
        public DateTime VoucherDate { get; set; }
        public Currency SelectedCurrency { get; set; }

        private decimal _exchageRate;
        public string ExchangeRate
        {
            get { return _exchageRate.ToString(); }
            set { _exchageRate = decimal.Parse(value); }
        }

        public string Editor { get; set; }
        public string Note { get; set; }

        public ObservableCollection<FinancialAction> Actions { get; set; }

        public StartupVoucherViewModel()
        {
            OriginalVoucher = DataProvider.GetStartupVoucher();
            Currencies = DataProvider.GetCurrencies();

        }
    }
}
