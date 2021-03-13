using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerNotification.API.Models.Enums;

namespace CustomerNotification.API.Models.Interfaces
{
    public interface IMessage
    {
        public MessageFormats MessageFormat { get; set; }
    }
}
