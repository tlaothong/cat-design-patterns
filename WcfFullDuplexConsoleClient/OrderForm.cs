using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfFullDuplexConsoleClient.FullDuplexSvc;

namespace WcfFullDuplexConsoleClient
{
    class OrderForm : FullDuplexSvc.IOrderServiceCallback
    {
        public void PlaceOrder(Order o)
        {
            var svc = new FullDuplexSvc.OrderServiceClient(
                new System.ServiceModel.InstanceContext(this));
            svc.SubmitOrder(o);
        }

        public void OrderReceived(Order o)
        {
            Console.WriteLine("** ==>>> INFO: Order Received");
        }
    }
}
