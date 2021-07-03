using AutoWats.Library.Entites;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Abstract
{
    public interface IAutoWatsConnection
    {
        Task<string> GetConnectionStatus(AcceptedTokenModel acceptedToken);
    }
}
