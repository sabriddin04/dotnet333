using Domain.Models;
using Npgsql;
using Dapper;

namespace Infrastructure.Services;

public class ProductService
{
    private string connect = "Host=localhost,Port=5432;Database=InternetShopSabrDb;User id =postgres;Password=sabriddin2004";


    public List<Products> GetProducts()
    {
        using var connection = new NpgsqlConnection(connect);

        var sabr = @"select products.id_product as Id_product, products.name,products.unit_price,brand.name as BrandName,category.name as CategoryName,
                products.description,products.units_in_stock,products.units_on_order as Units_on_order
                from products
                join Category on Category.category_id=products.id_category
                join Brand on Brand.id_brand=products.id_brand ";
        return connection.Query<Products>(sabr).ToList();
    }

    public void AddProducts(Products product)
    {

        using var connection = new NpgsqlConnection(connect);

        connection.Execute(@"insert into Products (name,description,unit_price,units_in_stock,units_on_order,id_category,id_brand)
        values(@Name,@description,@unit_price,@units_in_stock,@units_on_order,@id_category,@id_brand)", product);

    }

    public void DeleteProduct (int id){

        using var connection = new NpgsqlConnection(connect);
        connection.Execute("delete from Products where id=@id",new{Id=id});

    }

    public void UpdateProduct(Products product){

 
        using var connection = new NpgsqlConnection(connect);
        connection.Execute("Update Products  set name=@name,Description=@Description,Unit_price=@Unit_price,Units_in_Stock=@Units_in_Stock,Units_on_order=@Units_on_order,Id_Category =@Id_Category ,Id_Brand=@Id_Brand  where id=@id ",product);


    }


    public int CountProducts()
    {
        using var connection = new NpgsqlConnection(connect);
        return connection.ExecuteScalar<int>(@"select count(*) from Products");

    }




    public Products GetProductById(int id)
    {

        using var connection = new NpgsqlConnection(connect);
        var sabr = @"select products.id_product as Id_product, products.name,products.unit_price,brand.name as BrandName,category.name as CategoryName,
                products.description,products.units_in_stock,products.units_on_order as Units_on_order
                from products
                join Category on Category.category_id=products.id_category
                join Brand on Brand.id_brand=products.id_brand
                where id_product =@id ";


        return connection.QueryFirstOrDefault<Products>(sabr, new { Id = id });

    }
    public productCustomers GetCustomers(int id)
    {
      {
        using var connection = new NpgsqlConnection(connect);

        var sql = @"
               select * from Orders where orders.product_id=@id;
               select * from Customers where orders.id_customer_=Customers.id_customer ;
               select * from Products where orders.product_id=id_product ";

        using (var multiple = connection.QueryMultiple(sql, new { Id = id }))
        {

            var productCustomers1 = new productCustomers();
            productCustomers1.Product = multiple.ReadFirst<Products>();
            productCustomers1.Customers = multiple.Read<Customer>().ToList();
            return productCustomers1;

        }
      }  
    }























}
