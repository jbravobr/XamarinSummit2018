using models;
using premium.Contracts;
using System.Collections.ObjectModel;

namespace premium.ViewModels
{
    /// <summary>
    /// Investiments page view model.
    /// </summary>
    public class InvestimentPageViewModel : BaseViewModel
    {
        private readonly IBankOperationService _bankOperationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:premium.ViewModels.InvestimentsPageViewModel"/> class.
        /// </summary>
        public InvestimentPageViewModel(IBankOperationService bankOperationService)
        {
            _bankOperationService = bankOperationService;
            LoadPieSeries();
        }

        /// <summary>
        /// Gets or sets the pie series data.
        /// </summary>
        /// <value>The pie series data.</value>
        public ObservableCollection<ChartDataModel> PieSeriesData { get; set; }

        /// <summary>
        /// Gets the balance.
        /// </summary>
        /// <value>The balance.</value>
        public string Balance => $"R$ {_bankOperationService.CheckAccountBalance().ToString("#,##0")}";

        /// <summary>
        /// Loads the posts.
        /// </summary>
        private void LoadPieSeries()
        {
            PieSeriesData = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Janeiro", 120),
                new ChartDataModel("Fevereiro", 100),
                new ChartDataModel("Março", 220),
                new ChartDataModel("Abril", 200),
                new ChartDataModel("Maio", 60),
                new ChartDataModel("Junho", 300)
           };

        }
    }
}