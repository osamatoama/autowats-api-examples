using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWats.Library.Constant
{
 public static class APIUrls
    {
        public static string BASE_URL = "https://autowats.com/api/v1";

        public static string GET_ALL_GROUPS = $"{BASE_URL}/groups";
        public static string CONNECTION_STATUS = "https://autowats.com/api/v1/connection/status";
        public static string SEND_MESSAGE = "https://autowats.com/api/v1/messages/send";
    }
}
