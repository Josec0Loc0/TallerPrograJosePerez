namespace TallerPrograJosePerez.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Información", "Gracias por visitar mi página querido profesor.", "Cerrar");
    }
}