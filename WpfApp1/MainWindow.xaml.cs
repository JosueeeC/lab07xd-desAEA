﻿using System;
using System.Collections.Generic;
using System.Data;
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
using Servicio;

namespace WpfApp1
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

        private void btnFilter(object sender, RoutedEventArgs e)
        {

                BInvoice bInvoice = new BInvoice();
                var date = DateTime.Parse(txtFilterDate.Text);
                dataGrid.ItemsSource = bInvoice.GetByDate(date);
 

        }
    }
}
