namespace MathGame.Maui;

public partial class PreviousGame : ContentPage
{
    public PreviousGame()
    {
        InitializeComponent();
        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }
    private void OnDelete(object sender, EventArgs e)
    {
        ImageButton button = (ImageButton)sender;
        App.GameRepository.Delete((int)button.BindingContext);
        gamesList.ItemsSource = App.GameRepository.GetAllGames();

    }
}