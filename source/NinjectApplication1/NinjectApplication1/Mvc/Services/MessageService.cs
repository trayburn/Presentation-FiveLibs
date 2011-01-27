namespace Mvc.Services
{
    public class MessageService : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Welcome to ASP.NET MVC!";
        }
    }

    public class TimsMessage : ITimsMessage
    {

        public string GetWelcomeMessage()
        {
            return "Hello TysonDevCon!";
        }
    }
}
