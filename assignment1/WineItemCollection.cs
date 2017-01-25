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
    class WineItemCollection
    {

        //array to hold added wine items
        private WineItem[] wineItems = new WineItem[5000];
        //count of the items in the array
        private int length = 0;

        //length property
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        //not really necessary or used for the assignment, but could be useful
        public WineItem getWineItem(int index)
        {
            return wineItems[index];
        }

        //not really necessary or used for the assignment, but could be useful
        public WineItem getLastWineItem()
        {
            return wineItems[length - 1];
        }

        //this adds an item to the end of the list
        //this is used with the user additions
        public void Add(WineItem addedItem)
        {
            wineItems[length] = addedItem;
            length++;
        }

        //this adds an item from a decided index
        //this is used with loading from the CSV
        //Note: If an item is added and then a CSV is loaded that item will be overwritten
        public void Add(WineItem addedItem, int index)
        {
            if (wineItems[index] == null)
            {
                wineItems[index] = addedItem;
                length++;
            }
            else
            {
                wineItems[index] = addedItem;
            }            
        }

        //sequential search for matching ID
        public String SearchByID(String searchID)
        {           
            for (int i=0; i<length; i++)
            {
                if (searchID == wineItems[i].IdString)
                {
                    return wineItems[i].ToString();
                }
            }
            return "No match found.";
        }

        //returns huge string with all wine items
        public String GetPrintString()
        {
            string printString = "";
            for (int i = 0; i<length; i++)
            {
                if (wineItems[i] != null)
                {
                    printString += wineItems[i].ToString() + Environment.NewLine;
                }
            }
            return printString;
        }
    }
}
