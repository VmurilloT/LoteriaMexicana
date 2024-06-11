using CommunityToolkit.Mvvm.Messaging;

namespace LoteriaKawai.Views;

public partial class CardSelectedPage : ContentPage
{
	internal ViewModels.CardSelectedViewModel vm { get; set; }
	public CardSelectedPage()
	{
		InitializeComponent();
		this.BindingContext = vm = new ViewModels.CardSelectedViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		vm.CreateCard();

		WeakReferenceMessenger.Default.Register<WeakReferences.Winner>(this, async (s, e) =>
		{
			await DisplayAlert("Ganaste!", "BUENAS!", "Aceptar");
		});
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();

		WeakReferenceMessenger.Default.Unregister<WeakReferences.Winner>(this);
    }


}