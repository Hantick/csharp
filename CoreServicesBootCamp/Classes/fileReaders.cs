using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreServicesBootCamp
{
    class fileReaders
    {
        InMemoryDatabase database;
        struct tmp
        {
            public List<request> requests { get; set; }
        };
        /// <summary>
        /// Czytnik plików JSON.
        /// </summary>
        public InMemoryDatabase jsonReader(string file)
        {

            string jsonString = File.ReadAllText(file, Encoding.UTF8);
            tmp requests = JsonConvert.DeserializeObject<tmp>(jsonString);
            foreach (request req in requests.requests)
            {
                database.createOrder(req);
            }
            return database;
        }
        /// <summary>
        /// Czytnik plików XML.
        /// </summary>
        public InMemoryDatabase xmlReader(string file)
        {
            string xmlString = File.ReadAllText(file, Encoding.UTF8);
            StringReader strreader = new StringReader(xmlString);
            XmlSerializer ser = new XmlSerializer(typeof(List<request>), new XmlRootAttribute("requests"));
            List<request> orders =
                (List<request>)ser.Deserialize(strreader);
            foreach (request or in orders)
            {
                database.createOrder(or);
            }
            strreader.Close();
            return database;
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
