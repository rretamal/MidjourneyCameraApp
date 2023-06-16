namespace MidjourneyCameraApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);

		frame.BackgroundColor = Color.FromRgba(0, 0, 0, 100);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	}
}

