using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RailWayCoffee.Models.DomainModels
{
    public class Notification : BaseEntity
    {
        public Notification()
        {
            UserNotifications = new Collection<UserNotification>();
            DateTime = DateTime.Now;
        }
        public DateTime DateTime { get;private set; }

        #region Navigation Properties
        public virtual ICollection<UserNotification> UserNotifications { get; set; }
        #endregion
    }
}
