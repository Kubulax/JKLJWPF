﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JKLJ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //List_view.ItemsSource =
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            //Book del = (sender as Button) as Book;
            //List_view.ItemsSource =
        }

        private void Button_Bookmark(object sender, RoutedEventArgs e)
        {
            new Bookmarks_page().ShowDialog();
            //List_view.ItemsSource =
        }

        private void Button_AddBook(object sender, RoutedEventArgs e)
        {
            new Add_book_page().ShowDialog();
            //List_view.ItemsSource =
        }

        
    }
}