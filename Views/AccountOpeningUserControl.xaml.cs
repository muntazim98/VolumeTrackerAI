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
    /// Interaction logic for AccountOpeningUserControl.xaml
    /// </summary>
    public partial class AccountOpeningUserControl 
    {
        private static AccountOpeningUserControl Instance;
        public AccountOpeningUserControl()
        {
            InitializeComponent();
        }
        public static AccountOpeningUserControl GetSingletonInstance() => Instance ?? (Instance = new AccountOpeningUserControl());
    }
}
