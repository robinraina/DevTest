using System;
using System.ComponentModel.DataAnnotations;

namespace DeveloperTest.Database.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MinLength(5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is Required")]
        public string Type { get; set; }

    }
   
}
