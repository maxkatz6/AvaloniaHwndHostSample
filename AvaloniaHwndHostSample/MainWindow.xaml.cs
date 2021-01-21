namespace AvaloniaHwndHostSample
{
    using AvaloniaApplication.ViewModels;
    using AvaloniaApplication.Views;

    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel()
            {
                EditingText = "Edit me"
            };

            AvaloniaHost.Content = new MainView();
        }
    }
}
