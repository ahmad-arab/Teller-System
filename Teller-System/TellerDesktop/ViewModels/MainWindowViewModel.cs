using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace TellerDesktop
{
    public class MainWindowViewModel:BaseViewModel
    {
        public ObservableCollection<TabItemViewModel> Tabs { get; set; }
        public MainMenuPopuoViewModel MainMenuDataContext { get; set; }
        public ICommand MainMenuButtonClickedCommand;

        public MainWindowViewModel()
        {
            AppInitiator.InitiateApp();

            Tabs = new ObservableCollection<TabItemViewModel>();
            MainMenuDataContext = new MainMenuPopuoViewModel();
            MainMenuDataContext.OnMainMenuButtonClicked+= MainMenuButtonClicked;            
        }

        private void MainMenuButtonClicked(object sender, MainMenuButtonClickedEventArgs e)
        {
            switch(e.Name)
            {
                case "Company":
                    Tabs.Add(new TabItemViewModel("الشركة", new CompanyInfoView()));
                    break;
                case "StartupVoucher":
                    Tabs.Add(new TabItemViewModel("سند افتتاحي", new StartupVoucherView()));
                    break;
                case "JournalVoucher":
                    JournalVoucherView jvv = new JournalVoucherView();
                    jvv.DataContext = new JournalVoucherViewModel();
                    Tabs.Add(new TabItemViewModel("سند قيد",jvv));
                    break;
                case "PaymentVoucher":
                    Tabs.Add(new TabItemViewModel("سند دفع", new PaymentVoucherView()));
                    break;
                case "CashVoucher":
                    Tabs.Add(new TabItemViewModel("سند قبض", new CashVoucherView()));
                    break;
                case "ExpendingVoucher":
                    Tabs.Add(new TabItemViewModel("أمر صرف", new ExpendingVoucherView()));
                    break;
                case "Accounts":
                    FinancialAccountsView fav = new FinancialAccountsView();
                    fav.DataContext = new FinancialAccountsViewModel();
                    Tabs.Add(new TabItemViewModel("الحسابات المالية", fav));
                    break;
                case "Transaction":
                    TransactionsView tv = new TransactionsView();
                    tv.DataContext = new TransactionsViewModel();
                    Tabs.Add(new TabItemViewModel("الحوالات", tv));
                    break;
            }
        }
    }
}
