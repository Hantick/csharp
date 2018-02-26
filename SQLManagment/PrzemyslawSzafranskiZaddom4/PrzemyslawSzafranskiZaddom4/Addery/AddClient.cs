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
    public partial class AddClient: Form
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        private Clients currentClient=null;

        public AddClient()
        {
            InitializeComponent();
        }

        public AddClient(Clients client)
        {
            InitializeComponent();

            textBoxClientName.Text = client.Name;
            textBoxClientSurname.Text = client.Surname;
            textBoxClientPESEL.Text = client.PESEL;
            textBoxPhoneNumber.Text = client.PhoneNumber;
                textBoxEMAIL.Text = client.EMail;
            currentClient = client;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (currentClient == null)
            {
                Clients client = new Clients();
                client.Name = textBoxClientName.Text;
                client.Surname = textBoxClientSurname.Text;
                client.PESEL = textBoxClientPESEL.Text;
                client.PhoneNumber = textBoxPhoneNumber.Text;
                client.EMail = textBoxEMAIL.Text;
                context.Clients.InsertOnSubmit(client);
                context.SubmitChanges();
            }
            else
            {
                Clients client = (from element in context.Clients
                                where element.Id == currentClient.Id
                                orderby element.Id descending
                                select element).FirstOrDefault();
                client.Name = textBoxClientName.Text;
                client.Surname = textBoxClientSurname.Text;
                client.PESEL = textBoxClientPESEL.Text;
                client.PhoneNumber = textBoxPhoneNumber.Text;
                client.EMail = textBoxEMAIL.Text;
                context.SubmitChanges();
            }

            
            Dispose();

        }
    }
}
