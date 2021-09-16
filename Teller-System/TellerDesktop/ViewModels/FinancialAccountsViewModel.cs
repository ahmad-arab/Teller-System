using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace TellerDesktop
{
    public class FinancialAccountsViewModel:BaseViewModel
    {
        #region Properties
        public UserControl ContentWindow { get; set; }
        public ObservableCollection<IFinancialAccountOwner> FinancialAccountOwners { get; set; }
        public ObservableCollection<IFinancialAccountOwner> ViewFinancialAccountOwners { get; set; }

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set 
            {
                _searchText = value;

                if (string.IsNullOrWhiteSpace(value))
                    ViewFinancialAccountOwners = FinancialAccountOwners;
                else
                    ViewFinancialAccountOwners = new ObservableCollection<IFinancialAccountOwner>(FinancialAccountOwners.Where(b => b.Name.Contains(value)));
            }
        }

        #endregion

        #region Constructor
        public FinancialAccountsViewModel()
        {
            FinancialAccountOwners = new ObservableCollection<IFinancialAccountOwner>();

            FinancialAccountOwners.AddRange(DataProvider.GetReps());
            FinancialAccountOwners.AddRange(DataProvider.GetPartners());
            FinancialAccountOwners.AddRange(DataProvider.GetCustomers());
            FinancialAccountOwners.AddRange(DataProvider.GetVaults());
            FinancialAccountOwners.AddRange(DataProvider.GetEmployees());

            ViewFinancialAccountOwners = FinancialAccountOwners;
        }
        #endregion
    }
}
