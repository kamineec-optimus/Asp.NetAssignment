using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class IsCarDeadException : Exception
    {
        /// <summary>
        /// Custom Message to show that Car has overheated
        /// </summary>
        /// <param name="Message">Message to be shown</param>
        public IsCarDeadException(string Message)
            : base(Message) {}

    }
        
}


