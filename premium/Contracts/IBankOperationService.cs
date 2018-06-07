namespace premium.Contracts
{
    /// <summary>
    /// Bank operation service.
    /// </summary>
    public interface IBankOperationService
    {
        /// <summary>
        /// Checks the account balance.
        /// </summary>
        /// <returns>The account balance.</returns>
        decimal CheckAccountBalance();
    }
}