﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CarsCatalogue.Models
{
    [Table("cars")]
    public class Car
    {
	    [Key]
        public Guid id { get; set; }
        public string title { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int speed { get; set; }
        public double accelaration { get; set; }
        public string engine { get; set; }
		public double price { get; set;}
		public double capacity { get; set; }
        public string description { get; set; }
		public string image {get; set;}
		public string video {get; set;}
		
		public ICollection<CarDetails> CarDetails { get; set; }
    }
}
