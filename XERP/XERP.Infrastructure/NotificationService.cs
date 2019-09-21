using System.Threading.Tasks;
using XERP.Application.Interfaces;
using XERP.Application.Notifications.Models;

namespace XERP.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
