
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarsCatalogue.Models
{
    [Table("cardetails")]
    public class CarDetails
    {
        public int id { get; set; }
        public string image { get; set; }
        
        [ForeignKey(nameof(Car))]
        public Guid cars_id { get; set; }
        public Car Car { get; set; }
    }
}