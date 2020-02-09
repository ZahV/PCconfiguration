using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PCconfiguration.Models
{
    public class CpuCooling
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.1, Double.MaxValue, ErrorMessage = "Minimum price is 10 cents")]
        public double Price { get; set; }
    }
}
