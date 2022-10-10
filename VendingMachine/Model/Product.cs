using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    //Have this abstract so no one outside will read the info cant do methods code in this
    public abstract class Product : IAge
    {
        //The base will have this id, name and price as propoties so the childclass
        private readonly int productId;
        public string? ProductName { get; set; }
        public int ProductPrice { get; set; }

        //this constructur
        public Product() { }
        public Product(int productId, string? productName, int productPrice)
        {
            this.productId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
        }
      
        //Do get and set to reach the values
        public int ProductId 
        { 
            get { return productId; } 
        }
     
        //Use examine to show the product´s info include unique data
        public virtual string Examine()
        {
            return $"---{this.GetType().Name} Info----\nType: {ProductId} ";
        }

        //Use use to put the product to use once it has been purchased (output a string how to use the product)
        public virtual string Use()
        {
            return $"---{this.GetType().Name} Instructions for----\n{ProductName} ";
        }

        public bool PassAgeLimit(int age)
        {
            throw new NotImplementedException();
        }
    }
}