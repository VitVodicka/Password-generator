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
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region rectangles
        private void mouseEnterBlue(object sender, MouseEventArgs e)
        {
            Bluerectangle.Width = 200;
            
        }

        private void RedMouseEnter(object sender, MouseEventArgs e)
        {
            RedRectangle.Width = 200;

        }
        #endregion

        #region buttons with lock on them
        private void BlueLockHoverOn(object sender, MouseEventArgs e)
        {
            blue_lock.Width = 275;
            blue_lock.Height = 352;
        }

        private void BlueLockHoverOff(object sender, MouseEventArgs e)
        {
            blue_lock.Width = 250;
            blue_lock.Height = 320;
        }

        private void RedLockHoverOn(object sender, MouseEventArgs e)
        {
            red_lock.Width = 275;
            red_lock.Height = 352;
        }

        private void RedLockHoverOff(object sender, MouseEventArgs e)
        {
            red_lock.Width = 250;
            red_lock.Height = 320;
        }
        #endregion


    }
}
