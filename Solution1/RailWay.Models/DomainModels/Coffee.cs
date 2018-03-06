using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RailWayCoffee.Models.DomainModels
{
    public class Coffee : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public double price { get; set; }
        public byte PreparationTime { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
