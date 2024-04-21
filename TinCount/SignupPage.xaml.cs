using TinCount.ViewModels;

namespace TinCount;

public partial class SignupPage : ContentPage
{
	public SignupPage(SignupViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}