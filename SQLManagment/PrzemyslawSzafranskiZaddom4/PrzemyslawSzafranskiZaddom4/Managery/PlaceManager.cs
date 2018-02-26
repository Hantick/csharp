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
    public partial class PlaceManager : Form
    {
        public PlaceManager()
        {
            InitializeComponent();
        }
        DataClasses1DataContext context = new DataClasses1DataContext();
        /// <summary>
        /// metoda odświeżająca tabele DataGridView
        /// </summary>
        void RefreshPlaces()
        {
            var place = from places in context.Places select new { places.Id,places.Name, places.Street, places.City };
            dataGridView1.DataSource = place;
        }
        private void PlaceManager_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZD4DataSet.Places'
            this.placesTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.Places);
            RefreshPlaces();
        }

        private void addPlaceButton_Click(object sender, EventArgs e)
        {
             using (AddPlace placeAdder = new AddPlace())
              {
                  placeAdder.ShowDialog(this);
              }
              RefreshPlaces();

          }

          private void removePlaceButton_Click(object sender, EventArgs e)
          {


             int rowindex = dataGridView1.CurrentRow.Index;
              int iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
              var delete = from p in context.Places
                           where p.Id == iid
                           select p;
              context.Places.DeleteAllOnSubmit(delete);
              context.SubmitChanges();
              rowindex = 0;
              RefreshPlaces();



        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveToCSV(dataGridView1);
        }
        /// <summary>
        /// Edycja miejsca, wywolanie nowego okna AddPlace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editPlaceButton_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentRow.Index;
            int currentID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Places place = (from element in context.Places
                         where element.Id == currentID
                         select element).FirstOrDefault();

            Console.WriteLine("Imie obecne: "+place.Name);
            using (AddPlace placeEditor = new AddPlace(place))
            {

                placeEditor.ShowDialog(this);
            }
            context.SubmitChanges();
            Console.WriteLine("Zapisano");
            RefreshPlaces();
        }

        /// <summary>
        /// Przycisk wyszukujący po nazwie miejsca (Name z tabeli Places) - chciałem zrobić list boxa, z którego wybieramy w jakiej kolumnie szukamy ale niestety nie potrafiłem tego zrobić
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox == null || searchTextBox.Text == "")
            {
                RefreshPlaces();
            }
            else
            {
                var search = from result in context.Places
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

    }
}
