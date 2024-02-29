using Domain.Models;
using Infrastructure.Services;

var productService1= new ProductService();

/*
foreach (var item in productService1.GetProducts())
{
    System.Console.WriteLine($"id : {item.Id_product}");
    System.Console.WriteLine($"name : {item.Name}");
    System.Console.WriteLine($"description : {item.Description}");
    System.Console.WriteLine($"PRICE : {item.Unit_price}");
    System.Console.WriteLine($"Units_on_order : {item.Units_on_order}");
    System.Console.WriteLine($"Units_in_Stock : {item.Units_in_Stock}");
    System.Console.WriteLine($"BrandName : {item.BrandName}");
    System.Console.WriteLine($"CategoryName : {item.CategoryName}");
}*/
/*
System.Console.WriteLine("--------------------------------------------------------------------------");
var product1=new Products();
product1.Name="vertolet";
product1.Description="I vertolet ZURAY";
product1.Unit_price=350;
product1.Units_on_order=30;
product1.Units_in_Stock=270;
product1.Id_Brand=1;
product1.Id_Category=2;
System.Console.WriteLine("--------------------------------------------------------------------------");
*/
/*productService1.AddProducts(product1);
foreach (var item in productService1.GetProducts())
{
    System.Console.WriteLine($"id : {item.Id_product}");
    System.Console.WriteLine($"name : {item.Name}");
    System.Console.WriteLine($"description : {item.Description}");
    System.Console.WriteLine($"PRICE : {item.Unit_price}");
    System.Console.WriteLine($"Units_on_order : {item.Units_on_order}");
    System.Console.WriteLine($"Units_in_Stock : {item.Units_in_Stock}");
    System.Console.WriteLine($"BrandName : {item.BrandName}");
    System.Console.WriteLine($"CategoryName : {item.CategoryName}");
}


System.Console.WriteLine("--------------------------------------------------------------------------");

*/
/*
System.Console.WriteLine($"KOLICHESTVO TOVARA :{productService1.CountProducts()}");
System.Console.WriteLine("--------------------------------------------------------------------------");
System.Console.WriteLine(productService1.GetProductById(1).Name);
System.Console.WriteLine(productService1.GetProductById(1).Description);
System.Console.WriteLine(productService1.GetProductById(1).Unit_price);
System.Console.WriteLine(productService1.GetProductById(1).BrandName);
System.Console.WriteLine(productService1.GetProductById(1).CategoryName);

*/
System.Console.WriteLine("TOVAR : ");

System.Console.WriteLine(productService1.GetCustomers(1).Product.Id_product);
System.Console.WriteLine(productService1.GetCustomers(1).Product.Name);
System.Console.WriteLine("++++++++++++");
System.Console.WriteLine("Customers : ");
foreach (var item in productService1.GetCustomers(1).Customers)
{

    System.Console.WriteLine(item.First_Name);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Phone);
    System.Console.WriteLine("-----------------------------------");    
}

