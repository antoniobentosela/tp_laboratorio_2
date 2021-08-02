using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogicException : Exception
    {
        public LogicException() { }
        public LogicException(string message) : base(message) { }
        public LogicException(string message, Exception inner) : base(message, inner) { }

    }
}
