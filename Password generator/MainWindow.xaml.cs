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

namespace Password_generator
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void red_lock_Click(object sender, RoutedEventArgs e)
        {
            PasswordInput r = new PasswordInput();
            r.Show();
           
                                    
        }

        private void blue_lock_Click(object sender, RoutedEventArgs e)
        {
            PasswordGenerator p = new PasswordGenerator();
            p.Show();
        }
    }
}
