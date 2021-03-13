using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using CustomerNotification.API.Models.Enums;
using CustomerNotification.API.Models.Abstracts;

namespace CustomerNotification.API.Models
{
    public class RegisterMessage : Message
    {
        public RegisterMessage():base()
        {
            this.MessageType = MessageTypes.NewUserRegistered;
        }
        public RegisterBody MessageBody { get; set; }

        public override string GenerateMessage()
        {
            if (this.MessageFormat == MessageFormats.JSON)
            {
                this.FormattedMessage.Append("{" + Environment.NewLine);
                this.FormattedMessage.Append(@"""messageType"":" + @"""" + MessageTypes.NewUserRegistered.ToString() + @"""" + Environment.NewLine);
                this.FormattedMessage.Append(@"""data"":{" + Environment.NewLine);
                this.FormattedMessage.Append(@"""userId"":" + @"""" + MessageBody.UserId + @"""" + Environment.NewLine);
                this.FormattedMessage.Append(@"""email"":" + @"""" + MessageBody.Email + @"""" + Environment.NewLine);
                this.FormattedMessage.Append(@"""firstName"":" + @"""" + MessageBody.Firstname + @"""" + Environment.NewLine);
                this.FormattedMessage.Append(@"""lastName"":" + @"""" + MessageBody.Lastname + @"""" + Environment.NewLine);
                this.FormattedMessage.Append("}" + Environment.NewLine);
                this.FormattedMessage.Append("}" + Environment.NewLine);
            }
            else if (this.MessageFormat == MessageFormats.CSV)
            {
                this.FormattedMessage.Append(@"""" + MessageTypes.NewUserRegistered.ToString() + @""",""" + MessageBody.UserId + @""",""" + MessageBody.Email + @""",""" + MessageBody.Firstname + @""",""" + MessageBody.Lastname + @""""  + Environment.NewLine);
            }
            else // XML
            {
                this.FormattedMessage.Append(@"<?xml version=""1.0"" encoding=""UTF-8""?>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<message>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<messageType>" + MessageTypes.NewUserRegistered.ToString() + @"</messageType>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<data>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<userId>" + MessageBody.UserId + @"</userId>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<email>" + MessageBody.Email + @"</email>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<firstName>" + MessageBody.Firstname + @"</firstName>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<lastName>" + MessageBody.Lastname + @"</lastName>" + Environment.NewLine);
                this.FormattedMessage.Append(@"</data>" + Environment.NewLine);
                this.FormattedMessage.Append(@"</message>" + Environment.NewLine);
            }
            return this.FormattedMessage.ToString();
        }
    }
}
