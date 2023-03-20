using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooShop.Models
{
    public class Products
    {
        [Key]
      public int Product_id {get; set;}
      public string Name { get; set; }
      public int Price { get; set; }

      [ForeignKey("Brand")]
       
      public int Brand_id { get;set;}
      public Brands? Brand { get; set; }
      [ForeignKey("Category")]
      public int Category_id { get; set; }
      public Categories? Category { get; set; }
      [ForeignKey("Storage")]
      public int Storage_id { get; set; }
      public Storagees? Storage { get; set; }




    }
}
