
using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;

namespace NavigationMenu.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
			ImageCircleRenderer.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
