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
using System.Windows.Shapes;

namespace TellerDesktop
{
    /// <summary>
    /// Interaction logic for PopUpMessageView.xaml
    /// </summary>
    public partial class PopUpMessageView : Window
    {
        public PopUpMessageResponce Responce { get; set; }
        public PopUpMessageView(string title, string primaryMessage = "",string secondaryMessage = "", PopUpMessageType type = PopUpMessageType.Note )
        {
            InitializeComponent();

            TheTitle.Text = title;
            PrimaryMessage.Text = primaryMessage;
            SecondaryMessage.Text = secondaryMessage;

            if (string.IsNullOrWhiteSpace(secondaryMessage))
            {
                SecondaryMessageBox.Margin = new Thickness(0);
                SecondaryMessageBox.Height = 0;
            }

            switch (type)
            {
                case PopUpMessageType.Error:
                    YesButton.Visibility = Visibility.Hidden;
                    YesButton.Width = 0;
                    YesButton.Margin = new Thickness(0);
                    NoButton.Visibility = Visibility.Hidden;
                    NoButton.Width = 0;
                    NoButton.Margin = new Thickness(0);
                    TheImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/Error.png"));
                    break;
                case PopUpMessageType.Note:
                    YesButton.Visibility = Visibility.Hidden;
                    YesButton.Width = 0;
                    YesButton.Margin = new Thickness(0);
                    NoButton.Visibility = Visibility.Hidden;
                    NoButton.Width = 0;
                    NoButton.Margin = new Thickness(0);
                    TheImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/Notification.png"));
                    break;
                case PopUpMessageType.Question:
                    OkButton.Visibility = Visibility.Hidden;
                    OkButton.Width = 0;
                    OkButton.Margin = new Thickness(0);
                    TheImage.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/Question.png"));
                    break;
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Responce = PopUpMessageResponce.Ok;
            Close();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Responce = PopUpMessageResponce.Yes;
            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Responce = PopUpMessageResponce.No;
            Close();
        }

        public static PopUpMessageResponce ShowMessage(string title, string primaryMessage = "", string secondaryMessage = "", PopUpMessageType type = PopUpMessageType.Note)
        {
            PopUpMessageView m = new PopUpMessageView(title, primaryMessage, secondaryMessage, type);
            m.ShowDialog();
            return m.Responce;
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            this.DragMove();
        }
    }
}
