using System.ComponentModel.DataAnnotations;

namespace ZooShop.Models
{
    public class Categories
    {
        [Key]
        public int Category_id { get; set; }    
        public string Category_name { get; set; }

    }
}
