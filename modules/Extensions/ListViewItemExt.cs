using Syncfusion.ListView.XForms;
using Xamarin.Forms;

namespace modules.Extensions
{
    /// <summary>
    /// List view item ext.
    /// </summary>
    public class ListViewItemExt : ListViewItem
    {
        /// <summary>
        /// The list view.
        /// </summary>
        private SfListView listView;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.Extensions.ListViewItemExt"/> class.
        /// </summary>
        /// <param name="listView">List view.</param>
        public ListViewItemExt(SfListView listView)
        {
            this.listView = listView;
        }

        /// <summary>
        /// Ons the item appearing.
        /// </summary>
        protected override void OnItemAppearing()
        {
            this.Opacity = 0;
            this.FadeTo(1, 400, Easing.SinInOut);
            base.OnItemAppearing();
        }
    }
}