using AppLibertadoresHAS.ViewModels;

namespace AppLibertadoresHAS.Views.Usuarios;

public partial class LocalizacaoView : ContentPage
{
	AlbumViewModel viewModel;
    public LocalizacaoView()
	{
		InitializeComponent();
        viewModel = new AlbumViewModel();
        viewModel.InicializarMapa();
        BindingContext = viewModel;
    }


}