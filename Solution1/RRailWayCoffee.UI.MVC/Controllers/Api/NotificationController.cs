using RailWayCoffee.Infrastructure.Logging;
using RailWayCoffee.Services.Interfaces;
using RailWayCoffee.Services.Messaging.NotificationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RailWayCoffee.UI.MVC.Controllers.Api
{
    [Authorize]
    public class NotificationController : BaseController
    {
        private INotificationService _notificationService;
        public NotificationController(INotificationService notificationService, ILogger logger)
            : base(logger)
        {
            _notificationService = notificationService;
        }

        /// <summary>
        /// End Point is api/Notification
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<NotificationsDto> GetNewNotificationsForCurrentUser()
        {

            return _notificationService.GetNewNotificationsForCurrentUser();
        }
    }
}
