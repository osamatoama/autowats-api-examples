using AutoWats.Library.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Extensions
{
    public static class CustomizeExtensions
    {
        public static string ToQueryString(this SendingMessageModel model,string url)
        {
            var queryString = System.Web.HttpUtility.ParseQueryString(url);
            queryString.Add("send_type", model.SendType);
            queryString.Add("message", model.Message);
            queryString.Add("numbers_sending_type", model.NumberSendingType);
            queryString.Add("ids", model.Ids);
            queryString.Add("mood", model.Mood);
            return queryString.ToString();
        }


        public static  byte[] ConvertToByte(this IFormFile file)
        {

            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();
                return fileBytes;
                // act on the Base64 data
            }
        }
    }
}
