﻿using MySql.Data.MySqlClient;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bookclub_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Member> members;
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += (sender, args) =>
            {
                try
                {
                    members = Statisztika.Beolvasas();
                    memberDataGrid.ItemsSource = members;
                }
                catch
                {
                    this.Close();
                }
            };
        }
    }
}
