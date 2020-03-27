
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("This are Products");
            var Products= new List<Product>
        {
            new Product() { ProductId=1,Name="Hairoil", Price="Rs.30",Quantity=1},
            new Product() { ProductId=2,Name="Soap", Price="Rs.20",Quantity=2},
            new Product() { ProductId=3,Name="Cream", Price="Rs.60",Quantity=2},
            new Product() { ProductId=4,Name="Deo", Price="Rs.130",Quantity=1}
        };
        

    foreach (Product theproduct in Products)
    {
        Console.WriteLine(theproduct.ProductId + "  " + theproduct.Name+" "+ theproduct.Price+" "+theproduct.Quantity);
    }}
            
            public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set;}           
    public string Price { get; set; }
    public int Quantity { get; set;}
}
        }
    }