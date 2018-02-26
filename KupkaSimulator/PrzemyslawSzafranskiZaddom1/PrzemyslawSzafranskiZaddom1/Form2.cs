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
    public partial class resultsForm : Form
    {
        public resultsForm()
        {
            
            InitializeComponent();

           dataGridView1.Rows.Add(mainAppForm.GetAmoutOfNewborns(), mainAppForm.GetAmoutOfPeople(),mainAppForm.GetAmoutOfCows(), mainAppForm.GetAmoutOfClicks());
           dataGridView1.Rows.Add("","","");
           dataGridView1.Rows.Add("Rodziny", "Budynki","Ścieki");
           dataGridView1.Rows.Add(mainAppForm.GetAmoutOfFamilies(), mainAppForm.GetAmoutOfBuildings(), mainAppForm.GetAmoutOfSewers());
        }


    }
}
