using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using SautinSoft.Document;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemyslawSzafranskiZaddom4
{
    public partial class PerformanceManager : Form
    {

        DataClasses1DataContext context = new DataClasses1DataContext();
        public PerformanceManager()
        {
            InitializeComponent();

        }

        void RefreshPerformances()
        {
        var query =
        from performance in context.EventsPerformance
        join events in context.Events on performance.EventID equals events.Id
        join eventType in context.EventTypes on events.EventTypeID equals eventType.Id   // nie umiem zrobić tak by nazwa była np Bal + cena balu
        join client in context.Clients on performance.ClientID equals client.Id
        join place in context.Places on performance.PlaceID equals place.Id
        where performance.EventID == events.Id && performance.ClientID == client.Id && performance.PlaceID == place.Id
        select new
        {
        Id = performance.Id,
        EventId = eventType.EventType,
        ClientID = client.Name + " " + client.Surname + " Tel. " + client.PhoneNumber,
        PlaceId = place.Name + " " + place.City
        };
            
            eventsPerformanceDataGridView.Columns[0].Width = 35;
            eventsPerformanceDataGridView.Columns[1].HeaderText = "Impreza";
            eventsPerformanceDataGridView.Columns[1].Width = 130;
            eventsPerformanceDataGridView.Columns[2].HeaderText = "Klient";
            eventsPerformanceDataGridView.Columns[2].Width = 180;
            eventsPerformanceDataGridView.Columns[3].HeaderText = "Lokal";
            eventsPerformanceDataGridView.Columns[3].Width = 181;
            eventsPerformanceDataGridView.DataSource = query;

        }
        /// <summary>
        /// Wywołanie nowej formy otwierającej okno z menadżerem miejsc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPlaceMenuItem_Click(object sender, EventArgs e)
        {
            using (PlaceManager placeManager = new PlaceManager())
            {
                placeManager.ShowDialog(this);
            }
        }

        private void addClientMenuItem_Click(object sender, EventArgs e)
        {
            using (ClientManager clientManager = new ClientManager())
            {
                clientManager.ShowDialog(this);
            }
        }

        private void addPerformanceMenuItem_Click(object sender, EventArgs e)
        {
            using (EventManager eventManager = new EventManager())
            {
                eventManager.ShowDialog(this);
            }
        }


        private void PerformanceManager_Load(object sender, EventArgs e)
        {
            this.eventsPerformanceTableAdapter.Fill(this.przemyslawSzafranskiSQLZD4DataSet.EventsPerformance);
            RefreshPerformances();
        }

        private void deletePerformanceButton_Click(object sender, EventArgs e)
        {
            int rowindex = eventsPerformanceDataGridView.CurrentRow.Index;
            int iid = Convert.ToInt32(eventsPerformanceDataGridView.Rows[rowindex].Cells[0].Value);
            var delete = from p in context.EventsPerformance
                         where p.Id == iid
                         select p;
            context.EventsPerformance.DeleteAllOnSubmit(delete);
            context.SubmitChanges();
            rowindex = 0;
            RefreshPerformances();
        }

        private void addPerformanceButton_Click(object sender, EventArgs e)
        {
            using (AddPerformance performanceAdder = new AddPerformance())
            {
                performanceAdder.ShowDialog(this);
            }
            RefreshPerformances();
        }

        private void editPerformanceButton_Click(object sender, EventArgs e)
        {
            int rowindex = eventsPerformanceDataGridView.CurrentRow.Index;
            int currentID = Convert.ToInt32(eventsPerformanceDataGridView.Rows[rowindex].Cells[0].Value);
            EventsPerformance performance = (from element in context.EventsPerformance
                              where element.Id == currentID
                              select element).FirstOrDefault();
            using (AddPerformance performanceEditor = new AddPerformance(performance))
            {
                performanceEditor.ShowDialog(this);
            }
            RefreshPerformances();
        }

        //Zapisy do pliku
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            CreateDocx();


        }
        public static void CreateDocx()
        {
            // Set a path to our docx file.
            string docxPath = @"..\..\..\..\..\..\Testing Files\Result.docx";

            // Let's create a simple DOCX document.
            DocumentCore docx = new DocumentCore();
            //DocumentCore.Serial = "put your serial here";

            // Add new section.
            Section section = new Section(docx);
            docx.Sections.Add(section);

            // Let's set page size A4.
            section.PageSetup.PaperType = PaperType.A4;

            // Add two paragraphs using different ways:

            // Way 1: Add 1st paragraph.
            section.Blocks.Add(new Paragraph(docx, "This is a first line in 1st paragraph!"));
            Paragraph par1 = section.Blocks[0] as Paragraph;
            par1.ParagraphFormat.Alignment = SautinSoft.Document.HorizontalAlignment.Center;

            // Let's add a second line.
            par1.Inlines.Add(new SpecialCharacter(docx, SpecialCharacterType.LineBreak));
            par1.Inlines.Add(new Run(docx, "Let's type a second line."));

            // Let's change font name, size and color.
            CharacterFormat cf = new CharacterFormat() { FontName = "Verdana", Size = 16, FontColor = SautinSoft.Document.Color.Orange };
            foreach (Inline inline in par1.Inlines)
                if (inline is Run)
                    (inline as Run).CharacterFormat = cf.Clone();

            // Way 2 (easy): Add 2nd paragarph using another way.
            docx.Content.End.Insert("\nThis is a first line in 2nd paragraph.", new CharacterFormat() { Size = 25, FontColor = SautinSoft.Document.Color.Blue, Bold = true });
            SpecialCharacter lBr = new SpecialCharacter(docx, SpecialCharacterType.LineBreak);
            docx.Content.End.Insert(lBr.Content);
            docx.Content.End.Insert("This is a second line.", new CharacterFormat() { Size = 20, FontColor = SautinSoft.Document.Color.DarkGreen, UnderlineStyle = UnderlineType.Single });

            // Save DOCX to a file
            docx.Save(docxPath);

            // Open the result for demonstation purposes.
            System.Diagnostics.Process.Start(docxPath);
        }





    }
}
