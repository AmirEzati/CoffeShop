using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailWayCoffee.Models.DomainModels
{
    [Table("Orders", Schema = Constants.SCHEMA)]
    public class Order : BaseEntity
    {
        public Order()
        {
            CreatedDateTime = DateTime.Now;
        }

        #region Configuration
        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Order>
        {
            public Configuration()
            {
                HasRequired(s => s.Coffee)
                    .WithMany(d => d.Orders)
                    .HasForeignKey(s => s.CoffeeId)
                    .WillCascadeOnDelete(false);

                HasRequired(s => s.Customer)
                    .WithMany(d => d.Orders)
                    .HasForeignKey(s => s.CustomerId)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region Properties
        public Guid  CustomerId { get; set; }
        public virtual User Customer { get; set; }
        public Guid CoffeeId { get; set; }
        public virtual Coffee Coffee { get; set; }
        public DateTime CreatedDateTime { get;private set; }

        [Display(Name ="Pickup Time")]
        public DateTime ETA { get; set; }
        public EnumOrderStatuses Status { get;private set; }
        public bool IsCanceled { get;private set; }
        public bool IsPaid { get;private set; }
        #endregion

        #region Methods
        public void Create()
        {

        }

        public void ChangeStatus()
        {

        }
        public void Commit()
        {
            //Now you can Send a notification
        }
        public void Cancel()
        {
            IsCanceled = true;
            //Now you can Send a notification
        }

        /// <summary>
        ///is Calculated based on  ETA and preparation time
        /// </summary>
        /// <returns></returns>
        public DateTime PreparationStartTime()
        {
            //Algorithm here...

            return DateTime.MinValue;
        }

        public void Pay()
        {

        }
        #endregion
    }
}
