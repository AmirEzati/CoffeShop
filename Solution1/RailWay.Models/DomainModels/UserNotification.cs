using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailWayCoffee.Models.DomainModels
{
    [Table("UserNotifications", Schema = Constants.SCHEMA)]
    public class UserNotification
    {
        protected UserNotification()
        {

        }
        public UserNotification(Notification notification, User user)
        {
            if (notification == null)
            {
                throw new ArgumentNullException("null notification");
            }
            if (user == null)
            {
                throw new ArgumentNullException("null user");
            }

            User = user;
            Notification = notification;
        }
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserNotification>
        {
            public Configuration()
            {
                HasRequired(s => s.User)
                    .WithMany(d => d.UserNotifications)
                    .HasForeignKey(s => s.UserId)
                    .WillCascadeOnDelete(false)
                    ;

                HasRequired(s => s.Notification)
                    .WithMany(d => d.UserNotifications)
                    .HasForeignKey(s => s.NotificationId)
                    .WillCascadeOnDelete(false)
                    ;
            }
        }

        [Key]
        [Column(Order = 0)]
        public Guid UserId { get;private set; }

        [Key]
        [Column(Order = 1)]
        public Guid NotificationId { get;private set; }

        #region Navigation Properties
        public virtual User User { get;private set; }
        public virtual Notification Notification { get; private set; }

        #endregion
    }
}
