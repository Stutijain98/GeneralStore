//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5
using GeneralStoreApp.models
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Sysyem.Net.Http;
using System.Web.Http;

namespace GeneralStoreApp.Controllers
{
    public class ProductsController : ApiController
    {
      Product[] product=new Product[]
      {
          new Product={Id=product.ProductId},
          new Product={Name=product.Name},
          new Product={Price=product.Price},
          new Product={Quantity=product.Quantity}
      };
    
        //getting all products
    public IEnumerable<Product> Get()
    {
        return Products;
    }
        //getting products by id
    public IHttpActionResult Get({ProductId})
        {
           var item = Products.FirstOrDefault((t)=>t.ProductId==ProductId);
            if (item == null)
            {
                return NotFound("There is no such product available at the store");
            }
            return Ok(Products);
        }
        
       // inserting products in products collection
    public IEnumerable<Product> Post([FromBody]IEnumerable<Product> Products)    
       {
         return.AddProducts(pList);
       } 
       
    
    }
 
}