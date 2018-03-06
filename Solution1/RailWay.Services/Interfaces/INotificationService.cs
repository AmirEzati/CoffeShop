using RailWayCoffee.Services.Messaging.NotificationService;
using System.Collections.Generic;

namespace RailWayCoffee.Services.Interfaces
{
    public interface INotificationService
    {
        IEnumerable<NotificationsDto> GetNewNotificationsForCurrentUser();
    }
}
