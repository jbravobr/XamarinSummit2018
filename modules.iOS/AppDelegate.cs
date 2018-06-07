using FFImageLoading.Forms.Platform;
using Foundation;
using Prism;
using Prism.Ioc;
using SuaveControls.MaterialForms.iOS;
using Syncfusion.SfBusyIndicator.XForms.iOS;
using UIKit;

namespace modules.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            UINavBarPreferences.SetTitlePrerences();
            CachedImageRenderer.Init();
            RendererInitializer.Init();

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(new iOSInitializer()));
            Syncfusion.SfChart.XForms.iOS.Renderers.SfChartRenderer.Init();
            new SfBusyIndicatorRenderer();

            return base.FinishedLaunching(app, options);
        }

        public class iOSInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry containerRegistry)
            {
            }
        }
    }

    public static class UINavBarPreferences
    {
        public static void SetTitlePrerences()
        {
            var att = new UITextAttributes
            {
                Font = UIFont.FromName("Poppins-Light", 24),
                TextColor = UIColor.White
            };
            UINavigationBar.Appearance.SetTitleTextAttributes(att);
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(174, 0, 1);
        }
    }
}