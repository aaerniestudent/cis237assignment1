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

        private static StreamReader inputFile;
        private static string inputFileName = "datafiles/WineList.csv";

        static public Boolean ReadCSV()
        {
            
            return true;
        }

        static private Boolean OpenFile(ref StreamReader iFile, ref string iFileString)
        {
            try
            {
                if (File.Exists(iFileString))
                {
                    iFile = File.OpenText(iFileString);
                    return true;
                }
                return false;
            }
            catch
            {
                Console.WriteLine("Fail open file");
                return false;
            }
        }


    }
}
