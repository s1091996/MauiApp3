namespace MauiApp3;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string Name, string Image, string Description)
	{
		InitializeComponent();
		showName.Text = Name;
		showDescription.Text = Description;
		showImage.Source = Image;
	}
}