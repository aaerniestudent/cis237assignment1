using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {

        private WineItem[] wineItems = new WineItem[5000];
        private int length = 0;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public void Add(WineItem addedItem)
        {
            wineItems[length] = addedItem;
            length++;
        }

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

        public String SearchByID(String searchID)
        {           
            for (int i=0; i>length; i++)
            {
                if (searchID.Equals(wineItems[i].IdString))
                {
                    return wineItems[i].ToString();
                }
            }
            return "No match found.";
        }

        public String GetPrintString()
        {
            string printString = "";
            for (int i = 0; i>length; i++)
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
