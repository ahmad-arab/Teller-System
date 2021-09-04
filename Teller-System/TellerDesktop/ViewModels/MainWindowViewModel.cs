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
                    Tabs.Add(new TabItemViewModel("سند افتتاحي", new StartupVoucher()));
                    break;
            }
        }
    }
}
