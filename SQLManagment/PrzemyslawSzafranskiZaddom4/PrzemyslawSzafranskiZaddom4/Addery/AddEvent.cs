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
    public partial class AddEvent: Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        private Events currentEvent=null;

        public AddEvent()
        {
            InitializeComponent();
        }

        public AddEvent(Events evento)
        {
            InitializeComponent();

            currentEvent = evento;

            // listBox1.SelectedValue = currentEvent.EventTypeID.ToString();
          //  Console.WriteLine(listBox1.valu);
          // Nie działa w żaden sposób zmiany zaznaczenia wartości w listboxie SelectedValue w ogole sie nie da zmienic
          var searchEventType = from searcher in context.EventTypes
                                  where searcher.EventType == listBox1.SelectedValue.ToString()
                                select searcher.EventType;
            listBox1.SelectedValue = searchEventType;
            textBoxDistance.Text = currentEvent.Distance.ToString();
            textBoxFuelCost.Text = currentEvent.FuelCost.ToString();
            textBoxAmoutOfPeople.Text = currentEvent.AmoutOfPeople.ToString();
            textBoxEventCost.Text = currentEvent.EventCost.ToString();
        }



        private void AddEventButton_Click(object sender, EventArgs e)
        {
            //Gdy brak eventu, gdy jest tworzony
             if (currentEvent==null)
             {

                Events evento = new Events();
                //Szukanie wartości ID
                var searchEventTypeID = from searcher in context.EventTypes
                                      where searcher.EventType == listBox1.SelectedValue.ToString()
                                      select searcher.Id;

                int eventID = Convert.ToInt32((searchEventTypeID.FirstOrDefault()));
                evento.EventTypeID = eventID;
                evento.Distance = Int32.Parse(textBoxDistance.Text);
                evento.FuelCost = Int32.Parse(textBoxFuelCost.Text);
                evento.AmoutOfPeople = Int32.Parse(textBoxAmoutOfPeople.Text);
                evento.EventCost = textBoxEventCost.Text;
                context.Events.InsertOnSubmit(evento);
                context.SubmitChanges();
            }
             //gdy jest edytowany
            else
             {
                Events evento = (from element in context.Events
                                 where element.Id == currentEvent.Id
                                 orderby element.Id descending
                                 select element).FirstOrDefault();
                //Szukanie wartości ID
                var searchEventTypeID = from searcher in context.EventTypes
                                        where searcher.EventType == listBox1.SelectedValue.ToString()
                                        select searcher.Id;

                int eventID = Convert.ToInt32((searchEventTypeID.FirstOrDefault()));
                evento.EventTypeID = eventID;
                evento.Distance = Int32.Parse(textBoxDistance.Text);
                evento.FuelCost = Int32.Parse(textBoxFuelCost.Text);
                evento.AmoutOfPeople = Int32.Parse(textBoxAmoutOfPeople.Text);
                evento.EventCost = textBoxEventCost.Text;
                context.SubmitChanges();
            }
            Dispose();

        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZD4DataSet.EventTypes' . Możesz go przenieść lub usunąć.
            this.eventTypesTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.EventTypes);
        }

    }
}
