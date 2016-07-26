using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var accSaving = new SavingAccount();
            var accCurrent = new CurrentAccount();

            accSaving.Owner = "Teerachai";
            accSaving.Deposit(300);
            //accSaving.Balance = 73800;
            Console.WriteLine(accSaving.GetBalance());
        }
    }

    public class Order
    {
        public Beverage[] OrderItems { get; set; }
    }

    // Generalization
    public class Beverage
    {
        public string Name { get; set; }
        public string HotOrColdDrink { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
    public class Coffee : Beverage
    {
    }
    public class Tea : Beverage
    {
    }
}
