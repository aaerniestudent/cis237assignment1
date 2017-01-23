using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class CSVProcessor
    {

        private StreamReader inputFile;
        private string iFileString = "../../../datafiles/WineList.csv";

        public Boolean ReadCSV()
        {
            
            return true;
        }

        private Boolean OpenFile()
        {
            try
            {
                if (File.Exists(iFileString))
                {
                    inputFile = File.OpenText(iFileString);
                    return true;
                }
                return false;
            }
            catch
            {
                
                return false;
            }
        }

        
    }
}
