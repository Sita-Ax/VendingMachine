using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Data;
using VendingMachine.Model;

namespace VendingMachine.Tests.Models
{
    public class Product
    {
        public Product()
        {

        }

        [Fact]
        public void CreateProduct_Test()
        {
            //Arr
            Drink drink = new Drink(1, "Beer", 75, DrinksUnit.Beer);
            Food food = new Food(1, "Food", 47, "Tacos", "Dinner");
            Toy toy = new Toy(1, "Puzzle", 62, "For adult");
            //Act

            //Ass
            Assert.Equal(1, drink.ProductId);
            Assert.Equal(1, food.ProductId);
            Assert.Equal(1, toy.ProductId);
            Assert.Equal(75, drink.ProductPrice);
            Assert.Equal(47, food.ProductPrice);
            Assert.Equal(62, toy.ProductPrice);
            Assert.Equal("Beer", drink.ProductName);
            Assert.Equal("Food", food.ProductName);
            Assert.Equal("Puzzle", toy.ProductName);
        }
    }
}
