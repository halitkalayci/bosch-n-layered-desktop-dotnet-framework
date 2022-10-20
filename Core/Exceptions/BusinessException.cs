using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class BusinessException : Exception
    {
        public string Message { get; set; }
        public bool MessageType { get; set; }
        public BusinessException(string message, bool messageType)
        {
            Message = message;
            MessageType = messageType;
        }

        public override string ToString()
        {
            return Message;
        }

        public bool GetMessageType()
        {
            return MessageType;
        }
    }
}
