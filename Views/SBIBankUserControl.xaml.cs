using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using BankingApp.Properties;
using System.Windows.Controls;
namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for SBIBankUserControl.xaml
    /// </summary>
    public partial class SBIBankUserControl
    {
        private static SBIBankUserControl Instance;
        public List<TabItemTemplate> _tabItems;
        public TabItemTemplate SelectedTab { get; set; }
        public SBIBankUserControl()
        {
            InitializeComponent();
            MainGrid.DataContext = this;
            InitializeTabControls();
            MainWindowTabs.ItemsSource = _tabItems;
            SelectedTab = SelectedTab ?? _tabItems.FirstOrDefault();
            MainWindowTabs.SelectionChanged += OnTabSelected;
        }

        private void OnTabSelected(object sender, SelectionChangedEventArgs e)
        {
        }

        private void InitializeTabControls()
        {
            _tabItems = new List<TabItemTemplate>
                {
                    new TabItemTemplate
                    {
                        TabTitle =new TabItemTitle{Title = Properties.Resources.LangKeyHome},
                        TabContent = new Lazy<System.Windows.Controls.UserControl>(HomeUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        TabContent = new Lazy<System.Windows.Controls.UserControl>(AccountOpeningUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        TabContent = new Lazy<System.Windows.Controls.UserControl>(AccountClosureUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        TabContent = new Lazy<System.Windows.Controls.UserControl>(KYCUserControl.GetSingletonInstance)
                    }
                };
        }

        public static SBIBankUserControl GetSingletonInstance()=>Instance ?? (Instance = new SBIBankUserControl());
    }
}
