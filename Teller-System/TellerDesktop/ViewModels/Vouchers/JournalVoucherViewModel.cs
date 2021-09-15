using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TellerDesktop
{
    public class JournalVoucherViewModel:BaseViewModel
    {
        #region Properties
        public int CurrentVoucherIndex { get; set; }
        public Voucher CurrentVoucherOriginal { get; set; }
        public Voucher CurrentVoucherCurrent { get; set; }
        public ObservableCollection<Voucher> AllVouchers { get; set; }
        public ObservableCollection<Currency> Currencies { get; set; }

        public string VoucherNumber { get; set; }
        public DateTime VoucherDate { get; set; }
        public Currency SelectedCurrency { get; set; }
        public string ExchangeRate { get; set; }
        public string Editor { get; set; }
        public string Note { get; set; }
        public string Index { get; set; }

        public ObservableCollection<FinancialAction> Actions { get; set; }
        #endregion

        #region Commands
        public ICommand GoRightCommand { get; set; }
        public ICommand GoLeftCommand { get; set; }
        #endregion

        #region Connstructor
        public JournalVoucherViewModel()
        {
            Currencies = DataProvider.GetCurrencies();
            AllVouchers = DataProvider.GetJournalVouchers();

            if (AllVouchers.Count > 0)
            {
                CurrentVoucherIndex = AllVouchers.Count - 1;
                CurrentVoucherOriginal = AllVouchers[AllVouchers.Count - 1];
                CurrentVoucherCurrent = AllVouchers[AllVouchers.Count - 1];

                VoucherNumber = CurrentVoucherOriginal.Id.ToString();
                VoucherDate = CurrentVoucherOriginal.Date;
                SelectedCurrency = Currencies.FirstOrDefault(x => x.EqualsByName(CurrentVoucherOriginal.Currency));
                Editor = CurrentVoucherOriginal.Editor;
                Note = CurrentVoucherOriginal.Note;
                ExchangeRate = CurrentVoucherOriginal.ExchangeRate.ToString();

                Actions = CurrentVoucherOriginal.Actions;

                Index = (CurrentVoucherIndex + 1).ToString() + " / " + AllVouchers.Count.ToString();
            }

            GoRightCommand = new RelayCommand(OnGoRight);
            GoLeftCommand = new RelayCommand(OnGoLeft);
        }
        #endregion

        #region Methods
        public void OnGoRight(object param)
        {
            if (AllVouchers.Count > 0)
            {
                CurrentVoucherIndex--;
                if (CurrentVoucherIndex < 0) CurrentVoucherIndex = AllVouchers.Count - 1;

                VoucherNumber = AllVouchers[CurrentVoucherIndex].Id.ToString();
                VoucherDate = AllVouchers[CurrentVoucherIndex].Date;
                SelectedCurrency = Currencies.FirstOrDefault(x => x.EqualsByName(AllVouchers[CurrentVoucherIndex].Currency));
                Editor = AllVouchers[CurrentVoucherIndex].Editor;
                Note = AllVouchers[CurrentVoucherIndex].Note;
                ExchangeRate = AllVouchers[CurrentVoucherIndex].ExchangeRate.ToString();
                Actions = AllVouchers[CurrentVoucherIndex].Actions;

                CurrentVoucherOriginal = AllVouchers[CurrentVoucherIndex];
                CurrentVoucherCurrent = AllVouchers[CurrentVoucherIndex];

                Index = (CurrentVoucherIndex + 1).ToString() + " / " + AllVouchers.Count.ToString();
            }
        }
        public void OnGoLeft(object param)
        {
            if (AllVouchers.Count > 0)
            {
                CurrentVoucherIndex++;
                if (CurrentVoucherIndex >= AllVouchers.Count) CurrentVoucherIndex = 0;

                VoucherNumber = AllVouchers[CurrentVoucherIndex].Id.ToString();
                VoucherDate = AllVouchers[CurrentVoucherIndex].Date;
                SelectedCurrency = Currencies.FirstOrDefault(x => x.EqualsByName(AllVouchers[CurrentVoucherIndex].Currency));
                Editor = AllVouchers[CurrentVoucherIndex].Editor;
                Note = AllVouchers[CurrentVoucherIndex].Note;
                ExchangeRate = AllVouchers[CurrentVoucherIndex].ExchangeRate.ToString();
                Actions = AllVouchers[CurrentVoucherIndex].Actions;

                CurrentVoucherOriginal = AllVouchers[CurrentVoucherIndex];
                CurrentVoucherCurrent = AllVouchers[CurrentVoucherIndex];

                Index = (CurrentVoucherIndex + 1).ToString() + " / " + AllVouchers.Count.ToString();
            }
        }
        #endregion
    }
}
