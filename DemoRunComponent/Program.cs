using ComponentBiz;
using ComponentUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRunComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new OrderForm();
            form.PlaceOrder(new Order());
        }
    }
}
