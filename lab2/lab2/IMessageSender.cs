using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace lab2
{
    public interface IMessageSender
    {
       public string SendMessage();
    }
}