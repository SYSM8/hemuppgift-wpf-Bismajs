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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void ApplyColour(object sender, RoutedEventArgs e)
        {
            int row = Convert.ToInt32(rowTxt.Text);
            int column = Convert.ToInt32(colTxt.Text);
  
            if (row == 0 && column == 0)
                {
                    rec1.Visibility = Visibility.Visible;
                    rec2.Visibility = Visibility.Collapsed;
                }
                else if (row == 2 && column == 2)
                {
                    rec2.Visibility = Visibility.Visible;
                    rec1.Visibility = Visibility.Collapsed;
                } else
            {
                MessageBox.Show("Please write either 0,0 or 2,2");
            }
            
           
        }

      

       
    }
}
