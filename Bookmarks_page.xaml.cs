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
        public Bookmarks_page()
        {
            InitializeComponent();
            //Listview_bookmark.ItemsSource =
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Add_bookmarks_page().ShowDialog();
            //Listview_bookmark.ItemsSource =
        }

        private void Listview_bookmark_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //string m = (sender as Label) as Bookmark;
            string message = "";
            MessageBox.Show(message);
        }
    }
}
