namespace models
{
    /// <summary>
    /// Chart data model.
    /// </summary>
    public class ChartDataModel
    {
        /// <summary>
        /// Gets or sets the month.
        /// </summary>
        /// <value>The month.</value>
        public string Month { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public double Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:models.ChartDataModel"/> class.
        /// </summary>
        /// <param name="month">Month.</param>
        /// <param name="value">Value.</param>
        public ChartDataModel(string month, double value)
        {
            Month = month;
            Value = value;
        }
    }
}