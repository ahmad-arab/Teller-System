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

namespace TellerDesktop.Controls
{
    /// <summary>
    /// Interaction logic for MainMenuPopup.xaml
    /// </summary>
    public partial class MainMenuPopup : UserControl
    {
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
