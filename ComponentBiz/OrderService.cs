using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentBiz
{
    public class OrderService
    {
        public event EventHandler NewOrderArrived;

        public void SubmitOrder(Order o)
        {
            // Save Order
            EventHandler temp = NewOrderArrived;
            if (temp != null)
            {
                temp(this, EventArgs.Empty);
            }
        }

        public void SubmitOrder(Order o, INewOrderConsumer consumer /*Use call back model*/)
        {
            // Save Order

            // Simple Observer Pattern implementation.
            // HACK: ***This should be separate to a Publisher and a Topic.***
            INewOrderConsumer[] consumers = new[] { consumer };
            foreach (var c in consumers)
            {
                c.NewOrderArrived(o);
            }
        }
    }

    public class Order { }

    public interface INewOrderConsumer
    {
        void NewOrderArrived(Order o);
    }
}
