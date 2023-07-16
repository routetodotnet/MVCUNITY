using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVCUNITY.Models.Repositories
{

    public interface IProductRep
    {

       void Insert(Product product);
        List<Product> GetAll();
        void Delete(int prodid);


    }

    public class ProductRepository : IProductRep
    {
        public void Delete(int prodid)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //dbcontext object 
            //linq query from entity
            //return products collection
            return new List<Product>()
            {

                new Product() { Id=1,Name="aaa" , Description="product1"},
                  new Product() { Id=2,Name="bb" , Description="product2"},
                    new Product() { Id=3,Name="ccc" , Description="product3"}
            };
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }
    }
}