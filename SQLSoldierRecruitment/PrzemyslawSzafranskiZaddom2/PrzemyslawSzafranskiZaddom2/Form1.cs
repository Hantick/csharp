using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzemyslawSzafranskiZaddom2
{
    public partial class mainWindowForm : Form
    {
        int timerTicks = 0; //zmienna przechowujaca ilosc tykniec timera
        bool messageFlag = false; //flaga sprawdzajaca czy klikniety byl przycisk stworz zolnierza
        int coins = 0;
        bool deleteSoldierButtonFlag = false;

        SqlConnection connection;
        public mainWindowForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-JKC4Q96\SQLEXPRESS; database=PrzemyslawSzafranskiSQLZaddom2;Trusted_Connection=yes");

            mainTimer.Start();
        }



        private void refreshSQL()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from SoldiersAndMarinesTable", connection);
            DataTable table = new DataTable();
            adapter.Fill(table); //przekazuje dane z konternera
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
        }


        private void fasterProdButton_Click(object sender, EventArgs e)
        {
            playerNewSoldierProgressBar.Increment(20);
        }

        private void CreateSoldierButton_Click(object sender, EventArgs e)
        {
            if (coins >= Game.SoldierCost)
            {
                coins -= Game.SoldierCost;
                coinLabel.Text = coins.ToString();
                Soldier soldier=new Soldier(SoldierNameTextBox.Text);
                MessageLabel.Text = "Zakupiono żołnierza!";
                messageFlag = true;
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into SoldiersAndMarinesTable(Name,HP,DMG,Condition) values (@name,@hp,@dmg,@condition)", connection);
                cmd.Parameters.AddWithValue("@name", soldier.Name);
                cmd.Parameters.AddWithValue("@hp", soldier.GetHP());
                cmd.Parameters.AddWithValue("@dmg", soldier.GetDMG());
                cmd.Parameters.AddWithValue("@condition", soldier.GetCondition());
                cmd.ExecuteNonQuery();
                connection.Close();
                refreshSQL();
            }
            else
            {
                MessageLabel.Text = "Nie stać Cię na żołnierza!";
                messageFlag = true;
            }
        }

        private void promoteButton_Click(object sender, EventArgs e)
        {
            if (coins >= Game.PromotionCost)
            {
                coins -= Game.PromotionCost;
                Marine marine = new Marine(SoldierNameTextBox.Text);
                MessageLabel.Text = "Zakupiono Marine!";
                coinLabel.Text = coins.ToString();
                messageFlag = true;
                //operacje na bazie danych SQL
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into SoldiersAndMarinesTable(Name,HP,DMG,Condition) values (@name,@hp,@dmg,@condition)",connection);
                cmd.Parameters.AddWithValue("@name", marine.Name);
                cmd.Parameters.AddWithValue("@hp",marine.GetHP());
                cmd.Parameters.AddWithValue("@dmg",marine.GetDMG());
                cmd.Parameters.AddWithValue("@condition",marine.GetCondition());
                cmd.ExecuteNonQuery();
                connection.Close();
                refreshSQL();
            }
            else
            {
                MessageLabel.Text = "Nie stać Cię na Marine!";
                messageFlag = true;
            }
        }
        /// <summary>
        /// Tyknięcie zegara i zwiazane z nim akcje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            timerTicks++;
            playerNewSoldierProgressBar.Increment(3);
            if (playerNewSoldierProgressBar.Value >= playerNewSoldierProgressBar.Maximum)
            {
                coins += 40;
                coinLabel.Text = coins.ToString();
                playerNewSoldierProgressBar.Value = 0;
            }
            if (messageFlag == true)
            {
                MessageLabel.Text = " " + MessageLabel.Text;
                if (timerTicks >= 60)
                {
                    MessageLabel.Text = "...";
                    messageFlag = false;
                    timerTicks = 0;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteSoldierButtonFlag = true;
            deleteSoldierButton.Visible = true;

        }

        /// <summary>
        /// przycisk usuwający żołnierzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSoldierButton_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;//przechowywacz indeksu wiersza
            int columnindex = dataGridView1.CurrentCell.ColumnIndex; //przechowywacz indeksu kolumny

            connection.Open();
            SqlCommand deleteCMD = new SqlCommand("delete from SoldiersAndMarinesTable where Id like @Id", connection);
            deleteCMD.Parameters.AddWithValue("Id", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            Console.WriteLine(dataGridView1.SelectedRows);
            deleteCMD.ExecuteNonQuery();
            connection.Close();
            refreshSQL();
        }

        private void loadSQLButton_Click(object sender, EventArgs e)
        {
            refreshSQL();
        }

        private void mainWindowForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'przemyslawSzafranskiSQLZaddom2DataSet.SoldiersAndMarinesTable' .
            this.SoldiersAndMarinesTableTableAdapter.Fill(this.przemyslawSzafranskiSQLZaddom2DataSet.SoldiersAndMarinesTable);

        }

        private void saveSQLButton_Click(object sender, EventArgs e)
        {

        }
    }
}

