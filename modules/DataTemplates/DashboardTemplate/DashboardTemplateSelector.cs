using modules.ViewModels;
using Xamarin.Forms;

namespace modules.DataTemplates.DashboardTemplate
{
    /// <summary>
    /// Dashboard template selector.
    /// </summary>
    public class DashboardTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:modules.DataTemplates.DashboardTemplate.DashboardTemplateSelector"/> class.
        /// </summary>
        public DashboardTemplateSelector()
        {
            EnabledTemplate = new DataTemplate(typeof(DashboardEnabledTemplate));
            DisabledTemplate = new DataTemplate(typeof(DashboardDisabledTemplate));
        }

        /// <summary>
        /// Gets or sets the enabled template.
        /// </summary>
        /// <value>The enabled template.</value>
        public DataTemplate EnabledTemplate { get; set; }

        /// <summary>
        /// Gets or sets the disabled template.
        /// </summary>
        /// <value>The disabled template.</value>
        public DataTemplate DisabledTemplate { get; set; }

        /// <summary>
        /// Ons the select template.
        /// </summary>
        /// <returns>The select template.</returns>
        /// <param name="item">Item.</param>
        /// <param name="container">Container.</param>
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var template = ((models.Menu)item).IsAvailable ? EnabledTemplate : DisabledTemplate;

            var bindingContext = container.BindingContext;
            var menu = item as models.Menu;
            if (bindingContext.GetType() == typeof(DashboardPageViewModel))
            {
                template.SetValue(BaseDataTemplate.ParentBindingContextProperty, container.BindingContext);
                template.SetValue(BaseDataTemplate.CommandParameterProperty, menu);
            }

            return template;
        }
    }
}