
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
                    OnShowBalance(value);
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

        private Rep _selectedRep;
        public Rep SelectedRep
        {
            get { return _selectedRep; }
            set 
            { 
                _selectedRep = value;
                if(value != null)
                    OnShowBalance(value);
            }
        }


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

        private Partner _selectedPartner;
        public Partner SelectedPartner
        {
            get { return _selectedPartner; }
            set 
            { 
                _selectedPartner = value;
                if (value != null) OnShowBalance(value);
            }
        }

        #endregion

        #region Vaults
        public ObservableCollection<Vault> Vaults { get; set; }

        private Vault _selectedVault;
        public Vault SelectedVault
        {
            get { return _selectedVault; }
            set 
            {
                _selectedVault = value;
                if (value != null) OnShowBalance(value);
            }
        }

        #endregion

        #region Currencies
        public ObservableCollection<Currency> Currencies { get; set; }
        public Currency SelectedCurrency { get; set; }
        #endregion

        #region Customers
        public ObservableCollection<Customer> AllCustomers { get; set; }
        public ObservableCollection<Customer> ShownCustomers { get; set; }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set 
            {
                _selectedCustomer = value;
                if (value != null) OnShowBalance(value);
            }
        }


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

        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set 
            { 
                _selectedEmployee = value;
                if (value != null) OnShowBalance(value);
            }
        }

        #endregion

        #region Content
        public UserControl Content { get; set; }
        #endregion

        #region Commands
        public ICommand AddNewBrnachCommand { get; }
        public ICommand ShowBranchInfoCommand { get;}
        public ICommand ShowBalanceCommand { get; set; }
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

            AddNewBrnachCommand = new RelayCommand(new Action<object>(OnAddNewBranchCLicked));
            ShowBranchInfoCommand = new RelayCommand(new Action<object>(OnShowBranchInfoCLicked));
            ShowBalanceCommand = new RelayCommand(new Action<object>(OnShowBalance));
        }
        #endregion

        #region Methods
        public void OnAddNewBranchCLicked(object param)
        {
            AddNewBranchViewModel anbvm = new AddNewBranchViewModel();
            anbvm.NewBranchAdded += OnNewBranchAdded;
            AddNewBranch anb = new AddNewBranch();
            anb.DataContext = anbvm;
            Content = anb;
        }
        public void OnShowBranchInfoCLicked(object param)
        {

            var c = new ShowBranchInfo();
            c.DataContext = new ShowBranchInfoViewModel((Branch)param);
            Content = c;
        }
        public void OnShowBalance(object param)
        {
            var c = new ShowBalance();
            IFinancialAccountOwner fa = (IFinancialAccountOwner)param;
            c.DataContext = new ShowBalanceViewModel(fa.FinancialAccount);
            Content = c;
        }
        #endregion

        #region Event Handlers
        private void OnNewBranchAdded(object sender, NewBranchAddedEventArgs e)
        {
            ShownBranches = AllBranches = DataProvider.GetBrnaches();
            SearchBranchText = "";
        }
        #endregion
    }
}
