using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        // 2 constructors one overloads the other
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
