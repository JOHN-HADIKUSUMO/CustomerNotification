using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerNotification.API.Models.Enums;
using CustomerNotification.API.Models.Interfaces;

namespace CustomerNotification.API.Models
{
    public class Body : IBody
    {
        public string UserId { get; set; }
    }
}
