using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace RailWayCoffee.Models.DomainModels
{
    public class User : BaseEntity
    {
        public User()
        {
            UserNotifications = new Collection<UserNotification>();
        }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } 

        [Required]
        [StringLength(20)]
        public string MobileNumber { get; set; }


        #region Navigation properties
        public virtual ICollection<UserNotification> UserNotifications { get; set; }
        public virtual ICollection<Order> Orders{ get; set; }
        #endregion

        public void Notify(Notification notification)
        {
            UserNotifications.Add(new UserNotification(notification, this));
        }
    }
}
