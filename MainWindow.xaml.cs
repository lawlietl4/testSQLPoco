using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using testSQLPoco.Data;

namespace testSQLPoco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly NeumontContext _context = new NeumontContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //checks if there are new things in the migration folder to be added to the DB
            _context.Database.Migrate();

            _context.Students.Load();
            studentsViewSource.Source = _context.Students.Local.ToObservableCollection();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            _context.Dispose();
            base.OnClosing(e);
        }
    }
}
