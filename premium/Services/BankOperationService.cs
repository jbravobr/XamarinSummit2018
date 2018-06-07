using premium.Contracts;

namespace appservices.Services
{
    /// <summary>
    /// Bank operation service.
    /// </summary>
    public class BankOperationService : IBankOperationService
    {
        /// <summary>
        /// Checks the account balance.
        /// </summary>
        /// <returns>The account balance.</returns>
        public decimal CheckAccountBalance()
        {
            return 19_610_99;
        }
    }
}