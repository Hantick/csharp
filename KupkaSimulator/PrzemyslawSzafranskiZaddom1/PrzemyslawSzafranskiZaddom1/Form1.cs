using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemyslawSzafranskiZaddom1
{

    public partial class mainAppForm : Form
    {
        int pooAmout = 0; //aktualna ilosc kupek
        //aktualne ilosci noworodkow,ludzi,krow,rodzin,budynkow i sciekow
        // nie wiem czy da sie zrobic to inaczej, bez "staticów"
        private static int amoutOfNewborns = 0;
        private static int amoutOfPeople = 0;
        private static int amoutOfCows = 0;
        private static int amoutOfFamilies = 0;
        private static int amoutOfBuildings = 0;
        private static int amoutOfSewers = 0;
        private static int amoutOfClicks = 0;//ilosc klikniec na kupke

        int amoutOfTimerTicks = 0; //ilosc tyków zegara
        static int totalAmoutOfTimerTicks = 0; //ilosc wszystkich tykow
        //koszty zakupu
        const int NEWBORNCOST = 20; //ilosc kupek wymagana do zakupu noworodka etc.
        const int PERSONCOST = 100;
        const int COWCOST = 150;
        const int FAMILYCOST = 300;
        const int BUILDINGCOST = 1000;
        const int SEWERCOST = 5000;
        const int WINGOAL = 6000;
        /// <summary>
        /// Funkcja zwracajaca czas calkowity grania od momentu klikniecia kupki do momentu osiagniecia WINGOAL
        /// </summary>
        /// <returns></returns>
        public static String GetTotalTime()
        {
            float time = totalAmoutOfTimerTicks/10;
            return time.ToString();
        }
        public static String GetAmoutOfNewborns()
        {
            return amoutOfNewborns.ToString();
        }
        public static String GetAmoutOfPeople()
        {
            return amoutOfPeople.ToString();
        }
        public static String GetAmoutOfCows()
        {
            return amoutOfCows.ToString();
        }
        public static String GetAmoutOfFamilies()
        {
            return amoutOfFamilies.ToString();
        }
        public static String GetAmoutOfBuildings()
        {
            return amoutOfBuildings.ToString();
        }
        public static String GetAmoutOfSewers()
        {
            return amoutOfSewers.ToString();
        }
        public static String GetAmoutOfClicks()
        {
            return amoutOfClicks.ToString();
        }
        public mainAppForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Metoda, która po kliknięciu obrazka kupki dodaje nam licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainPooPictureBox_Click(object sender, EventArgs e)
        {
            pooAmout++; //inkrementacja ilosci kupek
            /*System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "fart.wav";
            s.Load();
            s.Play();*/
            labelAmoutOfPoos.Text = pooAmout.ToString();
            PooTimer.Start();
            amoutOfClicks++;

        }


        /// <summary>
        /// metody ktore po kliknieciu przycisku zakupuje nam jeden z dostepnych obiektow, od noworodka do sciekow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newbornPictureBox_Click(object sender, EventArgs e)
        {
            if (pooAmout >= NEWBORNCOST)
            {
                pooAmout -= NEWBORNCOST;
            amoutOfNewborns++;
            amoutOfNewbornsLabel.Text = amoutOfNewborns.ToString();
         
            }
        }


        private void personPictureBox_Click(object sender, EventArgs e)
        {
            if (pooAmout >= PERSONCOST)
            {
                pooAmout -= PERSONCOST;
                amoutOfPeople++;
                amoutOfPeopleLabel.Text = amoutOfPeople.ToString();
               
            }
        }

        private void cowPictureBox_Click(object sender, EventArgs e)
        {
            if (pooAmout >= COWCOST)
            {
                pooAmout -= COWCOST;
                amoutOfCows++;
                amoutOfCowsLabel.Text = amoutOfCows.ToString();
                
            }
        }

        private void familyPictureBox_Click(object sender, EventArgs e)
        {
            if (pooAmout >= FAMILYCOST)
          
                pooAmout -= FAMILYCOST;
                amoutOfFamilies++;
                amoutOfFamiliesLabel.Text = amoutOfFamilies.ToString();
                
            }

        private void buildingPictureBox_Click(object sender, EventArgs e)
        {
            if (pooAmout >= BUILDINGCOST)
            {
                pooAmout -= BUILDINGCOST;
                amoutOfBuildings++;
                amoutOfBuildingsLabel.Text = amoutOfBuildings.ToString();
               
            }
        }

        private void sewerPictureBox_Click(object sender, EventArgs e)
        {
            if (pooAmout >= SEWERCOST)
            {
                pooAmout -= SEWERCOST;
                amoutOfSewers++;
                amoutOfSewersLabel.Text = amoutOfSewers.ToString();
               
            }
        }
        //KONIEC METOD ZAKUPU
        /// <summary>
        /// Metoda ktora ma sie wykonac po tyknieciu zegara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PooTimer_Tick(object sender, EventArgs e)
        {
            amoutOfTimerTicks++;
            totalAmoutOfTimerTicks++;
            if (amoutOfTimerTicks == 30)
            {
                
                    pooAmout += amoutOfNewborns;

                amoutOfTimerTicks = 0;
            }
            if (amoutOfTimerTicks == 10)
            {

                pooAmout += amoutOfPeople;

            }
            if (amoutOfTimerTicks == 3)
            {

                pooAmout += amoutOfCows;

            }
            pooAmout += amoutOfFamilies;
            pooAmout += amoutOfBuildings * 2;
            pooAmout += amoutOfSewers*8;

            labelAmoutOfPoos.Text = pooAmout.ToString();
            if (pooAmout >= WINGOAL)
            {
                Form Results = new resultsForm();
                PooTimer.Stop();
                mainPooPictureBox.Enabled = false;
                
                Results.Show();
                


            }
        }

        private void mainAppForm_Load(object sender, EventArgs e)
        {
            Form3 greetingMessage = new Form3();
            greetingMessage.Show();
        }
    }

}

