using models;

namespace modules.Helpers
{
    /// <summary>
    /// Modules helper.
    /// </summary>
    public static class ModulesHelper
    {
        /// <summary>
        /// Ises the premium module valid.
        /// </summary>
        /// <returns><c>true</c>, if premium module valid was ised, <c>false</c> otherwise.</returns>
        public static bool IsPremiumModuleValid() => Xamarin.Forms.Application.Current.Properties.ContainsKey(Constants.XamFormsPropertyPremiumModuleKey);

        /// <summary>
        /// Unloads the premium module.
        /// </summary>
        public static void UnloadPremiumModule() => Xamarin.Forms.Application.Current.Properties.Remove(Constants.XamFormsPropertyPremiumModuleKey);

        /// <summary>
        /// Loads the premium module.
        /// </summary>
        public static void LoadPremiumModule() => Xamarin.Forms.Application.Current.Properties.Add(Constants.XamFormsPropertyPremiumModuleKey, true);
    }
}