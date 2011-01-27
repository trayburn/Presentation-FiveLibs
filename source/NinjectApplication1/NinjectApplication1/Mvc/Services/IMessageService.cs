namespace Mvc.Services
{
    public interface IMessageService
    {
        string GetWelcomeMessage();
    }
    public interface ITimsMessage : IMessageService
    {
    }
}
