namespace BedonCarrasco_UsoLayouts;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }

    void OnFinalButtonClicked(object sender, EventArgs e)
    {
        Scroll.ScrollToAsync(0, 5000, true);
    }
}

