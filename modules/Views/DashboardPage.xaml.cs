using modules.Extensions;
using Xamarin.Forms;

namespace modules.Views
{
    public partial class DashboardPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.Views.DashboardPage"/> class.
        /// </summary>
        public DashboardPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.listView.ItemGenerator = new ItemGeneratorExt(this.listView);
        }
    }
}