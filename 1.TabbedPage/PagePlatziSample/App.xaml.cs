namespace PagePlatziSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.Pages.TabbedPageSample.TabbedPageSample();
	}
}

