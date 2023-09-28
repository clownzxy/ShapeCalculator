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

    private void SquareClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SquarePage());
    } 
    
    
    private void RectangleClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RectanglePage());
    }
    
    private void CircleCLicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CirclePage());
    }



    
}