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

namespace Password_generator
{
    /// <summary>
    /// Interakční logika pro PasswordInput.xaml
    /// </summary>
    public partial class PasswordInput : Window
    {
        Passwordgeneration ps = new Passwordgeneration();
        public PasswordInput()
        {
            InitializeComponent();
            DataContext = ps;
            
        }

        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {
            tx.Text=ps.PassInput(input.Text);



        }
    }
}
