using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using CustomerNotification.API.Models.Enums;
using CustomerNotification.API.Models.Abstracts;

namespace CustomerNotification.API.Models
{
    public class DeleteMessage : Message
    {
        public DeleteMessage():base()
        {
            this.MessageType = MessageTypes.UserDeleted;
        }
        public DeleteBody MessageBody { get; set; }

        public override string GenerateMessage()
        {
            if (this.MessageFormat == MessageFormats.JSON)
            {
                this.FormattedMessage.Append("{" + Environment.NewLine);
                this.FormattedMessage.Append(@"""messageType"":" + @"""" + MessageTypes.UserDeleted.ToString() + @"""" + Environment.NewLine);
                this.FormattedMessage.Append(@"""data"":{" + Environment.NewLine);
                this.FormattedMessage.Append(@"""userId"":" + @"""" + MessageBody.UserId + @"""" + Environment.NewLine);
                this.FormattedMessage.Append("}" + Environment.NewLine);
                this.FormattedMessage.Append("}" + Environment.NewLine);
            }
            else if (this.MessageFormat == MessageFormats.CSV)
            {
                this.FormattedMessage.Append(@"""" + MessageTypes.UserDeleted.ToString() + @""",""" + MessageBody.UserId + @"""" + Environment.NewLine);
            }
            else // XML
            {
                this.FormattedMessage.Append(@"<?xml version=""1.0"" encoding=""UTF-8""?>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<message>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<messageType>" + MessageTypes.UserDeleted.ToString() + @"</messageType>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<data>" + Environment.NewLine);
                this.FormattedMessage.Append(@"<userId>" + MessageBody.UserId + @"</userId>" + Environment.NewLine);
                this.FormattedMessage.Append(@"</data>" + Environment.NewLine);
                this.FormattedMessage.Append(@"</message>" + Environment.NewLine);
            }
            return this.FormattedMessage.ToString();
        }
    }
}
