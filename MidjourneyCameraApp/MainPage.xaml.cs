﻿namespace MidjourneyCameraApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	}
}

