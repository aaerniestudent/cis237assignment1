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
    class WineItem
    {
        private String idString;
        private String descriptionString;
        private String packString;

        //id property
        public String IdString
        {
            get { return idString; }
            set { idString = value; }
        }

        //default constructor (not used)
        public WineItem()
        {
        }

        //constructor with id, description, and pack inputs
        public WineItem(String id, String description, String pack)
        {
            idString = id;
            descriptionString = description;
            packString = pack;
        }

        //ToString override returning the item as "id,description,pack"
        public String ToString()
        {
            return idString + "," + descriptionString + "," + packString;
        }
    }
}
