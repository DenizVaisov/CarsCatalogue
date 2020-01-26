using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CarsCatalogue.Models
{
    [Table("cars")]
    public class Car
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int speed { get; set; }
        public int accelaration { get; set; }
        public string engine { get; set; }
		public double price { get; set;}
		public int capacity { get; set; }
        public string description { get; set; }
		public string image {get; set;}
		public string video {get; set;}
    }
}
