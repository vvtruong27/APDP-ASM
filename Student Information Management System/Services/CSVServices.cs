using System.Collections.Generic;
using System.IO;

namespace StudentInformationManagementSystem.Services
{
    public class CSVServices
    {
        private readonly string filePath;

        public CSVServices(string filePath)
        {
            this.filePath = filePath;
        }

        public List<string[]> ReadData()
        {
            var data = new List<string[]>();
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    data.Add(line.Split(','));
                }
            }
            return data;
        }

        public void WriteData(List<string[]> data)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var row in data)
                {
                    writer.WriteLine(string.Join(",", row));
                }
            }
        }
    }
}
