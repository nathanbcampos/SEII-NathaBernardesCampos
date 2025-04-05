using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CalculadorApp;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string _expressionDisplay = string.Empty;

    [ObservableProperty]
    private string _resultDisplay = string.Empty;

    [RelayCommand]
    public void HandleButtonPress(string buttonText)
    {

    }
}