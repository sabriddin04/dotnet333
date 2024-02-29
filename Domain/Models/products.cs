namespace Domain.Models;

public class Products
{

   public int Id_product { get; set; }

   public string Name { get; set; }

   public string Description { get; set; }

   public decimal Unit_price{get; set;}

   public int Units_in_Stock { get; set; }

   public int Units_on_order { get; set; }

   public string CategoryName { get; set; }

   public string BrandName{ get; set;}

   public int Id_Category { get; set; }

   public int Id_Brand{ get; set; }
    
}
