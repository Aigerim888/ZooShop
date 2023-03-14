using System.ComponentModel.DataAnnotations;

namespace ZooShop.Models
{
    public class Departments
    {
        [Key]
        public int Department_id { get; set; }
        public string Department_name { get; set; }
        public Employees Employees { get; set; }   
        public int Employee_id { get; set;}
    }
}
