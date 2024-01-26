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

namespace JKLJ
{
    /// <summary>
    /// Logika interakcji dla klasy Bookmarks_page.xaml
    /// </summary>
    public partial class Bookmarks_page : Window
    {
        public Bookmarks_page(Book oldbook)
        {
            InitializeComponent();
            Listview_bookmark.ItemsSource = oldbook.Bookmarks;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bookmark added = new Bookmark(int.Parse(Page_add.Text), Description.Text);
            (DataContext as Book).AddBookmark(added);
            Listview_bookmark.ItemsSource = (DataContext as Book).Bookmarks;
        }

        private void Listview_bookmark_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Bookmark m = Listview_bookmark.SelectedItem as Bookmark;
            string message = "Opis: " + m.Description;
            MessageBox.Show(message);
        }
    }
}
