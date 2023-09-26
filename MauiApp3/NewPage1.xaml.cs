namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
	public NewPage1(String userName)
	{
		InitializeComponent();
        b1UserName.Text = userName;

	}
    private void TapGestureRecognizer_Tapped(object sendar, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
    
}