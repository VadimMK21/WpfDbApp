using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

            //userGrid.IsReadOnly = true;

            db = new Context();
            db.Users.Load();
            userGrid.ItemsSource = db.Users.Local.ToBindingList();
        }


        //SelectionChanged="userGrid_SelectionChanged"


        //private void userGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //  
            //User dr = userGrid.SelectedItem as User;

            //if (dr.name != null)
            //{
            //    //View.tb_name.Text = dr.id.ToString();

            //    //MessageBox.Show(dg.Items.IndexOf(dg.SelectedItem).ToString());            
            //}

        //}

        private void userGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            User user = userGrid.SelectedItem as User;

            View view = new View(new User
            {
                id = user.id,
                name = user.name,
                adress = user.adress,
                phone = user.phone,

            });

            view.ShowDialog();
        }
        //private void btn_Del_Click(object sender, RoutedEventArgs e)
        //{
        //    if (userGrid.SelectedItems.Count > 0)
        //    {
        //        for (int i = 0; i < userGrid.SelectedItems.Count; i++)
        //        {
        //            User user = userGrid.SelectedItems[i] as User;
        //            if (user != null)
        //            {
        //                db.Users.Remove(user);
        //            }
        //        }
        //    }
        //    db.SaveChanges();
        //}
    }
}
