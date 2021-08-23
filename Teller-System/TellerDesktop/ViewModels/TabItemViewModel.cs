using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace TellerDesktop
{
    public class TabItemViewModel: BaseViewModel
    {
        public string Title { get; set; }
        public UserControl TabContent { get; set; }

        public TabItemViewModel(string title,UserControl user)
        {
            TabContent = user;
            Title = title;
        }
    }
}
