﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsCatalogue.Models.DataTransferObjects
{
    public class CarDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Speed { get; set; }
        public double Accelaration { get; set; }
		public double Price { get; set; }
        public string Engine { get; set; }
		public double Capacity { get; set; }
        public string Description { get; set; }
		public string Image {get; set;}
		public string Video { get; set; }
		
		public IEnumerable<CarDetailsDto> CarDetails { get; set; }
    }
}