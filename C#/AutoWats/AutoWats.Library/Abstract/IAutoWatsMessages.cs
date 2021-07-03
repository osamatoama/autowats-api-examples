using AutoWats.Library.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Abstract
{
    public interface IAutoWatsMessages
    {
        Task<string> SendMessage(SendingMessageModel model,IFormFile[] Attachments);
    }
}
