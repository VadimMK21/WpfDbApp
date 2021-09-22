using System.Windows;


namespace WpfDbApp
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public User User { get; private set; }
        public View(User u)
        {
            InitializeComponent();
            User = u;
            this.DataContext = User;
        }
    }
}
