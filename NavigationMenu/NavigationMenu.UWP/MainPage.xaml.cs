namespace NavigationMenu.UWP
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			this.InitializeComponent();
			LoadApplication(new NavigationMenu.App());
		}
	}
}