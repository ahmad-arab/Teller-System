
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TellerDesktop
{
    class CompanyViewModel : BaseViewModel
    {
        #region Branches
        public ObservableCollection<Branch> AllBranches { get; set; }
        public ObservableCollection<Branch> ShownBranches { get; set; }

        private Branch _selectedBranch;
        public Branch SelectedBranch
        {
            get { return _selectedBranch; }
            set
            {
                _selectedBranch = value;
                if (value != null)
                {
                    ShownReps = new ObservableCollection<Rep>(AllReps.Where(r => r.Branch.Name == value.Name));
                    SearchRepText = string.Empty;
                }
            }
        }

        private string _serchBranchText;
        public string SearchBranchText
        {
            get { return _serchBranchText; }
            set
            {
                _serchBranchText = value;
                if (string.IsNullOrWhiteSpace(value))
                    ShownBranches = AllBranches;
                else
                    ShownBranches = new ObservableCollection<Branch>(AllBranches.Where(b => b.Name.Contains(value)));
            }
        }

        #endregion

        #region Reps
        public ObservableCollection<Rep> AllReps { get; set; }
        public ObservableCollection<Rep> ShownReps { get; set; }
        public Rep SelectedRep { get; set; }

        private string _serchRepText;
        public string SearchRepText
        {
            get { return _serchRepText; }
            set
            {
                _serchRepText = value;
                if (string.IsNullOrWhiteSpace(value))
                    ShownReps = AllReps;
                else
                    ShownReps = new ObservableCollection<Rep>(AllReps.Where(b => b.Name.Contains(value)));
            }
        }
        #endregion

        #region Partners
        public ObservableCollection<Partner> Partners { get; set; }
        public Partner SelectedPartner { get; set; }
        #endregion

        #region Vaults
        public ObservableCollection<Vault> Vaults { get; set; }
        public Vault SelectedVault { get; set; }
        #endregion

        #region Currencies
        public ObservableCollection<Currency> Currencies { get; set; }
        public Currency SelectedCurrency { get; set; }
        #endregion

        #region Customers
        public ObservableCollection<Customer> AllCustomers { get; set; }
        public ObservableCollection<Customer> ShownCustomers { get; set; }
        public Customer SelectedCustomer { get; set; }

        private string _serchCustomerText;
        public string SearchCustomerText
        {
            get { return _serchCustomerText; }
            set
            {
                _serchCustomerText = value;
                if (string.IsNullOrWhiteSpace(value))
                    ShownCustomers = AllCustomers;
                else
                    ShownCustomers = new ObservableCollection<Customer>(AllCustomers.Where(b => b.Name.Contains(value)));
            }
        }
        #endregion

        #region Employees
        public ObservableCollection<Employee> Employees { get; set; }
        public Employee SelectedEmployee { get; set; }
        #endregion

        #region Content
        public UserControl Content { get; set; }
        #endregion

        #region Commands
        public ICommand AddNewBrnachCommand { get; set; }
        #endregion

        #region Constructor
        public CompanyViewModel()
        {
            ShownBranches = AllBranches = DataProvider.GetBrnaches();
            ShownReps = AllReps = DataProvider.GetReps();
            Partners = DataProvider.GetPartners();
            Vaults = DataProvider.GetVaults();
            Currencies = DataProvider.GetCurrencies();
            ShownCustomers = AllCustomers = DataProvider.GetCustomers();
            Employees = DataProvider.GetEmployees();

            AddNewBrnachCommand = new RelayCommand(new Action(OnAddNewBranchCLicked));
        }
        #endregion

        #region Methods
        public void OnAddNewBranchCLicked()
        {
            Content = new AddNewBranch();
        }
        #endregion
    }
}
