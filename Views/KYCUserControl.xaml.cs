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

namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for KYCUserControl.xaml
    /// </summary>
    public partial class KYCUserControl : UserControl
    {
        public KYCUserControl()
        {
            InitializeComponent();
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Enter text here...")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black; // Change text color to black
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Enter text here...";
                textBox.Foreground = Brushes.Gray; // Change text color to gray
            }
        }
    }
}
