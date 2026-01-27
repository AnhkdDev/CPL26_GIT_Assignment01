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

namespace Assignment1_wpf
{
    /// <summary>
    /// Interaction logic for WindowOfPhuc.xaml
    /// </summary>
    public partial class WindowOfPhuc : Window
    {
        public WindowOfPhuc()
        {
            InitializeComponent();
        }
        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("xin chào");
        }
    }
}
