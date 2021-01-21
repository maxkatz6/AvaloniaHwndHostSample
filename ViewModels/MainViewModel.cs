namespace AvaloniaApplication.ViewModels
{
    using ReactiveUI;

    public class MainViewModel : ViewModelBase
    {
        private string _editingText;

        public string Greeting => "Welcome to Avalonia!";

        public string EditingText
        {
            get => _editingText;
            set => this.RaiseAndSetIfChanged(ref _editingText, value);
        }
    }
}
