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

namespace JKLJ
{
    /// <summary>
    /// Logika interakcji dla klasy Add_book_page.xaml
    /// </summary>
    public partial class Add_book_page : Window
    {
        public Add_book_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Book newbook = new Book(Title_add.Text,Author_add.Text,Description_add.Text, Date_add.DisplayDate);
            DataBase.AddBook(newbook);
            this.Close();
        }
    }
}
