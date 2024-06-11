using CommunityToolkit.Mvvm.Messaging;

namespace LoteriaKawai;

public partial class MainPage : ContentPage
{
	ViewModels.MainViewModel vm;

    public MainPage()
	{
		InitializeComponent();
		this.BindingContext = vm = new ViewModels.MainViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        WeakReferenceMessenger.Default.Register<WeakReferences.Cards>(this, async (m, e) => {
            Views.CardSelectedPage selectedCard = new Views.CardSelectedPage();
            selectedCard.vm.Data = e.Data;
            await this.Navigation.PushAsync(selectedCard, true);
        });
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        WeakReferenceMessenger.Default.Unregister<WeakReferences.Cards>(this);
    }
    
}

