using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace WpfDbApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context db;
        public MainWindow()
        {
            InitializeComponent();

            userGrid.IsReadOnly = true;
            userGrid.AutoGenerateColumns = true;
            db = new Context();
            db.Users.Load();
            userGrid.ItemsSource = db.Users.Local.ToBindingList();
        }
    }
}
