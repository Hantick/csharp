using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CoreServicesBootCamp
{
    public partial class mainWindow : Form
    {
        InMemoryDatabase database;
        public mainWindow()
        {
            InitializeComponent();
            database = new InMemoryDatabase();
            this.Show();
            loadFiles();
        }


        private void wczytajBazęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFiles();
        }
        /// <summary>
        /// Funkcja wczytująca informacje z plików *.csv, *.xml, *.json do bazy InMemoryDatabase przez okno dialogowe
        /// </summary>
        private void loadFiles()
        {
            var fileContent = string.Empty;
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    openFileDialog.Filter = "All files (*.csv,*.xml,*.json)|*.csv;*.xml;*.json|csv files (*.csv)|*.csv|xml files (*.xml)|*.xml|json files (*.json)|*.json";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Multiselect = true;
                    openFileDialog.Title = "Ładowanie plików do bazy";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        foreach (String file in openFileDialog.FileNames)
                        {
                            openFileDialog.FileName = file;

                            var fileStream = openFileDialog.OpenFile();
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                if (file.Contains(".csv"))
                                {
                                    csvReader(file);
                                }
                                else if (file.Contains(".xml"))
                                {
                                    xmlReader(file);
                                }
                                else if (file.Contains(".json"))
                                {
                                    jsonReader(file);
                                }
                               // fileContent = reader.ReadToEnd();

                             //   MessageBox.Show(fileContent, "Ładowanie: " + file, MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (CsvHelper.MissingFieldException)
            {
                MessageBox.Show(this, "{1} Błąd. - nie można znaleźć odpowiednich rubryk w pliku CSV. Upewnij się, że roszerzenie (.csv) oraz format nagłówków jest odpowiedni", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "{0} Błąd." + ex, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        struct tmp {
           public List<request> requests { get; set; }
        };
        /// <summary>
        /// Czytnik plików JSON.
        /// </summary>
        private void jsonReader(string file)
        {
            
            string jsonString = File.ReadAllText(file, Encoding.UTF8);
            tmp requests = JsonConvert.DeserializeObject<tmp>(jsonString);
            foreach (request req in requests.requests)
            {
                database.createOrder(req);
            }
            refreshData();
        }
        /// <summary>
        /// Czytnik plików XML.
        /// </summary>
        private void xmlReader(string file)
        {
            string xmlString = File.ReadAllText(file, Encoding.UTF8);
            StringReader strreader = new StringReader(xmlString);
            XmlSerializer ser = new XmlSerializer(typeof(List<request>), new XmlRootAttribute("requests"));
            List<request> orders = 
                (List<request>)ser.Deserialize(strreader);
            foreach(request or in orders)
            {
                database.createOrder(or);
            }
            strreader.Close();
            refreshData();
           
        }

        /// <summary>
        /// Czytnik plików CSV, wykorzystujący bibliotekę CsvHelper
        /// </summary>
        private void csvReader(String path)
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
                refreshData();
            }
        }

        private void refreshData()
        {
            
             List<request> listOfOrders = database.getOrders();
            if(listOfOrders.Count!=0)
            {
                comboBox1.Enabled = true;
            }
            dataGridView1.Rows.Clear();
            foreach (request it in listOfOrders)
             {
                 DataGridViewRow row = (DataGridViewRow) dataGridView1.RowTemplate.Clone();
                row.CreateCells(dataGridView1, it.getClientId(), it.getRequestId(), it.getName(), it.getQuantity(), it.getPrice());
                dataGridView1.Rows.Add(row);

             }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ilośćZamówieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                textBox1.AppendText("Raport ilości zamówień:\n");
               
                List<String> products = new List<String>();
                String tmp;
                //Odseparowanie różnych produktów
                foreach (request req in listOfOrders)
                {
                    tmp = req.getName();
                    if (products.Contains(tmp) == false)
                        products.Add(tmp);
                }
                //Sprawdź każdy produkt, ile sie zawiera
                uint count = 0;
                foreach (String str in products)
                {
                    count = 0;
                    foreach (request req in listOfOrders)
                    {
                        if (req.getName() == str)
                        {
                            count += req.getQuantity();
                        }
                    }
                    textBox1.AppendText(str + ", ilość: " + count+"\n");

                }
            }
        }

        private void wyczyśćBazęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.clearOrders();
            dataGridView1.Rows.Clear();
            refreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
