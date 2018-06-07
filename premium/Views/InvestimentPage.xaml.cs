using Syncfusion.SfChart.XForms;
using Xamarin.Forms;

namespace premium.Views
{
    public partial class InvestimentPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:premium.Views.InvestimentPage"/> class.
        /// </summary>
        public InvestimentPage()
        {
            InitializeComponent();

            Chart.Series[0].AnimationDuration = 2;
            (Chart.Series[0] as PieSeries).StartAngle = 0;
            (Chart.Series[0] as PieSeries).EndAngle = 360;
        }
    }
}