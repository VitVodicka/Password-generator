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
using System.Windows.Shapes;

namespace Password_generator
{
    /// <summary>
    /// Interakční logika pro PasswordGenerator.xaml
    /// </summary>
    public partial class PasswordGenerator : Window
    {
        Passwordgeneration ps = new Passwordgeneration();
        public PasswordGenerator()
        {
            InitializeComponent();
            DataContext = ps;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ps.Set();
        }
    }
}
