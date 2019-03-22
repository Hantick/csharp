using System;
using System.IO;
using System.Windows.Forms;

namespace CoreServicesBootCamp
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        /// <summary> Przycisk wczytujący bazę plików przez okno dialogowe
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wczytajBazęToolStripMenuItem_Click(object sender, EventArgs e)
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
                                fileContent = reader.ReadToEnd();

                                MessageBox.Show(fileContent, "Ładowanie: " + file, MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"{0} Błąd." + ex, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
