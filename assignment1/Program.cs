using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {

        public WineItemCollection collection = new WineItemCollection();
        public static UserInterface UI = new UserInterface();
        public static CSVProcessor processor = new CSVProcessor();
        public static Boolean loaded = false;
        public static int choice = 0;

        static void Main(string[] args)
        {
            UI.Menu();
            while (choice != 5)
            {
                choice = UI.MenuInput();
                switch (choice)
                {
                    case 1:
                        {
                            //load CSV

                            UI.Menu();
                            break;
                        }
                    case 2:
                        {
                            //print entire list

                            UI.Menu();
                            break;
                        }
                    case 3:
                        {
                            //add item

                            UI.Menu();
                            break;
                        }
                    case 4:
                        {
                            //search by id

                            UI.Menu();
                            break;
                        }
                    default: break;
                }
            }
            
            

        }
    }
}
