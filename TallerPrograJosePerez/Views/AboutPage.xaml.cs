namespace TallerPrograJosePerez.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Informaci�n", "Gracias por visitar mi p�gina querido profesor.", "Cerrar");
    }
}