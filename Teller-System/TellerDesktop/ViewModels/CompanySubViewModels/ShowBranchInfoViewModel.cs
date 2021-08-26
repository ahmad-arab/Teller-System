using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace TellerDesktop
{
    class ShowBranchInfoViewModel:BaseViewModel
    {
        public Branch TheBranch { get; set; }
        public string TheTitle { get; set; }
        public ObservableCollection<Currency> Currencies { get; set; }
        public Visibility ButtonsVisibility { get; set; }
        public ICommand CancelChangesCommand { get; set; }

        private string _currentName;
        public string CurrentName
        {
            get { return _currentName; }
            set 
            { 
                _currentName = value;
                if (CurrentCurrency != null)
                {
                    if (value != TheBranch.Name || !CurrentCurrency.EqualsByName(TheBranch.MainCurrency)) ButtonsVisibility = Visibility.Visible;
                    else ButtonsVisibility = Visibility.Hidden;
                }
            }
        }

        private Currency _currentCurrency;
        public Currency CurrentCurrency
        {
            get { return _currentCurrency; }
            set 
            {
                _currentCurrency = value;
                if (CurrentName != null)
                {
                    if (CurrentName != TheBranch.Name || !value.EqualsByName(TheBranch.MainCurrency)) ButtonsVisibility = Visibility.Visible;
                    else ButtonsVisibility = Visibility.Hidden;
                }
            }
        }

        public ShowBranchInfoViewModel(Branch b)
        {
            Currencies = DataProvider.GetCurrencies();
            TheBranch = b;
            CurrentName = TheBranch.Name;
            CurrentCurrency = Currencies.FirstOrDefault(x => x.EqualsByName(TheBranch.MainCurrency));
            ButtonsVisibility = Visibility.Hidden;
            TheTitle = "معلومات الفرع " + TheBranch.Name;
            CancelChangesCommand = new RelayCommand(new Action<object>(OnCancelChanges));
        }

        public void OnCancelChanges(object param)
        {
            CurrentName = TheBranch.Name;
            CurrentCurrency = Currencies.FirstOrDefault(x => x.EqualsByName(TheBranch.MainCurrency));
        }

    }
}
