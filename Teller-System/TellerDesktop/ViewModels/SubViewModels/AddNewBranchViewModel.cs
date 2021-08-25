using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace TellerDesktop
{
    public class AddNewBranchViewModel:BaseViewModel
    {
        public ObservableCollection<Currency> Currencies { get; set; }

        public string BranchName { get; set; }
        public Currency SelectedCurrency { get; set; }

        public ICommand AcceptCommand { get; set; }

        public AddNewBranchViewModel()
        {
            Currencies = DataProvider.GetCurrencies();
            SelectedCurrency = Currencies.FirstOrDefault();

            AcceptCommand = new RelayCommand(new Action(Accept));
        }

        public void Accept()
        {
            MessageBox.Show("الاسم : " + BranchName + "\n" + "العملة : " + SelectedCurrency.Name);
        }
    }
}
