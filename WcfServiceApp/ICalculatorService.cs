using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int a, int b);
        [OperationContract]
        int Mul(int a, int b);
        [OperationContract]
        int Sub(int a, int b);
    }
}
