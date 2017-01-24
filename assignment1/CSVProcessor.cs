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

        public bool ProcessCSV(string pathToCSV,WineItemCollection collection)
        {
            StreamReader streamReader = null;
            bool working = true;
            try
            {
                string line;
                streamReader = new StreamReader(pathToCSV);
                int count = 0;
                while ((line = streamReader.ReadLine()) != null && working)
                {
                    working = ProcessLine(line, collection, count++);
                }
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        public bool ProcessLine(string line, WineItemCollection collection, int index)
        {
            string[] parts = line.Split(',');
            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];
            WineItem item = new WineItem(id, description, pack);
            collection.Add(item, index);
            return true;
        }


    }
}
