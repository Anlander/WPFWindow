using System.Windows;

namespace WPFMoreWindows
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToStart(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Start());
        }

        private void NavigateToAbout(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new About());

        }

        private void NavigateToInfo(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InformationPage());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Skicka namnet till showpage
            string Name = InputBox.Text;
            MainFrame.Navigate(new ShowPage(Name));

        }
    }
}