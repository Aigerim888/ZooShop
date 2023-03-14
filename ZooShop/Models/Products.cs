using System.ComponentModel.DataAnnotations;

namespace ZooShop.Models
{
    public class Products
    {
        [Key]
      public int Product_id {get; set;}
      public string Name { get; set; }
      public int Price { get; set; }
      public Brands Brands { get; set; }
      public int Brand_id { get;set;} 
      public Categories Categories { get; set; }
      public int Category_id { get; set; }
      public Storagees Storagees { get; set; }
      public int Storagee_id { get; set; }
        
        


    }
}
