using AutoWats.Library.Abstract;
using AutoWats.Library.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoWats.API_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IAutoWatsMessages _autoWatsMessages;
      
        public MessagesController(IAutoWatsMessages autoWatsMessages)
        {
            _autoWatsMessages = autoWatsMessages;
        }
        [HttpPost]
        [Route("/messages​/send")]
        public async Task<string> SendMessage([FromQuery] SendingMessageModel model,
            [FromForm] IFormFile[] Attachments=null)
        {
            return await _autoWatsMessages.SendMessage(model,Attachments);
        }
    }
}
