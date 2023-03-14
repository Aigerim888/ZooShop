using System.ComponentModel.DataAnnotations;

namespace ZooShop.Models
{
    public class Storagees
    {
        [Key]
        public int Storage_id {get; set;}
        public string Storage_name { get; set;}
        public Departments Departments { get; set;}
        public int Department_id { get;set;}
        public int The_rest_of_goods { get; set; }   
    }
}
