using ComponentBiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentUI
{
    public class OrderForm : INewOrderConsumer
    {
        OrderService svc = new OrderService();

        public OrderForm()
        {
            svc.NewOrderArrived += Svc_NewOrderArrived;
        }

        private void Svc_NewOrderArrived(object sender, EventArgs e)
        {
            Console.WriteLine("*** ===>>> INFO FROM EVENT: a new order's arrived!");
        }

        public void PlaceOrder(Order o)
        {
            svc.SubmitOrder(o);
            //svc.SubmitOrder(o, this);
        }

        public void NewOrderArrived(Order o)
        {
            Console.WriteLine("*** ===>>> INFO: a new order's arrived!");
        }
    }
}
