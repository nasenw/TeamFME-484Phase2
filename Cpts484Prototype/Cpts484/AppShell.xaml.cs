namespace Cpts484;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NavigationPage), typeof(NavigationPage));

	}
}
