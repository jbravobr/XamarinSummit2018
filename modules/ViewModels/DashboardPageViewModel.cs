using System;
using System.Collections.ObjectModel;
using Acr.UserDialogs;
using models;
using modules.Events;
using modules.Helpers;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;

namespace modules.ViewModels
{
    /// <summary>
    /// Dashboard page view model.
    /// </summary>
    public class DashboardPageViewModel : BaseViewModel
    {
        /// <summary>
        /// The navigation service.
        /// </summary>
        private readonly INavigationService _navigationService;

        /// <summary>
        /// The ea.
        /// </summary>
        private readonly IEventAggregator _ea;

        /// <summary>
        /// The user dialogs.
        /// </summary>
        private readonly IUserDialogs _userDialogs;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.ViewModels.DashboardPageViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">Navigation service.</param>
        public DashboardPageViewModel(INavigationService navigationService, IUserDialogs userDialogs, IEventAggregator ea)
        {
            _ea = ea;
            _navigationService = navigationService;
            _userDialogs = userDialogs;

            _ea.GetEvent<UserProfileDemotedEvent>().Subscribe(DemotedUser);

            // Exemplo de uma rotina que estaria em background avaliando
            // a demoção do usuário do perfil Premium.
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(10), () =>
                {
                    _ea.GetEvent<UserProfileDemotedEvent>().Publish();
                    return true;
                });
            });

            OpenCardCommand = new DelegateCommand<Menu>(NavigateTo);
            LoadMenus();
        }

        /// <summary>
        /// The is busy.
        /// </summary>
        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        /// <summary>
        /// Gets the open investments command.
        /// </summary>
        /// <value>The open investments command.</value>
        public DelegateCommand<Menu> OpenCardCommand { get; }

        /// <summary>
        /// Navigates to investiments page.
        /// </summary>
        /// <returns>The to investiments page.</returns>
        private Action<Menu> NavigateTo
        {
            get
            {
                return new Action<Menu>(async (menu) =>
                {
                    switch (menu.Name)
                    {
                        case Constants.MenuInvestiments:
                            await _navigationService.NavigateAsync(Constants.InvestimentPage);
                            break;

                        case Constants.MenuExit:
                            await _navigationService.NavigateAsync($"app:///{Constants.LoginPage}");
                            break;

                        default:
                            _userDialogs.Alert(Constants.FunctionNotAvailable, Constants.WarningMessageTitle, Constants.WarningMessageOKButtonTitle);
                            break;
                    }
                });
            }
        }

        /// <summary>
        /// Gets or sets the menus.
        /// </summary>
        /// <value>The menus.</value>
        private ObservableCollection<Menu> _menus;
        public ObservableCollection<Menu> Menus
        {
            get { return _menus; }
            set { SetProperty(ref _menus, value); }
        }

        /// <summary>
        /// Demoteds the user.
        /// </summary>
        private void DemotedUser()
        {
            if (!ModulesHelper.IsPremiumModuleValid())
                return;

            _userDialogs.ShowLoading("Usuário perdendo acesso Premium", MaskType.Gradient);

            Menus = new ObservableCollection<Menu>
                {
                    new Menu(Constants.MenuCheckingAccount,Constants.MenuIconCheckinAccout, true),
                    new Menu(Constants.MenuCreditCard,Constants.MenuIconCreditCard, true),
                    new Menu(Constants.MenuLoan,Constants.MenuIconLoan, true),
                    new Menu(Constants.MenuInvestiments,Constants.MenuIconReward,false),
                    new Menu(Constants.MenuReward,Constants.MenuIconReward,true),
                    new Menu(Constants.MenuExit, Constants.MenuIconExit,true),
                };

            // Removendo assinatura para o evento
            _ea.GetEvent<UserProfileDemotedEvent>().Unsubscribe(() => { });

            // Garantindo para a lógica total da aplicação o
            // descarregar do módulo Premium
            ModulesHelper.UnloadPremiumModule();

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(10), () =>
                {
                    _userDialogs.HideLoading();
                    return false;
                });
            });
        }

        /// <summary>
        /// Loads the menus.
        /// </summary>
        private void LoadMenus()
        {
            isBusy = true;

            if (ModulesHelper.IsPremiumModuleValid())
            {
                Menus = new ObservableCollection<Menu>
                {
                    new Menu(Constants.MenuCheckingAccount,Constants.MenuIconCheckinAccout, true),
                    new Menu(Constants.MenuCreditCard,Constants.MenuIconCreditCard, true),
                    new Menu(Constants.MenuLoan,Constants.MenuIconLoan, true),
                    new Menu(Constants.MenuInvestiments,Constants.MenuIconReward,true),
                    new Menu(Constants.MenuReward,Constants.MenuIconReward,true),
                    new Menu(Constants.MenuExit, Constants.MenuIconExit,true),
                };
            }
            else
            {
                Menus = new ObservableCollection<Menu>
                {
                    new Menu(Constants.MenuCheckingAccount,Constants.MenuIconCheckinAccout, true),
                    new Menu(Constants.MenuCreditCard,Constants.MenuIconCreditCard, true),
                    new Menu(Constants.MenuLoan,Constants.MenuIconLoan, true),
                    new Menu(Constants.MenuInvestiments,Constants.MenuIconReward,false),
                    new Menu(Constants.MenuReward,Constants.MenuIconReward,true),
                    new Menu(Constants.MenuExit, Constants.MenuIconExit,true),
                };
            }

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(5), () =>
                 {
                     IsBusy = false;
                     return false;
                 });
            });
        }
    }
}