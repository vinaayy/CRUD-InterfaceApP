using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaceApp.Model
{
    internal class CustomerRepository:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Inserting in Customer Table");
        }
        public void Read()
        {
            Console.WriteLine("Reading in Customer Table");
        }
        public void Update()
        {
            Console.WriteLine("Updating in Customer Table");
        }
        public void Delete()
        {
            Console.WriteLine("Deleting in Customer Table");
        }

    }
}
