using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFullDuplexServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : IOrderService
    {
        public void SubmitOrder(Order o)
        {
            // Save Order ...
            var client = OperationContext.Current.GetCallbackChannel<IOrderServiceCallback>();
            client.OrderReceived(o);
            System.Threading.Thread.Sleep(1234);
            client.OrderReceived(o);
            System.Threading.Thread.Sleep(2345);
            client.OrderReceived(o);
        }
    }
}
