using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NavigationMenu
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			

			MainPage = new MasterDetailPage()
			{
				Master = new MasterPage() { Title = "Main Page" },
				Detail = new NavigationPage(new PageOne())
			};

		}
	}
}
