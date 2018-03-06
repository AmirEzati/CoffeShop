using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RailWayCoffee.Models
{
    public abstract class BaseEntity:IEntity
    {
        public BaseEntity()
        {
            Id = System.Guid.NewGuid();
        }

        [Key]
        [Column(Order = 1)]
        public  Guid Id { get; set; }
    }
}
