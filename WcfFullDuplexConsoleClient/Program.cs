using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfFullDuplexConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new OrderForm();
            form.PlaceOrder(new FullDuplexSvc.Order());

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
