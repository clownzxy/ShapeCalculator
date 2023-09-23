namespace PenasLab3.Page;
using Microsoft.Maui.Controls.Hosting;


public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    private void TringleClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Triangle());

    }
}