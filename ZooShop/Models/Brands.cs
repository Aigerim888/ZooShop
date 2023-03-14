using System.ComponentModel.DataAnnotations;

namespace ZooShop.Models
{
    public class Brands
    {
        [Key]
        public int Brand_id { get; set; }   
        public string Brand_name {  get; set; } 

    }
}
