using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsCatalogue.Models.DataTransferObjects
{
    public class CarForCreationDto
    {
        public string title { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int speed { get; set; }
        public int accelaration { get; set; }
		public double price { get; set; }
        public string engine { get; set; }
		public int capacity { get; set; }
        public string description { get; set; }
		public string image {get; set;} 
		public string video { get; set; }
    }
}