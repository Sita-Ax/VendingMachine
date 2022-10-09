using VendingMachine.Model;
using VendingMachine.Data;
using VendingMachine.Tests.Data;

namespace VendingMachine.Tests
{
    public class UnitTest1
    {
        //[Fact]
        //public void pururchaseTest()
        //{

        //    IVending vendingMachineData = new VendingMachineData();

        //    int expected = 3;

        //    Assert.Null(vendingMachineData.Purchase(3));
        //    vendingMachineData.InsertMoney(20);
        //    vendingMachineData.InsertMoney(5);

        //    Product result = vendingMachineData.Purchase(3);
        //    Assert.NotNull(result);
        //    Assert.Equal(expected, result.Id);
        //}

        //[Fact]
        //public void ShowAllTest()
        //{
        //    IVending vendingMachineData = new VendingMachineData();
        //    string expected = "4: DrinkOne 10";
        //    List<string> result = vendingMachineData.ShowAll();
        //    Assert.NotNull(result);
        //    Assert.Equal(expected, result[3]);
        //    Assert.Equal(5, result.Count);
        //}

        //[Fact]
        //public void DetailsTest()
        //{
        //    IVending vendingMachineData = new VendingMachineData();
        //    string expected = "2: price: 10: DrinkOne: Cola: Can: DescriptionOne Drink";
        //    string expectedTwo = "4: price: 10: DrinkOne: Cola: Can: DescriptionOne Drink";
        //    String result = vendingMachineData.Details(2);
        //    Assert.NotNull(result);
        //    Assert.Equal(expected, result);
        //    Assert.NotEqual(expectedTwo, result);

        //}

        //[Theory]
        //[InlineData(1, 1)]
        //[InlineData(5, 5)]
        //[InlineData(10, 10)]
        //[InlineData(20, 20)]
        //[InlineData(50, 50)]
        //[InlineData(100, 100)]
        //[InlineData(200, 200)]
        //[InlineData(500, 500)]
        //[InlineData(1000, 1000)]
        //public void InsertMoneyTest(int money, int expected)
        //{
        //    IVending vendingMachineData = new VendingMachineData();
        //    int result = vendingMachineData.InsertMoney(money);
        //    Assert.Equal(expected, result);

        //}


        //[Fact]

        //public void InsertMoneyTestTwo()
        //{
        //    IVending vendingMachineData = new VendingMachineData();
        //    string expected = " Your money are not of the right currency";

        //    var result = Assert.Throws<ArgumentException>(() => vendingMachineData.InsertMoney(2));
        //    Assert.Equal(expected, result.Message);

        //}

        //[Theory]
        //[InlineData(1, 1)]
        //[InlineData(5, 0)]
        //[InlineData(10, 0)]
        //[InlineData(20, 0)]
        //[InlineData(50, 1)]
        //[InlineData(100, 0)]
        //[InlineData(200, 2)]
        //[InlineData(500, 1)]
        //[InlineData(1000, 2)]
        //public void EndTransaction(int index, int expected)
        //{
        //    IVending vendingMachineData = new VendingMachineData();
        //    vendingMachineData.Clear();
        //    vendingMachineData.InsertMoney(1);
        //    vendingMachineData.InsertMoney(50);
        //    vendingMachineData.InsertMoney(100);
        //    vendingMachineData.InsertMoney(100);
        //    vendingMachineData.InsertMoney(200);
        //    vendingMachineData.InsertMoney(500);
        //    vendingMachineData.InsertMoney(1000);
        //    vendingMachineData.InsertMoney(1000);

        //    Dictionary<int, int> result = vendingMachineData.EndTransaction();
        //    Assert.NotNull(result);
        //    Assert.Equal(expected, result[index]);


        //}
    
//    [Fact]
//    public void CandyNewTest()
//    {
//        Candy product = new Candy(1);
//        int expected = 1;
//        int notExpected = 0;

//        Assert.NotEqual(notExpected, product.Id);
//        Assert.Equal(expected, product.Id);
//    }

//    [Fact]
//    public void CandyGetSetTest()
//    {
//        Candy product = new Candy(1);

//        product.PriceOfProduct = 2;
//        product.ProductName = "testName";
//        product.CandyType = "testType";
//        product.CandyDescription = "candyDeescription two";

//        int expected = 2;
//        int notExpected = 0;

//        Assert.NotEqual(notExpected, product.PriceOfProduct);
//        Assert.Equal(expected, product.PriceOfProduct);
//        Assert.NotNull(product.ProductName);
//        Assert.NotNull(product.CandyType);
//        Assert.NotNull(product.CandyDescription);
//        Assert.Equal("testName", product.ProductName);
//        Assert.Equal("testType", product.CandyType);
//        Assert.Equal("candyDeescription two", product.CandyDescription);
//    }

//    [Fact]
//    public void CandyExamineUseTest()
//    {
//        Candy product = new Candy(1);
//        product.PriceOfProduct = 2;
//        product.ProductName = "testName";
//        product.CandyType = "testType";
//        product.CandyDescription = "candyDeescription two";

//        string expected = "Open the rapper and eat your candy";
//        string expectedTwo = "1: price: 2: testName: testType: candyDeescription two";

//        Assert.NotNull(product.Examine());
//        Assert.Equal(expectedTwo, product.Examine());
//        Assert.NotNull(product.Examine());
//        Assert.Equal(expected, product.Use());
//    }
//    [Fact]
//    public void DrinkNewTest()
//    {
//        Drink product = new Drink(1);
//        int expected = 1;
//        int notExpected = 0;

//        Assert.NotEqual(notExpected, product.Id);
//        Assert.Equal(expected, product.Id);
//    }

//    [Fact]
//    public void DrinkGetSetTest()
//    {
//        Drink product = new Drink(1);

//        product.PriceOfProduct = 2;
//        product.ProductName = "testName";
//        product.BeverageType = "testType";
//        product.PackageType = "Bottle";
//        product.BeverageDescription = "candyDeescription two";

//        int expected = 2;
//        int notExpected = 0;

//        Assert.NotEqual(notExpected, product.PriceOfProduct);
//        Assert.Equal(expected, product.PriceOfProduct);
//        Assert.NotNull(product.ProductName);
//        Assert.NotNull(product.BeverageType);
//        Assert.NotNull(product.PackageType);
//        Assert.NotNull(product.BeverageDescription);
//        Assert.Equal("testName", product.ProductName);
//        Assert.Equal("testType", product.BeverageType);
//        Assert.Equal("Bottle", product.PackageType);
//        Assert.Equal("candyDeescription two", product.BeverageDescription);
//    }

//    [Fact]
//    public void DrinkExamineUseTest()
//    {
//        Drink product = new Drink(1);
//        product.PriceOfProduct = 2;
//        product.ProductName = "testName";
//        product.BeverageType = "testType";
//        product.PackageType = "can";
//        product.BeverageDescription = "candyDeescription two";

//        string expected = " Open the cap and you can now drink from the bottle.";
//        string expectedOne = " Bend the opener to uprigth posion and then bend it back to original posion. You can now drink from the can.";
//        string expectedTwo = "1: price: 2: testName: testType: Bottle: candyDeescription two";

//        Assert.Equal(expectedOne, product.Use());
//        Assert.NotEqual(expectedTwo, product.Examine());
//        product.PackageType = "Bottle";

//        Assert.NotNull(product.Examine());
//        Assert.Equal(expectedTwo, product.Examine());
//        Assert.NotNull(product.Examine());
//        Assert.Equal(expected, product.Use());

//    }
//}
//[Fact]
//public void FoodNewTest()
//{
//    Food product = new Food(1);
//    int expected = 1;
//    int notExpected = 0;

//    Assert.NotEqual(notExpected, product.Id);
//    Assert.Equal(expected, product.Id);
//}

//[Fact]
//public void FoodGetSetTest()
//{
//    Food product = new Food(1);

//    product.PriceOfProduct = 2;
//    product.ProductName = "testName";
//    product.FoodType = "testType";
//    product.FoodDescription = "foodDeescription two";

//    int expected = 2;
//    int notExpected = 0;

//    Assert.NotEqual(notExpected, product.PriceOfProduct);
//    Assert.Equal(expected, product.PriceOfProduct);
//    Assert.NotNull(product.ProductName);
//    Assert.NotNull(product.FoodType);
//    Assert.NotNull(product.FoodDescription);
//    Assert.Equal("testName", product.ProductName);
//    Assert.Equal("testType", product.FoodType);
//    Assert.Equal("foodDeescription two", product.FoodDescription);
//}

//[Fact]
//public void FoodExamineUseTest()
//{
//    Food product = new Food(1);
//    product.PriceOfProduct = 2;
//    product.ProductName = "testName";
//    product.FoodType = "Salad";
//    product.FoodDescription = "foodDescription two";

//    string expected = " Unrapp the sandwich and eat it";
//    string expectedOne = " Remove the lid and take the fork and knife and start to eat.";
//    string expectedTwo = "1: price: 2: testName: Sandwich: foodDescription two ";

//    Assert.Equal(expectedOne, product.Use());

//    product.FoodType = "Sandwich";

//    Assert.NotNull(product.Examine());
//    Assert.Equal(expectedTwo, product.Examine());
//    Assert.NotNull(product.Examine());
//    Assert.Equal(expected, product.Use());
//}
//    }


    }
}