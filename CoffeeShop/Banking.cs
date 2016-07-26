using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    // Banking
    public class BankAccount
    {
        public string Owner { get; set; }
        private double Balance { get; set; }
        public double Deposit(double amount)
        {
            return Balance += amount;
        }
        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
    // Specialization
    public class SavingAccount : BankAccount
    {
    }
    public class CurrentAccount: BankAccount
    {
        public double OD { get; set; }
    }
}
