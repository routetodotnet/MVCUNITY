using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCUNITY.Models
{

   //1
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
    //2
    public class NWDbContext:DbContext
    {
        public NWDbContext():base("dbconnectionstringfromweb")
        { 
          
        
        }

        public virtual ICollection<Product> Products { get; set; }


    }
    //3enable migration
    //add migration mig1
    //update-database

}