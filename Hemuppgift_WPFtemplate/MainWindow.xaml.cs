using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToGrid(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void NavigateToStack(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();

        }

        private void NavigateToWrap(object sender, RoutedEventArgs e)
        {
            WrapWindow wrapWindow = new WrapWindow();
            wrapWindow.Show();
        }

        private void NavigateToDock(object sender, RoutedEventArgs e)
        {
            DockWindow dockWindow = new DockWindow();
            dockWindow.Show();
        }
    }
}