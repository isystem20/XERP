using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XERP.App.Models.lib;

namespace XERP.App.Interfaces
{
    public interface INotificationServices
    {
        Task SendAsync(Message message)
    }
}
