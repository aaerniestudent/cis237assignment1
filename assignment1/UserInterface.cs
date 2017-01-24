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
            Console.WriteLine("3. add item");
            Console.WriteLine("4. search by id");
            Console.WriteLine("5. exit");                
        }

        public int MenuInput()
        {
            string input = Console.ReadLine();  
            while (input != "1" && input != "2" 
                && input != "3" && input != "4"
                && input != "5")
            {
                InputError();
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }

        //Recieves input for a new wine item and returns it as a single wine item
        public WineItem AddItem()
        {
            Console.WriteLine("Input ID number");
            String id = Console.ReadLine();
            Console.WriteLine("Input description");
            String description = Console.ReadLine();
            Console.WriteLine("Input pack size");
            String pack = Console.ReadLine();
            return new WineItem(id, description, pack);            
        }

        public string searchById()
        {
            Console.WriteLine("Please input 5 character ID number.");            
            return Console.ReadLine();
        }

        public void Output(string s)
        {
            Console.WriteLine(s);
        }

        public void Clear()
        {
            Console.Clear();
        }

        private void InputError()
        {
            Console.WriteLine("Error: invalid input; please input the number associated with the menu choice you want.");
        }

    }
}
