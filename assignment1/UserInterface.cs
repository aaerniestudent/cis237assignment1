using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public void Menu()
        {
            Console.WriteLine("1. load CSV");
            Console.WriteLine("2. print entire list");
            Console.WriteLine("3. search by ID");
            Console.WriteLine("4. add item");                      
        }

        public int MenuInput()
        {
            return 1;
        }

        public void AddItem()
        {
            Console.WriteLine("Input ID number");
            String id = Console.ReadLine();
            Console.WriteLine("Input description");
            String description = Console.ReadLine();
            Console.WriteLine("Input pack size");
            String pack = Console.ReadLine();
            //WineItemCollection.Add();
        }
    }
}
