using System;
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
        fileReaders filereaders;
        public mainWindow()
        {
            InitializeComponent();
            database = new InMemoryDatabase();
            this.Show();
            loadFiles();
            refreshData();
        }

        #region Wczytywanie plików
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
                                    database.addOrders(filereaders.csvReader(file));
                                    refreshData();
                                }
                                else if (file.Contains(".xml"))
                                {
                                    filereaders.xmlReader(file);
                                    refreshData();
                                }
                                else if (file.Contains(".json"))
                                {
                                    filereaders.jsonReader(file);
                                    refreshData();
                                }
                                // fileContent = reader.ReadToEnd();
                                database.check();
                                
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
        #endregion

        private void refreshData()
        {

            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count != 0)
            {
                comboBox1.Enabled = true;
            }
            dataGridView1.Rows.Clear();
            foreach (request it in listOfOrders)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.RowTemplate.Clone();
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
                    listaZamówieńDlaKlientaToolStripMenuItem_Click(sender, e);
                    break;
                case 5:
                    break;
                case 7:
                    ilośćZamówieńpoNazwieToolStripMenuItem_Click(sender, e);
                    break;
                case 8:
                    ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem_Click(sender, e);
                    break;
                case 9:
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
                comboBox1.SelectedIndex = 3;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("quantity", "Quantity");
                DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                row.CreateCells(dataGridView2, database.getClientTotalPrice(clientId));
                dataGridView2.Rows.Add(row);
            }
        }
        #endregion
        #region ListaZamówień dla klienta o id raport
        /// <summary>
        /// Lista zamowien dla klienta o id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaZamówieńDlaKlientaToolStripMenuItem_Click(object sender, EventArgs e)
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
                comboBox1.SelectedIndex = 4;
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns.Add("requestId", "Request_id");
                dataGridView2.Columns.Add("quantity", "Quantity");
                dataGridView2.Columns.Add("name", "Name");
                dataGridView2.Columns.Add("price", "Price");
                foreach (request req in listOfOrders)
                {
                    if(req.getClientId()==clientId)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                        row.CreateCells(dataGridView2, req.getRequestId(),req.getQuantity(),req.getName(),req.getPrice());
                        dataGridView2.Rows.Add(row);
                    }
                }
                



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
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            List<request> listOfOrders = database.getOrders();
            if (listOfOrders.Count == 0)
            {
                MessageBox.Show(this, "{0} Baza danych jest pusta! Nie można wygenerować raportu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RangeSelector selector = new RangeSelector();
            selector.Owner = this;
            double min;
            double max;

            var result = selector.ShowDialog();
            if (result == DialogResult.OK)
            {
                min = selector.min;
                max = selector.max;
                selector.Close();
            }
            else
            {
                return;
            }
            comboBox1.SelectedIndex = 10;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add("name", "Name");
            dataGridView2.Columns.Add("quantity", "Quantity");
            dataGridView2.Columns.Add("price", "Price");
            foreach (request req in listOfOrders)
            {
                if(req.getPrice()>=min && req.getPrice()<=max)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.RowTemplate.Clone();
                    row.CreateCells(dataGridView2, req.getName(),req.getQuantity(),req.getPrice());
                    dataGridView2.Rows.Add(row);
                }
            }
        }
        #endregion
    }
}
