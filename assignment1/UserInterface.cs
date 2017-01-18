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
            Console.WriteLine("5. exit");                
        }

        public int MenuInput()
        {
            int i = 0;
            Boolean valid = false;
            while (!valid)
            {
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i >= 1 && i <= 5)
                    {
                        valid = true;
                    } else
                    {
                        Console.WriteLine("Please input a valid number");
                    }
                } catch
                {
                    Console.WriteLine("Please input a valid whole number");
                }
            }
            return i;
        }

        public void AddItem()
        {
            Console.WriteLine("Input ID number");
            String id = Console.ReadLine();
            Console.WriteLine("Input description");
            String description = Console.ReadLine();
            Console.WriteLine("Input pack size");
            String pack = Console.ReadLine();
            WineItem newItem = new WineItem(id, description, pack);
            WineItemCollection.Add(newItem);
        }
    }
}
