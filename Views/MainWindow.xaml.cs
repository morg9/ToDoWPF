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
using ToDoApplication.Models;
using ToDoApplication.ViewModels;
using Task = ToDoApplication.Models.Task;

namespace ToDoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TaskListView.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var task = (Task)obj;
            return task.Title.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
        private void CompleteToggle_Checked(object sender, EventArgs e)
        {
            FilterTextBox.Clear();
            TaskListView.Items.Filter = ShowIncompleteMethod;
        }

        private bool ShowIncompleteMethod(object obj)
        {
            var task = (Task)obj;
            return task.Status.Equals(false);
        }

        private void CompeteToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            TaskListView.Items.Filter = null;
        }
    }
}