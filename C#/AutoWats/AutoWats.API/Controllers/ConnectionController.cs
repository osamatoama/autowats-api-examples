using AutoWats.Library.Abstract;
using AutoWats.Library.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoWats.API_Example.Controllers
{
  
    [ApiController]
    public class ConnectionController : ControllerBase
    {

        private readonly IAutoWatsConnection _autoWatsConnection;
        public ConnectionController( IAutoWatsConnection autoWatsConnection) 
        {
            _autoWatsConnection = autoWatsConnection;
        }
        [HttpPost]
        [Route("/connection​/status")]
        public async Task<string> GetConnectionStatus([FromBody]AcceptedTokenModel tokenModel)
        {
         return await _autoWatsConnection.GetConnectionStatus(tokenModel);
        }
    }
}
