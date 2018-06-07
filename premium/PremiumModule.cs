using appservices.Services;
using premium.Contracts;
using premium.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace premium
{
    /// <summary>
    /// Premium module.
    /// </summary>
    public class PremiumModule : IModule
    {
        /// <summary>
        /// Ons the initialized.
        /// </summary>
        /// <param name="containerProvider">Container provider.</param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        /// <summary>
        /// Registers the types.
        /// </summary>
        /// <param name="containerRegistry">Container registry.</param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<InvestimentPage>();
            containerRegistry.Register(typeof(IBankOperationService), typeof(BankOperationService));
        }
    }
}