using System;
using Prism.DryIoc;
using Prism.Modularity;
using Prism.Ioc;
using Prism;
using modules.Views;
using models;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace modules
{
    /// <summary>
    /// App.
    /// </summary>
    public partial class App : PrismApplication
    {
        /// <summary>
        /// Ons the initialized.
        /// </summary>
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(Constants.LoginPage);
        }

        /// <summary>
        /// Registers the types.
        /// </summary>
        /// <param name="containerRegistry">Container registry.</param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<DashboardPage>();
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterInstance(UserDialogs.Instance);
        }

        /// <summary>
        /// Configures the module catalog.
        /// </summary>
        /// <param name="moduleCatalog">Module catalog.</param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            Type premiumModuleType = typeof(premium.PremiumModule);

            moduleCatalog.AddModule(
                new ModuleInfo(premiumModuleType)
                {
                    ModuleName = premiumModuleType.Name,
                    InitializationMode = InitializationMode.OnDemand
                });
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.App"/> class.
        /// </summary>
        public App() { InitializeComponent(); }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.App"/> class.
        /// </summary>
        /// <param name="initializer">Initializer.</param>
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        /// <summary>
        /// Ons the start.
        /// </summary>
        protected override void OnStart()
        {

        }

        /// <summary>
        /// Ons the sleep.
        /// </summary>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// Ons the resume.
        /// </summary>
        protected override void OnResume()
        {
        }
    }
}