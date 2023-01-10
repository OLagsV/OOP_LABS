using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrLib
{
    public class ArrException : Exception
    {
        public ArrException(string message)
            : base(message)
        {
        }
    }
}
