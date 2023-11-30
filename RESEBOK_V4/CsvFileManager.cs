using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESEBOK_V4;
using System.IO;
using System.Threading.Channels;

namespace RESEBOK_V4
{
    public class CsvFileManager
    {
        private string filePath;

        public CsvFileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveDestinations(List<Destination> destinations)
        {
            string text = "This is a random text";

            //skapar en ny objekt för att skriva.
            StreamWriter writer = new StreamWriter("DestinationCSV");

            //skriver en linje
            writer.WriteLine(text);

            Console.WriteLine("the File was Created!");

            //stänger funktionen
            writer.Close();
        }

    }
}
