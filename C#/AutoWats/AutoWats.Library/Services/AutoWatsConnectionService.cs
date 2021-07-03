using AutoWats.Library.Abstract;
using AutoWats.Library.Constant;
using AutoWats.Library.Entites;
using AutoWats.Library.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AutoWats.Library.Services
{
    public class AutoWatsConnectionService : IAutoWatsConnection
    {
        public AutoWatsConnectionService()
        {
            ApIHelper.InitializeClient();
        }
        public async Task<string> GetConnectionStatus(AcceptedTokenModel acceptedToken)
        {
            ApIHelper.ApiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {acceptedToken.AuthorizationKey}");
            string url = $"{APIUrls.CONNECTION_STATUS}?whatsapp_api_key={acceptedToken.WhatsAppApiKey}";
            using (HttpResponseMessage response = await ApIHelper.ApiClient.GetAsync(url))
            {
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
