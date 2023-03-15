using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooShop.Models
{
    public class Departments
    {
        [Key]
        public int Department_id { get; set; }
        public string Department_name { get; set; }
        [ForeignKey("Employee")]
        public int Employee_id { get; set; }

        public Employees Employee { get; set; }
        

    }
}
