using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    //Put in the baseClass to get the propites it has
    public class Drink : Product, IAge
    {
        //Maked of the enum
        private DrinksUnit? DrinksUnit { get; set; }
        public int UserAge { get; set; }
        public static int DrinkId { get; set; }
        public int AgeLimit { get; set; }

        public int NextId()
        {
            DrinkId++;
            return DrinkId;
        }
        public Drink()
        {
        }
        //Build a drink of this constructur
        public Drink(int productId, string? productName, int productPrice, DrinksUnit diffrentSort, bool ageControll) : base(productId, productName, productPrice)
        {
            DrinksUnit = diffrentSort;
            AgeLimit = ageControll ? 1 : 0;
        }


        //Like Info
        public override string Examine()
        {
            return base.Examine() + $"\n{ProductName} {ProductPrice} kr\n{DrinksUnit}";
        }

        //Use like how to use 
        public override string Use()
        {
            return base.Use() + "\nJust drink up!";
        }
        public bool PassAgeLimit(int age)
        {
            if (age > AgeLimit) { return true; }
            else { return false; }
        }
    }
}
