using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsCatalogue.Models.DataTransferObjects
{
    //CODEREV: Data transfer object - паттерн, который испольузется для передачи данных между подсистемами системы (между классами в данном случае). У вас же он используется для передачи данных снаружи. В терминах REST эта вещи называется Resource. Использование имени DTO при этом скрывает смысловое предназначение этого класса. То же можно сказать про другие DTO в проекте
    public class CarDto
    {
        [Key]
        public Guid id { get; set; }
        public string title { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int speed { get; set; }
        public double accelaration { get; set; }
		public double price { get; set; }
        public string engine { get; set; }
		public double capacity { get; set; }
        public string description { get; set; }
		public string image {get; set;}
		public string video { get; set; }
    }
}