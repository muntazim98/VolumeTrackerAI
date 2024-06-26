﻿using System;
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
    /// Interaction logic for AccountClosureUserControl.xaml
    /// </summary>
    public partial class AccountClosureUserControl 
    {
        private static AccountClosureUserControl Instance;
        public AccountClosureUserControl()
        {
            InitializeComponent();
        }
        public static AccountClosureUserControl GetSingletonInstance() => Instance ?? (Instance = new AccountClosureUserControl());
    }
}
