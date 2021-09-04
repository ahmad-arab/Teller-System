using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace TellerDesktop
{
    public class MainMenuPopuoViewModel: BaseViewModel
    {
        public event EventHandler<MainMenuButtonClickedEventArgs> OnMainMenuButtonClicked;
        private void InvokeMainMenuButtonClickedEvent(string name)
        {
            MainMenuButtonClickedEventArgs e = new MainMenuButtonClickedEventArgs();
            e.Name = name;
            OnMainMenuButtonClicked?.Invoke(this, e);
        }

        public ICommand MainMenuCommand { get; set; }
        public ICommand CompanyCommand { get; set; }
        public ICommand AccountsCommand { get; set; }
        public ICommand VouchersCommand { get; set; }
        public ICommand NoteBookCommand { get; set; }
        public ICommand ExchangeRateCommand { get; set; }
        public ICommand StartupVoucherCommand { get; set; }
        public ICommand JournalVoucherCommand { get; set; }
        public ICommand PaymentVoucherCommand { get; set; }
        public ICommand CashVoucherCommand { get; set; }
        public ICommand ExpendingVoucherCommand { get; set; }
        public ICommand SellCurrencyVoucherCommand { get; set; }
        public ICommand BuyCurrencyVoucherCommand { get; set; }

        public Visibility GridVisiblity { get; set; }
        public Visibility VouchersGridVisibility { get; set; }

        public MainMenuPopuoViewModel()
        {
            GridVisiblity = Visibility.Hidden;
            VouchersGridVisibility = Visibility.Hidden;

            MainMenuCommand = new RelayCommand(MainMenuButtonClicked);
            CompanyCommand = new RelayCommand(OnCompanyButtonClicked);
            AccountsCommand = new RelayCommand(OnAccountsButtonClicked);
            VouchersCommand = new RelayCommand(OnVouchersButtonClicked);
            NoteBookCommand = new RelayCommand(OnNoteBookButtonClicked);
            ExchangeRateCommand = new RelayCommand(OnExchangeRateButtonClicked);
            StartupVoucherCommand = new RelayCommand(OnStartupVoucherButtonClicked);
            JournalVoucherCommand = new RelayCommand(OnJournalVoucherButtonClicked);
            PaymentVoucherCommand = new RelayCommand(OnPaymentVoucherButtonClicked);
            CashVoucherCommand = new RelayCommand(OnCashVoucherButtonClicked);
            ExpendingVoucherCommand = new RelayCommand(OnExpendingVoucherButtonClicked);
            SellCurrencyVoucherCommand = new RelayCommand(OnSellCurrencyVoucherButtonClicked);
            BuyCurrencyVoucherCommand = new RelayCommand(OnBuyCurrencyVoucherButtonClicked);
        }

        public void MainMenuButtonClicked(object param)
        {
            HideSubMenus();
            GridVisiblity = (GridVisiblity == Visibility.Visible) ? Visibility.Hidden : Visibility.Visible;
        }
        public void OnCompanyButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("Company");
        }
        public void OnAccountsButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("Accounts");
        }
        public void OnVouchersButtonClicked(object param)
        {
            HideSubMenus();
            VouchersGridVisibility = Visibility.Visible;
        }
        public void OnStartupVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("StartupVoucher");
        }
        public void OnJournalVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("JournalVoucher");
        }
        public void OnPaymentVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("PaymentVoucher");
        }
        public void OnCashVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("CashVoucher");
        }
        public void OnExpendingVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("ExpendingVoucher");
        }
        public void OnSellCurrencyVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("SellCurrencyVoucher");
        }
        public void OnBuyCurrencyVoucherButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("BuyCurrencyVoucher");
        }
        public void OnNoteBookButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("NoteBook");
        }
        public void OnExchangeRateButtonClicked(object param)
        {
            InvokeMainMenuButtonClickedEvent("ExchangeRate");
        }
        public void HideSubMenus()
        {
            VouchersGridVisibility = Visibility.Hidden;
        }

    }
}
