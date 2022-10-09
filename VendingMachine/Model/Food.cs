using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public class Food : Product, IAllergy
    {
        private string? FoodType { get; set; }
        private string? FoodName { get; set; }
        public static int FoodId { get; set; }
        public int NextId()
        {
            FoodId++;
            return FoodId;
        }
        public Food()
        {

        }

        public Food(int productId, string? productName, int productPrice, string? foodName, string? foodType) : base(productId, productName, productPrice)
        {
            FoodName = foodName;
            FoodType = foodType;
        }

        public string AllergyCheck()
        {
            bool ? allergy = null;
            Console.WriteLine("Having any allergy? ");
            string input = Console.ReadLine();
            if(input == null)
            {
                return string.Empty;
            }
            return allergy.ToString();
        }

        public override string Examine()
        {
            return base.Examine() + $"\n{ProductName} {ProductPrice} kr\n{FoodType} {FoodName}";
        }

        public override string Use()
        {
            return base.Use() + "\nSo put it in your mounth and chew and swallow!";
        }
    }
}
