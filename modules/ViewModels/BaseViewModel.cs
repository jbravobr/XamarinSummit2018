using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace modules.ViewModels
{
    /// <summary>
    /// Base view model.
    /// </summary>
    public class BaseViewModel : BindableBase, INavigationAware, IApplicationStore
    {
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IDictionary<string, object> Properties => Xamarin.Forms.Application.Current.Properties;

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

        /// <summary>
        /// Saves the properties async.
        /// </summary>
        /// <returns>The properties async.</returns>
        public virtual async Task SavePropertiesAsync()
        {
        }
    }
}