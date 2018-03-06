using System;
using System.Collections.Generic;
using RailWayCoffee.Services.Interfaces;
using RailWayCoffee.Services.Messaging.NotificationService;

namespace RailWayCoffee.Services.Concretes
{
    public class NotificationService : INotificationService
    {
        public IEnumerable<NotificationsDto> GetNewNotificationsForCurrentUser()
        {
            return null;// from notification repository
        }
    }
}
