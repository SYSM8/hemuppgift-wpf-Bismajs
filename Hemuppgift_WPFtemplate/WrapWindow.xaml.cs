using System;
using System.Collections;
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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WrapWindow.xaml
    /// </summary>
    public partial class WrapWindow : Window
    {
        public WrapWindow()
        {
            InitializeComponent();
        }
        private void ToHor(object sender, RoutedEventArgs e)
        {
            horBtn.IsChecked = true;
           stackE.Orientation = Orientation.Horizontal;
        }

        private void ToVer(object sender, RoutedEventArgs e)
        {
            verBtn.IsChecked = true;
            stackE.Orientation = Orientation.Vertical;
        }
    }
}
