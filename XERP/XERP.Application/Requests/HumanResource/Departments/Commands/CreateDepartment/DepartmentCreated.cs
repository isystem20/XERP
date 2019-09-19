using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XERP.Application.Interfaces;
using XERP.Application.Notifications.Models;

namespace XERP.Application.Requests.HumanResource.Departments.Commands.CreateDepartment
{
    public class DepartmentCreated : INotification
    {
        public string Id { get; set; }

        public class DepartmentCreatedHandler : INotificationHandler<DepartmentCreated>
        {
            private readonly INotificationService _notification;

            public DepartmentCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(DepartmentCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
