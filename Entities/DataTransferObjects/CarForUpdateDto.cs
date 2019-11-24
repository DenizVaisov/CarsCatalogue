using System.ComponentModel.DataAnnotations;

namespace CarsCatalogue.Models.DataTransferObjects
{
    public class CarForUpdateDto
    {
        public string title { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int speed { get; set; }
        public int accelaration { get; set; }
        public string characteristic { get; set; }
        public string description { get; set; }
    }
}