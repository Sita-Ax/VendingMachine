using System.Net;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using VendingMachine.Data;
using VendingMachine.Model;

namespace VendingMachine
{
    public class Program
    {
        VendingMachineData vm = new VendingMachineData();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            VendingMachineData vm = new VendingMachineData();
            vm.RunVendingMachine();
        }
       
    }
}