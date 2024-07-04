using System.ComponentModel.DataAnnotations;

namespace WebApiCarsProgresSql.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        public string mark { get; set; }
        public string color { get; set; }
        public int year { get; set; }
    }
}
