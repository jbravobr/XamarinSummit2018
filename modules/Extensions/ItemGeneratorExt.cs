using Syncfusion.ListView.XForms;

namespace modules.Extensions
{
    /// <summary>
    /// Item generator ext.
    /// </summary>
    public class ItemGeneratorExt : ItemGenerator
    {
        /// <summary>
        /// The list view.
        /// </summary>
        public SfListView listView;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:modules.Extensions.ItemGeneratorExt"/> class.
        /// </summary>
        /// <param name="listView">List view.</param>
        public ItemGeneratorExt(SfListView listView) : base(listView)
        {
            this.listView = listView;
        }

        /// <summary>
        /// Ons the create list view item.
        /// </summary>
        /// <returns>The create list view item.</returns>
        /// <param name="itemIndex">Item index.</param>
        /// <param name="type">Type.</param>
        /// <param name="data">Data.</param>
        protected override ListViewItem OnCreateListViewItem(int itemIndex, ItemType type, object data = null)
        {
            if (type == ItemType.Record)
                return new ListViewItemExt(this.listView);

            return base.OnCreateListViewItem(itemIndex, type, data);
        }
    }
}