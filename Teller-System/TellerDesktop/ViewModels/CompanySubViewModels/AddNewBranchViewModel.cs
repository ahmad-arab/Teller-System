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
        public event EventHandler<NewBranchAddedEventArgs> NewBranchAdded;

        public ObservableCollection<Currency> Currencies { get; set; }

        public string BranchName { get; set; }
        public Currency SelectedCurrency { get; set; }

        public ICommand AcceptCommand { get; set; }

        public AddNewBranchViewModel()
        {
            Currencies = DataProvider.GetCurrencies();
            SelectedCurrency = Currencies.FirstOrDefault();

            AcceptCommand = new RelayCommand(new Action<object>(Accept));
        }

        public void Accept(object param)
        {
            PopUpMessageView.ShowMessage("تجربة", "تجربة للرسالة الرئيسية للللل لل صب كيهر صثعؤ خنهثب تنىؤثؤه تىهصثبه هىثب هىثب بهىهثبصثب هىهثصب هىقطصقب طججسيب لل ب بثث ",
                "تجربة للرسالة ال هخحصثب كمنيبح نتعهصثبد أسخيب نتلايخث ـؤسيثصب منيسبث رئيسيةبث  بثبثبننننننةصثب بثب بثث ", PopUpMessageType.Question);
        }
    }
}
