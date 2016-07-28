using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDIWeb.Services
{
    public class MyClassDi
    {
        private IMyDiService di;
        public MyClassDi(IMyDiService di)
        {
            this.di = di;
        }
        public string Property { get { return this.di.MyProperty; } }
    }
}
