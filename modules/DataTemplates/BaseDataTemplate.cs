using Xamarin.Forms;

namespace modules.DataTemplates
{
    /// <summary>
    /// Base data template.
    /// </summary>
    public class BaseDataTemplate : ViewCell
    {
        /// <summary>
        /// The parent binding context property
        /// </summary>
        public static readonly BindableProperty ParentBindingContextProperty = BindableProperty.Create(
            propertyName: nameof(ParentBindingContext),
            returnType: typeof(object),
            declaringType: typeof(BaseDataTemplate),
            defaultValue: null);

        /// <summary>
        /// Gets or sets the parent binding context.
        /// </summary>
        /// <value>
        /// The parent binding context.
        /// </value>
        public object ParentBindingContext
        {
            get { return GetValue(ParentBindingContextProperty); }
            set { SetValue(ParentBindingContextProperty, value); }
        }

        /// <summary>
        /// The command parameter property
        /// </summary>
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
            propertyName: nameof(CommandParameter),
           returnType: typeof(object),
            declaringType: typeof(BaseDataTemplate),
           defaultValue: null);

        /// <summary>
        /// Gets or sets the command parameter.
        /// </summary>
        /// <value>
        /// The command parameter.
        /// </value>
        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }
    }
}