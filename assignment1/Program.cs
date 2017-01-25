//Anthony Aernie
//CIS237 MW 6:00
//Jan 25, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {

        public static WineItemCollection collection = new WineItemCollection();
        public static UserInterface UI = new UserInterface();
        public static CSVProcessor processor = new CSVProcessor();
        public static Boolean loaded = false;
        public static int choice = 0;
        public static string pathToCSV = "../../../datafiles/WineList.csv";

        static void Main(string[] args)
        {
            UI.Menu();
            //5 exits the program
            while (choice != 5)
            {                
                choice = UI.MenuInput();
                UI.Clear();
                switch (choice)
                {
                    case 1:
                        {
                            //load CSV
                            bool good = processor.ProcessCSV(pathToCSV, collection);
                            if (good)
                            {
                                UI.Output("File read successful");
                            } else {
                                UI.Output("File read failure");
                            }
                            UI.Menu();
                            break;
                        }
                    case 2:
                        {
                            //print entire list
                            if (collection.Length == 0)
                            {
                                string s = collection.GetPrintString();
                                UI.Output(s);
                            } else
                            {
                                //if there are no items in the collection
                                UI.Output("There are no items in the collection");
                            }
                            UI.Menu();
                            
                            break;
                        }
                    case 3:
                        {
                            //search by id
                            if (collection.Length == 0)
                            {
                                string search = UI.searchById();
                                UI.Output(collection.SearchByID(search));
                            } else
                            {
                                //if there are no items in the collection
                                UI.Output("There are no items in the collection");
                            }
                            UI.Menu();
                            break;
                        }
                    case 4:
                        {                            
                            //add item
                            WineItem addItem = UI.AddItem();
                            collection.Add(addItem);
                            UI.Output("Item added");
                            UI.Menu();
                            break;
                        }
                    default: break;
                }
            }


        }
    }
}
