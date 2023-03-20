using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooShop.Models
{
    public class Storagees
    {
        [Key]
     
        public int Storage_id {get; set;}
        public string Storage_name { get; set;}
        public int The_rest_of_goods { get; set; }
       
        [ForeignKey("Department")]
        
        public int Department_id { get;set;}
        public Departments? Department { get; set; }

    }
}
