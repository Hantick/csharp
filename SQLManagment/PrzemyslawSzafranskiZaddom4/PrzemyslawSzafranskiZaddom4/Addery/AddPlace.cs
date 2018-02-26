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
    public partial class AddPlace : Form
    {
        Places currentPlace = new Places();
        DataClasses1DataContext context = new DataClasses1DataContext();
        public AddPlace()
        {
            InitializeComponent();
            currentPlace = null;
        }
        public AddPlace(Places place)
        {
            InitializeComponent();
            
            textBoxPlaceName.Text = place.Name;
            textBoxStreetName.Text = place.Street;
            textBoxCityName.Text = place.City;
            currentPlace = place;
        }
        private void addPlaceButton_Click(object sender, EventArgs e)
        {
            if (currentPlace == null)
            {
                Places place = new Places();
                place.Name = textBoxPlaceName.Text;
                place.Street = textBoxStreetName.Text;
                place.City = textBoxCityName.Text;
                context.Places.InsertOnSubmit(place);
                context.SubmitChanges();
            }
            else
            {
                Places place = (from element in context.Places
                             where element.Id ==currentPlace.Id 
                             orderby element.Id descending
                             select element).FirstOrDefault();
                place.Name = textBoxPlaceName.Text;
                place.Street = textBoxStreetName.Text;
                place.City = textBoxCityName.Text;
                context.SubmitChanges();
            }

            currentPlace = null;
            Dispose();

            {

        }

        }
    }
}
