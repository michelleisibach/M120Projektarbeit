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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kinoplätzeverwaltungstool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ButtonName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            seatscreens sc = new seatscreens();
            sc.Show();
        }

        private void film1_Click(object sender, RoutedEventArgs e)
        {
            ButtonName = "film1";
            showDescription sD = new showDescription();
            sD.changeDescription(ButtonName);
            
        }
    }
}
