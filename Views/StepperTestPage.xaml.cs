using StepperBindingIncrement.ViewModels;

namespace StepperBindingIncrement.Views;

public partial class StepperTestPage : ContentPage
{
	public StepperTestPage(StepperTestPageViewModel viewModel)
	{
        BindingContext = viewModel;
        InitializeComponent();
	}
}