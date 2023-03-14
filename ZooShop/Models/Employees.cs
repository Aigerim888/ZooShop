using System.ComponentModel.DataAnnotations;

namespace ZooShop.Models
{
    public class Employees
    {
        [Key]
        public int Employee_id { get;set; }
        public string Employee_name { get;set; }    
    }
}
