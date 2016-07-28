using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFullDuplexServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IOrderServiceCallback))]
    public interface IOrderService
    {
        [OperationContract(IsOneWay = true)]
        void SubmitOrder(Order o);
    }
    public interface IOrderServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OrderReceived(Order o);
    }
    public class Order { }
}
