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

        public void Constructor()
        {
            idString = "00000";
            descriptionString = "Default";
            packString = "0 ml";
        }

        public void Constructor(String id, String description, String pack)
        {
            idString = id;
            descriptionString = description;
            packString = pack;
        }

        public String toString()
        {
            return idString + "," + descriptionString + "," + packString;
        }
    }
}
