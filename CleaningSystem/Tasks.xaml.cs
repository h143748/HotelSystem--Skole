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
using System.Windows.Shapes;

namespace CleaningSystem
{
    /// <summary>
    /// Interaction logic for Tasks.xaml
    /// </summary>
    public partial class Tasks : Window
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void SignOut(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
