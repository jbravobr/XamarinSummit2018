namespace models
{
    public class Menu
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:models.Menus"/> is available.
        /// </summary>
        /// <value><c>true</c> if is available; otherwise, <c>false</c>.</value>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:models.Menus"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="icon">Icon.</param>
        /// <param name="isAvailable">If set to <c>true</c> is available.</param>
        public Menu(string name, string icon, bool isAvailable)
        {
            Name = name;
            Icon = icon;
            IsAvailable = isAvailable;
        }
    }
}