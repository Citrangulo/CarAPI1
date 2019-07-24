using System;
using System.Collections.Generic;
using System.Text;
using CarAPI.Domain.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CarAPI.Domain.Entities
{
    public sealed class Car : Entity
    {
        [Required]
        [MaxLength(10)]
        [MinLength(2)]
        public string Model { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(2)]
        public string Year { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(2)]
        public string Brand { get; set; }
    }
}
