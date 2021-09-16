using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TellerDesktop
{
    public static class Extension
    {
        public static void AddRange(this ObservableCollection<IFinancialAccountOwner> Old, ObservableCollection<Rep> New)
        {
            if (Old == null) Old = new ObservableCollection<IFinancialAccountOwner>();
            if (New == null) return;
            foreach(IFinancialAccountOwner a in New)
            {
                Old.Add(a);
            }
        }
        public static void AddRange(this ObservableCollection<IFinancialAccountOwner> Old, ObservableCollection<Partner> New)
        {
            if (Old == null) Old = new ObservableCollection<IFinancialAccountOwner>();
            if (New == null) return;
            foreach (IFinancialAccountOwner a in New)
            {
                Old.Add(a);
            }
        }
        public static void AddRange(this ObservableCollection<IFinancialAccountOwner> Old, ObservableCollection<Customer> New)
        {
            if (Old == null) Old = new ObservableCollection<IFinancialAccountOwner>();
            if (New == null) return;
            foreach (IFinancialAccountOwner a in New)
            {
                Old.Add(a);
            }
        }
        public static void AddRange(this ObservableCollection<IFinancialAccountOwner> Old, ObservableCollection<Vault> New)
        {
            if (Old == null) Old = new ObservableCollection<IFinancialAccountOwner>();
            if (New == null) return;
            foreach (IFinancialAccountOwner a in New)
            {
                Old.Add(a);
            }
        }
        public static void AddRange(this ObservableCollection<IFinancialAccountOwner> Old, ObservableCollection<Employee> New)
        {
            if (Old == null) Old = new ObservableCollection<IFinancialAccountOwner>();
            if (New == null) return;
            foreach (IFinancialAccountOwner a in New)
            {
                Old.Add(a);
            }
        }
    }
}
