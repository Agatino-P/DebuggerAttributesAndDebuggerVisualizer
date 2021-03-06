﻿using PrototypeDebugVisualizer;
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
using System.Xml.Linq;

namespace DebuggerAttributes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            WannaInspect wi = new WannaInspect();
            IEnumerable<int> iei = wi.Numbers;
            int a = 12;

            var x = new XElement("Pippo", "pippo");
            string s = x.ToString();
            ProtoypeVisualizer.TestShowVisualizer(2);
        }
    }
}
