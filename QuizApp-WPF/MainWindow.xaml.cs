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
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuizApp_WPF.FileManager;
using QuizApp_WPF.Views;

namespace QuizApp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FileManager.FileManager _fileManager;
        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            _fileManager = new FileManager.FileManager();

            _ =InitializeQuizzes();
            InitializeComponent();
        }

        public async Task InitializeQuizzes()
        {
            await _fileManager.LoadQuizzesAsync();
        }

        private void PlayView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new PlayView();
            WelcomeText.Visibility = Visibility.Hidden;
        }

        private void EditView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new EditView();
            WelcomeText.Visibility = Visibility.Hidden;
        }

        private void AddView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new AddView();
            WelcomeText.Visibility = Visibility.Hidden;
        }
    }
}
