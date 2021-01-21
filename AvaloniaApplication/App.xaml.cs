namespace AvaloniaApplication
{
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Controls.ApplicationLifetimes;
    using Avalonia.Markup.Xaml;

    using AvaloniaApplication.ViewModels;
    using AvaloniaApplication.Views;

    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new Window
                {
                    Content = new MainView
                    {
                        DataContext = new MainViewModel
                        {
                            EditingText = "Started without WPF"
                        }
                    }
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
