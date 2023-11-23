namespace LukeMauiMarkup.Init.ViewModels
{
    public partial class MainViewModel(ISemanticScreenReader screenReader) : ObservableObject
    {
        private int _count = 0;

        [ObservableProperty] string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            _count++;
            CountText = $"Current count: {_count}";
            screenReader.Announce (CountText);
        }
    }
}
