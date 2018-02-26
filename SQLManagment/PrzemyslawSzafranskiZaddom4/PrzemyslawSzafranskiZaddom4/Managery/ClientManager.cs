using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemyslawSzafranskiZaddom4
{
    public partial class ClientManager : Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public ClientManager()
        {
            InitializeComponent();
        }

        void RefreshClients()
        {
            var client = from clients in context.Clients select new { clients.Id,clients.Name, clients.Surname, clients.PESEL, clients.PhoneNumber, clients.EMail };
            dataGridView1.DataSource = client;
            dataGridView1.Columns[1].HeaderText = "Imię";
            dataGridView1.Columns[2].HeaderText = "Nazwisko";
            dataGridView1.Columns[4].HeaderText = "Telefon";
            dataGridView1.Columns[5].HeaderText = "E-mail";
        }
        private void PlaceManager_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZD4DataSet.Clients' . Możesz go przenieść lub usunąć.
            this.clientsTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.Clients);

            RefreshClients();
        }

        private void addPlaceButton_Click(object sender, EventArgs e)
        {
            using (AddClient clientAdder = new AddClient())
            {
                clientAdder.ShowDialog(this);
            }
            RefreshClients();
        }

        private void removePlaceButton_Click(object sender, EventArgs e)
        {
            
            int iid = 0;
            int rowindex = dataGridView1.CurrentRow.Index;
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var delete = from p in context.Clients
                         where p.Id == iid
                         select p;
            context.Clients.DeleteAllOnSubmit(delete);
            context.SubmitChanges();
            rowindex = 0;
            RefreshClients();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            int currentID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Clients client = (from element in context.Clients
                            where element.Id == currentID
                            select element).FirstOrDefault();
            using (AddClient clientEditor = new AddClient(client))
            {

                clientEditor.ShowDialog(this);
            }
            context.SubmitChanges();
            RefreshClients();
        }
        /// <summary>
        /// Analogiczna funkcja szukająca jak w PlaceManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox == null || searchTextBox.Text == "")
            {
                RefreshClients();
            }
            else
            {
                var search = from result in context.Clients
                             where result.Name == searchTextBox.Text
                             select result;
                dataGridView1.DataSource = search;
            }
        }
        private void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Błąd w zapisie tabeli" + ex.Message);
                    }
                }
                int columnCount = DGV.ColumnCount;
                string columnNames = "";
                string[] output = new string[DGV.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += DGV.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < DGV.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Plik został zapisany");
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveToCSV(dataGridView1);
        }
    }
}
