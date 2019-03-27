using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreServicesBootCamp
{
    public partial class RangeSelector : Form
    {
        public double min;
        public double max;
        public event Action<double> Check;



        public RangeSelector()
        {
            InitializeComponent();
            this.textBoxMIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBoxMIN_KeyPress);
            this.textBoxMAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBoxMIN_KeyPress);
        }

        private void textBoxMIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }



        private void textBoxMIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void RangeSelector_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
        private void RangeSelector_Closed(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
           
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            min = double.Parse(textBoxMIN.Text);
            max = double.Parse(textBoxMAX.Text);

            this.Close();
        }
    }

}
