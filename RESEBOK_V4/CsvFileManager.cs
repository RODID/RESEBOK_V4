using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESEBOK_V4;
using System.IO;
using System.Threading.Channels;
using System.Globalization;
using CsvHelper;

namespace RESEBOK_V4
{

    /*    Unused filePath Field: The filePath 
        field in CsvFileManager is declared but not used. 
        If you plan to use it in the future, keep it. Otherwise, 
        you can remove it.

        Hardcoded File Name: You have hardcoded the file name
        "DestinationCSV" in StreamWriter. If you want to use the 
        filePath variable, consider using it in the StreamWriter constructor.*/
    public class CsvFileManager
    {
        private readonly string filePath;

        public CsvFileManager(string Destinations)
        {
            this.filePath = Path.Combine(Directory.GetCurrentDirectory(), Destinations);
        }

        public void SaveDestinations(List<Destination> destinations)
        {
            using (StreamWriter writer = new StreamWriter("destinations.csv"))
            using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(destinations);
            }
        }
        public List<Destination> LoadDestinations()
        {
            if(File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader("destinations.csv"))
                using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<Destination>().ToList();
                }
            }
            else
            {
                return new List<Destination>();
            }
        }

    }
}
