using MAUITestProject_MenuItem_.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MAUITestProject_MenuItem_;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		var vm = BindingContext as MainPageViewModel;
		if(vm != null)
		{
			vm.SwapIcon();
		}
	}
}

