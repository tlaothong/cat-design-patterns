using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDIWeb.Services
{
    public class MyDiService : IMyDiService
    {
        public string MyProperty { get { return "Hello DI!"; } }
    }
}
