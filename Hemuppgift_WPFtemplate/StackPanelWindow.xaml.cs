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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for StackPanelWindow.xaml
    /// </summary>
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }
        private void ToHorizontal(object sender, RoutedEventArgs e)
        {
            horizontalBtn.IsChecked = true;
            Stack.Orientation = Orientation.Horizontal;
        }

        private void ToVertical(object sender, RoutedEventArgs e)
        {
            verticalBtn.IsChecked = true;
            Stack.Orientation = Orientation.Vertical;
        }
    }
}
