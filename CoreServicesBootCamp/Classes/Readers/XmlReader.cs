using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreServicesBootCamp.Classes.Readers
{
    class XmlReader
    {
        private InMemoryDatabase database;
        public XmlReader()
        {
            database = new InMemoryDatabase();
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
    }
}
