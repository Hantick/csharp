using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreServicesBootCamp.Classes.Readers
{
    class JsonReader
    {
        struct tmp
        {
            public List<request> requests { get; set; }
        };
        private InMemoryDatabase database;
        public JsonReader()
        {
            database = new InMemoryDatabase();
        }

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
    }
}
