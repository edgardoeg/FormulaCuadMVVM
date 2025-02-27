using FormulaCuadMVVM.ViewModels;

namespace FormulaCuadMVVM.Views;

public partial class FormulaCuadView : ContentPage
{
    FormulaCuadViewModel viewModel;

    public FormulaCuadView()
	{
		InitializeComponent();
		viewModel = new FormulaCuadViewModel();
		BindingContext = viewModel;
	}
}