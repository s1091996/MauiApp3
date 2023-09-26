namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        List<string>List = new List<string>() { "A" ,"p", "p","l","e"};

        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = List;
        }

     

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null) {
                return;
            }
            DisplayAlert("Selected",e.SelectedItem.ToString(),"OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}