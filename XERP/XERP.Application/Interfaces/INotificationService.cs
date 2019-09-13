using System.Threading.Tasks;
using XERP.Application.Notifications.Models;

namespace XERP.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
