using System;
using System.ComponentModel.DataAnnotations;


namespace RailWayCoffee.Models.DomainModels
{
  public  class Groups
    {
        [Required]
        public string Title { get; set; }
    }
}
