using System;

namespace models
{
    /// <summary>
    /// User.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:models.User"/> is premium user.
        /// </summary>
        /// <value><c>true</c> if is premium user; otherwise, <c>false</c>.</value>
        public bool isPremiumUser { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:models.User"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="lastName">Last name.</param>
        /// <param name="password">Password.</param>
        /// <param name="isPremiumUser">If set to <c>true</c> is premium user.</param>
        public User(string name, string lastName, string password, bool isPremiumUser)
        {
            Name = name;
            LastName = lastName;
            Password = password;
            isPremiumUser = isPremiumUser;
        }
    }
}