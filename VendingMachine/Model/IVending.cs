using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    public interface IVending
    {
        public Product? Purchase(int productId);

       // public List<string> ShowAll();

        public void Details();

        public void InsertMoney();
        Dictionary<int, int> EndTransaction();
        List<Product> ListsOfProduct();
    }
}
