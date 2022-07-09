using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaceApp.Model
{
    internal class ProductRepository:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Inserting in Product Table");
        }
        public void Read()
        {
            Console.WriteLine("Reading in Product Table");
        }
        public void Update()
        {
            Console.WriteLine("Updating in Product Table");
        }
        public void Delete()
        {
            Console.WriteLine("Deleting in Product Table");
        }
    }
}
