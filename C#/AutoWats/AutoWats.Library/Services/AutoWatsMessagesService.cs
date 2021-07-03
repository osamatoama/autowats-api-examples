using AutoWats.Library.Abstract;
using AutoWats.Library.Constant;
using AutoWats.Library.Entites;
using AutoWats.Library.Extensions;
using AutoWats.Library.Helper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Services
{
    public class AutoWatsMessagesService : IAutoWatsMessages
    {
        public AutoWatsMessagesService()
        {
            ApIHelper.InitializeClient();
        }
        public async Task<string> SendMessage(SendingMessageModel model, IFormFile[] Attachments)
        {
            ApIHelper.ApiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {model.AcceptedTokenModel.AuthorizationKey}");
            string url = $"{APIUrls.SEND_MESSAGE}?whatsapp_api_key={model.AcceptedTokenModel.WhatsAppApiKey}";
            var finalurl = model.ToQueryString(url);
            using ( var  content = new MultipartFormDataContent())
            {
                foreach (var item in Attachments)
                {
                    content.Add(new StreamContent(new MemoryStream(item.ConvertToByte())), item.Name, item.FileName);
                }
                using (HttpResponseMessage response = await ApIHelper.ApiClient.PostAsync(finalurl, content))
                {
                    return  await response.Content.ReadAsStringAsync();
                }
            }
        }

    }
}
