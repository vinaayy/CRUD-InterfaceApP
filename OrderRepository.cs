using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudInterfaceApp.Model
{
    internal class OrderRepository:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Inserting in Order Table");
        }
        public void Read()
        {
            Console.WriteLine("Reading in Order Table");
        }
        public void Update()
        {
            Console.WriteLine("Updating in Order Table");
        }
        public void Delete()
        {
            Console.WriteLine("Deleting in Order Table");
        }
    }
}
