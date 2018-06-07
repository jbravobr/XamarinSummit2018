using System;
namespace models
{
    /// <summary>
    /// Post.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Gets or sets the identification.
        /// </summary>
        /// <value>The identification.</value>
        public string Identification { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:models.Post"/> class.
        /// </summary>
        /// <param name="identification">Identification.</param>
        /// <param name="value">Value.</param>
        /// <param name="date">Date.</param>
        public Post(string identification, decimal value, DateTimeOffset date)
        {
            Identification = identification;
            Value = value;
            Date = date;
        }
    }
}