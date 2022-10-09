using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Tests.Data
{
    public interface IVending
    {
        //[Fact]
        //public void pururchaseTest()
        //{

        //    IVending vendingMachineData = new IVending();

        //    int expected = 3;

        //    Assert.Null(vendingMachineData.Purchase(3));
        //    vendingMachineData.InsertMoney(20);
        //    vendingMachineData.InsertMoney(5);

        //    Product result = vendingMachineData.Purchase(3);
        //    Assert.NotNull(result);
        //    Assert.Equal(expected, result.ProductId);
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
    }
}
