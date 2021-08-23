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
        public ICommand MainMenuButtonClickedCommand;

        private string _MainMenuClickedButton;

        public string MainMenuClickedButton
        {
            get { return _MainMenuClickedButton; }
            set 
            {
                _MainMenuClickedButton = value;
                MainMenuButtonClicked(value);
            }
        }


        public MainWindowViewModel()
        {
            Tabs = new ObservableCollection<TabItemViewModel>();
            //MainMenuButtonClickedCommand = new RelayCommand();
        }

        private void MainMenuButtonClicked(string name)
        {
            Tabs.Add(new TabItemViewModel(name,new CompanyInfoView()));
        }
    }
}
