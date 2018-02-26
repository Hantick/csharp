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
    public partial class EventManager : Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();

        public EventManager()
        {
            InitializeComponent();


        }
        /// <summary>
        /// Metoda ładująca zawartosc tabeli SQL do datagridview z konstrukcją join zmieniajacą numer ID na typ imprezy
        /// </summary>
        void RefreshEvents()
        {
            var query =
             from post in context.EventTypes
             join meta in context.Events on post.Id equals meta.EventTypeID
             where post.Id == meta.EventTypeID
            select new { Id = meta.Id, Type = post.EventType, Distance = meta.Distance, FuelCost = meta.FuelCost, AmountOfPeople = meta.AmoutOfPeople, EventCost = meta.EventCost };

            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].Width = 32;
            dataGridView1.Columns[1].HeaderText = "Typ Imprezy";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].HeaderText = "Dystans[km]";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Koszt dojazdu";
            dataGridView1.Columns[4].HeaderText = "Liczba osób";
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].HeaderText = "Kwota";
            dataGridView1.Columns[5].Width = 65;
        }
        private void EventManager_Load(object sender, EventArgs e)
        {

            RefreshEvents();

        }


        private void editEventButton_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            int currentID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Events evento = (from element in context.Events
                              where element.Id == currentID
                              select element).FirstOrDefault();
            using (AddEvent eventEditor = new AddEvent(evento))
            {

                eventEditor.ShowDialog(this);
            }
            context.SubmitChanges();
            RefreshEvents();
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            using (AddEvent eventAdder = new AddEvent())
            {
                eventAdder.ShowDialog(this);
            }
            RefreshEvents();
        }

        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            int iid = 0;
            int rowindex = dataGridView1.CurrentRow.Index;
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var delete = from p in context.Events
                         where p.Id == iid
                         select p;
            context.Events.DeleteAllOnSubmit(delete);
            context.SubmitChanges();
            rowindex = 0;
            RefreshEvents();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox == null || searchTextBox.Text == "")
            {
                RefreshEvents();
            }
            else
            {

                var search = from result in context.EventTypes
                             join searching in context.Events on result.Id equals searching.EventTypeID
                             where result.EventType == searchTextBox.Text && result.Id == searching.EventTypeID
                             select new { Id = result.Id, Type = result.EventType, Distance = searching.Distance, FuelCost = searching.FuelCost, AmountOfPeople = searching.AmoutOfPeople, EventCost = searching.EventCost };
                dataGridView1.DataSource = search;
            }
        }
    }
}
