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
        private void TriggerNewBranchAddedEvent(Branch b)
        {
            NewBranchAddedEventArgs e = new NewBranchAddedEventArgs(b);
            NewBranchAdded?.Invoke(this, e);
        }

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
            Branch b = new Branch();
            b.Name = BranchName;
            b.MainCurrency = SelectedCurrency;
            ValidationMessage vm =  DataProvider.ValidateNewBranch(b);
            if(!vm.BoolianEquivalent)
            {
                switch(vm.Text)
                {
                    case "Branch name is empty":
                        PopUpMessageView.ShowMessage("ملاحظة", "لقد أبقيت خانة الاسم فارغة، يجب إدخال اسم الفرع الجديد لكي تتم عملية الإضافة", "", PopUpMessageType.Note);
                        break;
                    case "Already exists":
                        PopUpMessageView.ShowMessage("خطأ", "لم تتم إضافة الفرع الجديد بسبب وجود فرع آخر بنفس الاسم مسبقا", "أدخل اسماً مميزاً للفرع الجديد لكي لا يكون هناك تشابها في الأسماء", PopUpMessageType.Error);
                        break;
                    default:
                        PopUpMessageView.ShowMessage("خطأ", "لم تتم إضافة الفرع الجديد لحدوث خطأ غير معلوم", "تواصل مع المطور للحصول على حل للمشكلة", PopUpMessageType.Error);
                        break;
                }
            }
            else
            {
                vm= DataProvider.AddNewBranch(b);
                if(vm.BoolianEquivalent)
                {
                    TriggerNewBranchAddedEvent(b);
                    PopUpMessageView.ShowMessage("نجاح", "تمت إضافة الفرع الجديد بنجاح","اسم الفرع: "+b.Name+"\n"+"العملة الرئيسية: "+b.MainCurrency.Name, PopUpMessageType.Success);
                }
            }
        }
    }
}
