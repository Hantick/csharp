using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemyslawSzafranskiZaddom4
{
    public partial class AddPerformance : Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        EventsPerformance currentPerformance = null;
        public AddPerformance()
        {

            InitializeComponent();
            //tabela imprez
            var query =
            from post in context.EventTypes
            join meta in context.Events on post.Id equals meta.EventTypeID
            where post.Id == meta.EventTypeID
            select new { Id = meta.Id, Type = post.EventType, Distance = meta.Distance, FuelCost = meta.FuelCost, AmountOfPeople = meta.AmoutOfPeople, EventCost = meta.EventCost };
            eventsDataGridView.DataSource = query;
            eventsDataGridView.Columns[0].HeaderText = "Id";
            eventsDataGridView.Columns[0].Width = 32;
            eventsDataGridView.Columns[1].HeaderText = "Typ Imprezy";
            eventsDataGridView.Columns[1].Width = 180;
            eventsDataGridView.Columns[2].HeaderText = "Dystans[km]";
            eventsDataGridView.Columns[2].Width = 80;
            eventsDataGridView.Columns[3].HeaderText = "Koszt dojazdu";
            eventsDataGridView.Columns[4].HeaderText = "Liczba osób";
            eventsDataGridView.Columns[4].Width = 75;
            eventsDataGridView.Columns[5].HeaderText = "Kwota";
            eventsDataGridView.Columns[5].Width = 65;
            //koniec tabeli imprez
            //tabela klientów
            var client = from clients in context.Clients select new { clients.Id, clients.Name, clients.Surname, clients.PESEL, clients.PhoneNumber, clients.EMail };
            clientsDataGridView.DataSource = client;
            clientsDataGridView.Columns[1].HeaderText = "Imię";
            clientsDataGridView.Columns[2].HeaderText = "Nazwisko";
            clientsDataGridView.Columns[4].HeaderText = "Telefon";
            clientsDataGridView.Columns[5].HeaderText = "E-mail";
            //koniec tabeli klientów
        }

        public AddPerformance(EventsPerformance performance)
        {
            InitializeComponent();
            currentPerformance = performance;
            var query =
            from post in context.EventTypes
            join meta in context.Events on post.Id equals meta.EventTypeID
            where post.Id == meta.EventTypeID
            select new { Id = meta.Id, Type = post.EventType, Distance = meta.Distance, FuelCost = meta.FuelCost, AmountOfPeople = meta.AmoutOfPeople, EventCost = meta.EventCost };
            eventsDataGridView.DataSource = query;
            eventsDataGridView.Columns[0].HeaderText = "Id";
            eventsDataGridView.Columns[0].Width = 32;
            eventsDataGridView.Columns[1].HeaderText = "Typ Imprezy";
            eventsDataGridView.Columns[1].Width = 180;
            eventsDataGridView.Columns[2].HeaderText = "Dystans[km]";
            eventsDataGridView.Columns[2].Width = 80;
            eventsDataGridView.Columns[3].HeaderText = "Koszt dojazdu";
            eventsDataGridView.Columns[4].HeaderText = "Liczba osób";
            eventsDataGridView.Columns[4].Width = 75;
            eventsDataGridView.Columns[5].HeaderText = "Kwota";
            eventsDataGridView.Columns[5].Width = 65;
            //koniec tabeli imprez
            //tabela klientów
            var client = from clients in context.Clients select new { clients.Id, clients.Name, clients.Surname, clients.PESEL, clients.PhoneNumber, clients.EMail };
            clientsDataGridView.DataSource = client;
            clientsDataGridView.Columns[1].HeaderText = "Imię";
            clientsDataGridView.Columns[2].HeaderText = "Nazwisko";
            clientsDataGridView.Columns[4].HeaderText = "Telefon";
            clientsDataGridView.Columns[5].HeaderText = "E-mail";
            //koniec tabeli klientów
            // zaznaczanie aktualnych danych
            //Nie działa w tym wypadku Selected w datagrid view, nie wiem jak to inaczej zrobić
            for (int i = 0; i < eventsDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(eventsDataGridView.Rows[i].Cells[0].Value)==Convert.ToInt32(currentPerformance.EventID))
                {
                    eventsDataGridView.Rows[i].Selected = true;
                }
            }
            for (int i = 0; i < clientsDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(clientsDataGridView.Rows[i].Cells[0].Value)== Convert.ToInt32(currentPerformance.ClientID))
                {
                    clientsDataGridView.Rows[i].Selected = true;
                }
            }
            for (int i = 0; i < placesDataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(placesDataGridView.Rows[i].Cells[0].Value)== Convert.ToInt32(currentPerformance.PlaceID))
                {
                    placesDataGridView.Rows[i].Selected = true;
                }
            }
        }
        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.przemyslawSzafranskiSQLZD4DataSet);

        }

        private void AddPerformance_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZD4DataSet.Places' . Możesz go przenieść lub usunąć.
            this.placesTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.Places);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZD4DataSet.Events' . Możesz go przenieść lub usunąć.
            this.eventsTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.Events);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZD4DataSet.Clients' . Możesz go przenieść lub usunąć.
            this.clientsTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.Clients);

        }

        private void addPerformanceButton_Click(object sender, EventArgs e)
        {
            //Gdy brak zlecenia, gdy jest tworzone
            if (currentPerformance == null)
            {

                EventsPerformance performance = new EventsPerformance();
  
                    //Szukanie wartości ID

                    int eventsRowIndex = eventsDataGridView.CurrentRow.Index;
                    int clientsRowIndex = clientsDataGridView.CurrentRow.Index;
                    int placesRowIndex = placesDataGridView.CurrentRow.Index;

                     int eventid = Convert.ToInt32(eventsDataGridView.Rows[eventsRowIndex].Cells[0].Value);
                     performance.EventID = eventid;
                
                      int clientid = Convert.ToInt32(clientsDataGridView.Rows[clientsRowIndex].Cells[0].Value);
                      performance.ClientID = clientid;

                      int placeid = Convert.ToInt32(placesDataGridView.Rows[placesRowIndex].Cells[0].Value);
                      performance.PlaceID = placeid;

                context.EventsPerformance.InsertOnSubmit(performance);
                context.SubmitChanges();
            }
            //gdy jest edytowane
            else
            {
                EventsPerformance performance = (from element in context.EventsPerformance
                                 where element.Id == currentPerformance.Id
                                 orderby element.Id descending
                                 select element).FirstOrDefault();
                int eventsRowIndex = eventsDataGridView.CurrentRow.Index;
                int clientsRowIndex = clientsDataGridView.CurrentRow.Index;
                int placesRowIndex = placesDataGridView.CurrentRow.Index;

                int eventid = Convert.ToInt32(eventsDataGridView.Rows[eventsRowIndex].Cells[0].Value);
                performance.EventID = eventid;

                int clientid = Convert.ToInt32(clientsDataGridView.Rows[clientsRowIndex].Cells[0].Value);
                performance.ClientID = clientid;

                int placeid = Convert.ToInt32(placesDataGridView.Rows[placesRowIndex].Cells[0].Value);
                performance.PlaceID = placeid;

                context.SubmitChanges();
            }
            Dispose();
        }
    }
}
