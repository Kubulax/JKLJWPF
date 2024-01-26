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
    /// Logika interakcji dla klasy Add_bookmarks_page.xaml
    /// </summary>
    public partial class Add_bookmarks_page : Window
    {
        public Add_bookmarks_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bookmark added = new Bookmark();
            added.PageNumber = Page_add.Text;
            added.Descripton = Description_add.Text;
            this.Close();
        }
    }
}
