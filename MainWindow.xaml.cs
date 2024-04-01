using BankingApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Tab1_Click(object sender, RoutedEventArgs e)
        {
            LoadUserControl(new HomeUserControl()); // Replace UserControl1 with your UserControl
        }

        private void Tab2_Click(object sender, RoutedEventArgs e)
        {
            LoadUserControl(new AccountOpeningUserControl()); // Replace UserControl2 with your UserControl
        }

        private void Tab3_Click(object sender, RoutedEventArgs e)
        {
            LoadUserControl(new KYCUserControl()); // Replace UserControl3 with your UserControl
        }

        private void Tab4_Click(object sender, RoutedEventArgs e)
        {
            LoadUserControl(new AccountClosureUserControl()); // Replace UserControl4 with your UserControl
        }

        private void LoadUserControl(UserControl userControl)
        {
            contentControl.Content = userControl;
        }
    }
}
