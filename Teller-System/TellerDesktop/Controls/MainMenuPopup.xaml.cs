using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TellerDesktop
{
    /// <summary>
    /// Interaction logic for MainMenuPopup.xaml
    /// </summary>
    public partial class MainMenuPopup : UserControl
    {
        public static readonly DependencyProperty ClickedButtonProperty = DependencyProperty.Register(
            "ClickedButton",
            typeof(string),
            typeof(MainMenuPopup),
            new PropertyMetadata(string.Empty, new PropertyChangedCallback(OnClickedButtonChanged)));

        public static void OnClickedButtonChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            MainMenuPopup mmp = sender as MainMenuPopup;

            if (mmp.ClickedButton != null)
            {
                mmp.ClickedButton = e.NewValue as string;
            }
        }

        public string ClickedButton
        {
            get { return GetValue(ClickedButtonProperty) as string; }
            set { SetValue(ClickedButtonProperty, value); }
        }
        public MainMenuPopup()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent ButtonClickedEvent =
        EventManager.RegisterRoutedEvent("ButtonClicked",
                     RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                     typeof(MainMenuPopup));

        public event RoutedEventHandler ButtonClicked
        {
            add { AddHandler(ButtonClickedEvent, value); }
            remove { RemoveHandler(ButtonClickedEvent, value); }
        }

        void RaiseButtonClickedEvent(string theClickedButton)
        {
            MainMenuButtonClickedEventArgs newEventArgs =
                    new MainMenuButtonClickedEventArgs(MainMenuPopup.ButtonClickedEvent, theClickedButton);
            RaiseEvent(newEventArgs);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonsList.Visibility = (ButtonsList.Visibility == Visibility.Visible) ? Visibility.Hidden : Visibility.Visible;
        }

        private void CompanyClicked(object sender, RoutedEventArgs e)
        {
            ClickedButton = "Company";
            //RaiseButtonClickedEvent("Company");
        }
        private void AccountsClicked(object sender, RoutedEventArgs e)
        {
            ClickedButton = "Accounts";
            //RaiseButtonClickedEvent("Accounts");
        }
        private void VouchersClicked(object sender, RoutedEventArgs e)
        {
            ClickedButton = "Vouchers";
            //RaiseButtonClickedEvent("Vouchers");
        }
        private void NotebookClicked(object sender, RoutedEventArgs e)
        {
            ClickedButton = "Notebook";
            //RaiseButtonClickedEvent("Notebook");
        }
        private void ExchangeRateCLicked(object sender, RoutedEventArgs e)
        {
            ClickedButton = "ExchangeRate";
            //RaiseButtonClickedEvent("ExchangeRate");
        }
    }
    public class MainMenuButtonClickedEventArgs: RoutedEventArgs
    {
        public string TheClickedButton { get; set; }
        public MainMenuButtonClickedEventArgs(RoutedEvent routedEvent,
                                      string theClickedButton)
        : base(routedEvent)
        {
            this.TheClickedButton = theClickedButton;
        }
    }
}
