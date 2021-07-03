using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Entites
{
    public class ConnectionStatusResponseModel
    {

        public bool Error { get; set; }
        public string AccountStatus { get; set; }
        public string QrCode { get; set; }
        public StatusData statusData { get; set; }
    }
}
