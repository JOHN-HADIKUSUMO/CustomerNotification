using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerNotification.API.Models.Enums;
using CustomerNotification.API.Models.Abstracts;

namespace CustomerNotification.API.Models
{
    public sealed class RegisterBody : Body
    {
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
