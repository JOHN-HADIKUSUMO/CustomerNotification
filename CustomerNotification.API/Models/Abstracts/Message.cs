using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using CustomerNotification.API.Models.Enums;
using CustomerNotification.API.Models.Interfaces;

namespace CustomerNotification.API.Models.Abstracts
{
    public abstract class Message : IMessage
    {
        public Message()
        {
            FormattedMessage = new StringBuilder();
        }
        protected StringBuilder FormattedMessage { get; set; }
        protected MessageTypes MessageType { get; set; }
        public MessageFormats MessageFormat { get; set; }
        public abstract string GenerateMessage();
    }
}
