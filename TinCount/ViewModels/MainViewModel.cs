
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TinCount.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
       async Task Tap(string s)
    {
        await Shell.Current.GoToAsync(nameof(SignupPage));
    }
}