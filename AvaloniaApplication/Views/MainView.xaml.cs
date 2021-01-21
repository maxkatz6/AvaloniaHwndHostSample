namespace AvaloniaApplication.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    using AvaloniaApplication.ViewModels;

    public class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            if (Design.IsDesignMode)
            {
                DataContext = new MainViewModel
                {
                    EditingText = "Avalonia design mode"
                };
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
