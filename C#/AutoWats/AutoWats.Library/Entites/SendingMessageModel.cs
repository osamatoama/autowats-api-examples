using Microsoft.AspNetCore.Http;

namespace AutoWats.Library.Entites
{
  public  class SendingMessageModel
    {
        public AcceptedTokenModel AcceptedTokenModel { get; set; }
        public string SendType { get; set; }
        public string Message { get; set; }
        public string NumberSendingType { get; set; }
        public  string Ids { get; set; }
        public string Mood { get; set; }
    }
}
