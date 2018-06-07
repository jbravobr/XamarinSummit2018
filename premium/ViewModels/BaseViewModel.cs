using Prism.Mvvm;
using Prism.Navigation;

namespace premium.ViewModels
{
    /// <summary>
    /// Base view model.
    /// </summary>
    public class BaseViewModel : BindableBase, INavigationAware
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.ViewModels.BaseViewModel"/> class.
        /// </summary>
        public BaseViewModel()
        {
        }

        /// <summary>
        /// Ons the navigated from.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        /// <summary>
        /// Ons the navigated to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        /// <summary>
        /// Ons the navigating to.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}