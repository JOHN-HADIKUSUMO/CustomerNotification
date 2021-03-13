using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerNotification.API.Models;
using CustomerNotification.API.Models.Enums;
using CustomerNotification.API.Models.Abstracts;
using CustomerNotification.API.Models.Interfaces;
using CustomerNotification.Services;

namespace CustomerNotification.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        MessagingService service;
        public MessageController(MessagingService service):base()
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return await Task.Run(() => Ok("Hello World"));
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register([FromBody] RegisterMessage message)
        {
            await this.service.SendMessageAsync(message.MessageBody.UserId, message.GenerateMessage());
            return await Task.Run(() => Ok());
        }

        [HttpPut]
        [Route("Block")]
        public async Task<ActionResult> Block([FromBody] AccessBlockMessage message)
        {
            await this.service.SendMessageAsync(message.MessageBody.UserId, message.GenerateMessage());
            return await Task.Run(() => Ok());
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromBody] DeleteMessage message)
        {
            await this.service.SendMessageAsync(message.MessageBody.UserId, message.GenerateMessage());
            return await Task.Run(() => Ok());
        }
    } 
}
