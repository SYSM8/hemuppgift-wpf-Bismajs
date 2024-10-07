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
    /// Interaction logic for DockWindow.xaml
    /// </summary>
    public partial class DockWindow : Window
    {
        public DockWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                mainDock.Children.Remove(centerBtn);

                Image trophyImage = new Image
                {
                    Source = new BitmapImage(new Uri("TrophyImage.jpg", UriKind.Relative)),
                    Stretch = Stretch.Uniform
                };

                mainDock.Children.Add(trophyImage);
            }
        }
    }

