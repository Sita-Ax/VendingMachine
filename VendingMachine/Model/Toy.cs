﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public class Toy : Product, IAge
    {
        private string? Description { get; set; }
        public static int ToyId { get; set; }
        public int NextId()
        {
            ToyId++;
            return ToyId;
        }
        public Toy()
        {

        }
        public Toy(int productId, string? productName, int productPrice, string? description) : base(productId, productName, productPrice)
        {
            Description = description;
        }

        public override string Examine()
        {
            return base.Examine() + $"\n{ProductName} {ProductPrice} kr \n{Description}";
        }

        public override string Use()
        {
            return base.Use() + "\nplay maybe?";
        }
        public bool AgeLimit(int age)
        {
                throw new NotImplementedException();
        }
        public string AgeControll()
        {
            int userAge = 0;
            Console.WriteLine("What is you age? ");
            userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge < 4)
            {
                return "No you are under 4";
            }
            return "Yes";
        }

      
    }
}
