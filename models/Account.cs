using System;
namespace models
{
    public class Account
    {
        public decimal Balance { get; set; }

        public Account(decimal balance)
        {
            Balance = balance;
        }
    }
}