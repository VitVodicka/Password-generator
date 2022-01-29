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

namespace Password_generator
{
    /// <summary>
    /// Interakční logika pro password_generator.xaml
    /// </summary>
    public partial class password_generator : Page
    {
        Passwordgeneration ps = new Passwordgeneration();
        public password_generator()
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
