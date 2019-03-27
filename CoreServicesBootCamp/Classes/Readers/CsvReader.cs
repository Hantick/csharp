using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServicesBootCamp.Classes.Readers
{
    class CsvReader
    {
        private InMemoryDatabase database;
        public CsvReader()
        {
            database = new InMemoryDatabase();
        }
        
        /// <summary>
        /// Czytnik plików CSV, wykorzystujący bibliotekę CsvHelper
        /// </summary>
        public InMemoryDatabase csvReader(String path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvHelper.CsvReader(reader))
            {

                // csv.Configuration.RegisterClassMap<OrderMapper>();
                csv.Configuration.HasHeaderRecord = true;
                // csv.Configuration.MissingFieldFound = null;
                csv.Configuration.Delimiter = ",";
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    String pricestr = csv.GetField<String>("Price");
                    Double price = Double.Parse(pricestr.Replace('.', ','));
                    database.createOrder(csv.GetField<String>("Client_Id"), csv.GetField<ulong>("Request_id"), csv.GetField<String>("Name"), csv.GetField<uint>("Quantity"), price);
                }

            }
            return database;
        }
    }
}
