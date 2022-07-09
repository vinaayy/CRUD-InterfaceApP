using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudInterfaceApp.Model;

namespace CrudInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDBOperations(new CustomerRepository());
            DoDBOperations(new OrderRepository());
            DoDBOperations(new ProductRepository());
        }
        public static void DoDBOperations(ICrudable  obj)
        {
            Console.WriteLine("\nDoing DB Opertation");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();
        }
    }
}
