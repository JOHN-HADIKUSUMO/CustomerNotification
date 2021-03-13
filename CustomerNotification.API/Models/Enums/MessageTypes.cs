using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerNotification.API.Models.Enums
{
    public enum MessageTypes
    {
        NewUserRegistered = 0,
        UserDeleted = 1,
        UserBlocked = 2
    }
}
