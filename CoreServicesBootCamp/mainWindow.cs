﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;
using Microsoft.VisualBasic;

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
  
        /// <summary>
        /// Funkcja czyszcząca bazę danych oraz wyświetlanie w dataGridView'ach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wyczyśćBazęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
           
            database.clearOrders();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.Rows.Clear();
            refreshData();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)  
        {
        }
        /// <summary>
        /// Obsługa przycisku do generowania raportów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    ilośćZamówieńToolStripMenuItem_Click(sender, e);
                    break;
                case 1:
                    ilośćZamówieńDlaKlientaToolStripMenuItem_Click(sender, e);
                    break;
                case 2:
                    cToolStripMenuItem_Click(sender, e);
                    break;
                case 3:
                    łToolStripMenuItem_Click(sender, e);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 10:
                    zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem_Click(sender, e);
                    break;
            }
        }


        //************************************************************************************************************
        //FUNKCJE GENERUJĄCE RAPORTY
        //************************************************************************************************************
        #region IloscZamowien raport         

        /// <summary>
        /// Ilosc zamowien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ilośćZamówieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("quantity", "Quantity");
                DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                row.CreateCells(dataGridView2, database.getAmountOfRequests());
                dataGridView2.Rows.Add(row);


            }
        }
        #endregion
        #region IloscZamowien dla klienta o id raport
        /// <summary>
        /// Ilosc zamowien dla klienta o wskazanym id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ilośćZamówieńDlaKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                String clientId = Microsoft.VisualBasic.Interaction.InputBox("Podaj ID klienta, którego ilość zamówień chcesz wyświetlić", "Generowanie raportu ilości zamówień dla klienta...", "0");
                if(clientId.Equals(""))
                {
                    
                    return;
                }
                else if (database.clientExists(clientId) == false)
                {
                    MessageBox.Show(this, "{0} Podane Client_Id nie istnieje w bazie! Upewnij się, że wprowadziłeś odpowiednią liczbę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                comboBox1.SelectedIndex = 1;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("quantity", "Quantity");
                DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                row.CreateCells(dataGridView2, database.getClientAmountOfRequests(clientId));
                dataGridView2.Rows.Add(row);

                
            }
        }
        #endregion
        #region ŁącznaKwotaZamowien raport 
        /// <summary>
        /// Łączna kwota zamówień
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                comboBox1.SelectedIndex = 2;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("quantity", "Quantity");
                DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                row.CreateCells(dataGridView2, database.getTotalPrice());
                dataGridView2.Rows.Add(row);


            }
        }
        #endregion
        #region ŁącznaKwotaZamowien dla klienta o id raport
        /// <summary>
        /// Łączna kwota zamówień dla klienta o wskazanym id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void łToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                String clientId = Microsoft.VisualBasic.Interaction.InputBox("Podaj ID klienta, którego ilość zamówień chcesz wyświetlić", "Generowanie raportu ilości zamówień dla klienta...", "0");
                if (clientId.Equals(""))
                {

                    return;
                }
                else if (database.clientExists(clientId) == false)
                {
                    MessageBox.Show(this, "{0} Podane Client_Id nie istnieje w bazie! Upewnij się, że wprowadziłeś odpowiednią liczbę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                comboBox1.SelectedIndex = 1;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("quantity", "Quantity");
                DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                row.CreateCells(dataGridView2, database.getClientTotalPrice(clientId));
                dataGridView2.Rows.Add(row);
            }
        }
        #endregion




        #region IloscZamowien z sortowaniem raport
        /// <summary>
        /// Ilosc zamowien, sortowane po nazwie przedmiotów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ilośćZamówieńpoNazwieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                comboBox1.SelectedIndex = 8;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("name", "Name");
                dataGridView2.Columns.Add("quantity", "Quantity");
                
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



                    DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                    row.CreateCells(dataGridView2, str, count);
                    dataGridView2.Rows.Add(row);

                }
                dataGridView2.Sort(dataGridView2.Columns["name"], ListSortDirection.Ascending);
            }
        }
        #endregion
        #region IloscZamowien dla klienta o id z sortowaniem raport
        /// <summary>
        /// Ilosc zamowien dla klienta o wskazanym id, sortowane po nazwie przedmiotów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                String clientId = Microsoft.VisualBasic.Interaction.InputBox("Podaj ID klienta, którego ilość zamówień chcesz wyświetlić", "Generowanie raportu ilości zamówień dla klienta...", "0");
                if (clientId.Equals(""))
                {

                    return;
                }
                else if (database.clientExists(clientId) == false)
                {
                    MessageBox.Show(this, "{0} Podane Client_Id nie istnieje w bazie! Upewnij się, że wprowadziłeś odpowiednią liczbę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                comboBox1.SelectedIndex = 1;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("name", "Name");
                dataGridView2.Columns.Add("quantity", "Quantity");

                List<String> products = new List<String>();
                String tmp;
                //Odseparowanie różnych produktów
                foreach (request req in listOfOrders)
                {
                    tmp = req.getName();
                    if (products.Contains(tmp) == false && req.getClientId() == clientId)
                        products.Add(tmp);
                }
                //Sprawdź każdy produkt, ile sie zawiera
                uint count = 0;
                foreach (String str in products)
                {
                    count = 0;
                    foreach (request req in listOfOrders)
                    {
                        if (req.getName() == str && req.getClientId() == clientId)
                        {
                            count += req.getQuantity();
                        }
                    }



                    DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                    row.CreateCells(dataGridView2, str, count);
                    dataGridView2.Rows.Add(row);

                }
                dataGridView2.Sort(dataGridView2.Columns["name"], ListSortDirection.Ascending);
            }
        }
        #endregion
        #region ZamówieniaWPodanymPrzedziale raport
        /// <summary>
        /// Zamówienia w podanym przedziale cenowym.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RangeSelector selector = new RangeSelector();
            selector.Owner = this;
            selector.ShowDialog();
            double min;
            double max;
            //min = selector.Check;
        }

        #endregion


    }
}
