using System.Linq;
using System.Threading.Tasks;
using models;
using modules.Helpers;
using Prism.Commands;
using Prism.Modularity;
using Prism.Navigation;

namespace modules.ViewModels
{
    /// <summary>
    /// Login page view model.
    /// </summary>
    public class LoginPageViewModel : BaseViewModel
    {
        /// <summary>
        /// The module manager.
        /// </summary>
        private readonly IModuleManager _moduleManager;

        /// <summary>
        /// The navigation service.
        /// </summary>
        private readonly INavigationService _navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.ViewModels.LoginPageViewModel"/> class.
        /// </summary>
        /// <param name="moduleManager">Module manager.</param>
        /// <param name="navigationService">Navigation service.</param>
        public LoginPageViewModel(IModuleManager moduleManager, INavigationService navigationService)
        {
            if (Properties != null && Properties.Any())
                Properties.Clear();

            _moduleManager = moduleManager;
            _navigationService = navigationService;

            ConfirmLoginCommand = new DelegateCommand(ConfirmUser, LoginCommandCanExecute)
                                                        .ObservesProperty(() => UserLogin)
                                                        .ObservesProperty(() => UserPassword);
        }

        /// <summary>
        /// Loads the premium module module.
        /// </summary>
        private async void LoadPremiumModuleModule()
        {
            _moduleManager.LoadModule(Constants.PremiumModuleName);
            await SavePropertiesAsync();
        }

        /// <summary>
        /// Gets the navigate to dashboard page.
        /// </summary>
        /// <value>The navigate to dashboard page.</value>
        public DelegateCommand ConfirmLoginCommand { get; }

        /// <summary>
        /// Logins the command can execute.
        /// </summary>
        /// <returns><c>true</c>, if command can execute was logined, <c>false</c> otherwise.</returns>
        bool LoginCommandCanExecute() =>
            !string.IsNullOrWhiteSpace(UserLogin) && !string.IsNullOrWhiteSpace(UserPassword);

        /// <summary>
        /// The user login.
        /// </summary>
        private string userLogin;
        public string UserLogin
        {
            get { return userLogin; }
            set { SetProperty(ref userLogin, value); }
        }

        /// <summary>
        /// The user password.
        /// </summary>
        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set { SetProperty(ref userPassword, value); }
        }

        /// <summary>
        /// Confirms the user.
        /// </summary>
        private void ConfirmUser()
        {
            if (IsUserPremiumLogged())
                LoadPremiumModuleModule();

            UserConfirmed();
        }

        /// <summary>
        /// Users the confirmed.
        /// </summary>
        private async void UserConfirmed() => await _navigationService.NavigateAsync($"app:///NavigationPage/{Constants.DashboardPage}");

        /// <summary>
        /// Is the user premium logged.
        /// </summary>
        /// <returns><c>true</c>, if user premium logged was ised, <c>false</c> otherwise.</returns>
        private bool IsUserPremiumLogged() => UserLogin == "admin" && UserPassword == "P@ssword!";

        /// <summary>
        /// Saves the properties async.
        /// </summary>
        /// <returns>The properties async.</returns>
        public override async Task SavePropertiesAsync()
        {
            ModulesHelper.LoadPremiumModule();
        }
    }
}