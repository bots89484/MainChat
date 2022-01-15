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

namespace MainChat
{
    /// <summary>
    /// Interaction logic for DeltaUserLogin.xaml
    /// </summary>
    public partial class DeltaUserLogin : Window
    {
        public DeltaUserLogin()
        {
            InitializeComponent();
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            MainWindow objectMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objectMainWindow.Show();
       
        }
    }
}
