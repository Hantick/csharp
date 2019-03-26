
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using static CoreServicesBootCamp.Order;

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
                                    //jsonReader(file);
                                }
                                fileContent = reader.ReadToEnd();

                                MessageBox.Show(fileContent, "Ładowanie: " + file, MessageBoxButtons.OK);
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

        private void xmlReader(string file)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(file, settings);

            reader.MoveToContent();
            // Parse the file and display each of the nodes.
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<{0}>", reader.Name);
                        break;
                    case XmlNodeType.Text:
                        Console.Write(reader.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.Write("<![CDATA[{0}]]>", reader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.Write("<?{0} {1}?>", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.Write("<!--{0}-->", reader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.Write("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        Console.Write("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.Write(reader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</{0}>", reader.Name);
                        break;
                }
            }
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
             List<Order> listOfOrders = database.getOrders();

             foreach (Order it in listOfOrders)
             {
                 DataGridViewRow row = (DataGridViewRow) dataGridView1.RowTemplate.Clone();
                row.CreateCells(dataGridView1, it.getClientId(), it.getRequestId(), it.getName(), it.getQuantity(), it.getPrice());
                dataGridView1.Rows.Add(row);

             }
        }


    }
}
