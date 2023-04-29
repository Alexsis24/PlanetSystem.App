namespace PlanetSystem.Views;

public partial class PlanetsPage : ContentPage
{
	public PlanetsPage()
	{
		InitializeComponent();
	}

	async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
	{

	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{

	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
		lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
	}

	async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
	}
}