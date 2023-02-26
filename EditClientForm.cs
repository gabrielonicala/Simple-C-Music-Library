using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPAW.Database;

namespace ProiectPAW
{
    public partial class EditClientForm : Form
    {
        private readonly Guid id;
        public EditClientForm(Guid _id)
        {
            id = _id;
            InitializeComponent();
            cbEditClientPreference.DataSource = Enum.GetValues(typeof(CategoryNames));

            Client c = new Client();

            foreach (var client in FakeDatabase.Clients)
            {
                if (client.Id == id)
                {
                    c = client;
                }
            }

            tbEditClientName.Text = c.Name;
            tbEditClientAge.Text = Convert.ToString(c.Age);
            cbEditClientPreference.Text = Convert.ToString(c.Preference);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveEditClient_Click(object sender, EventArgs e)
        {
            var Name = Convert.ToString(tbEditClientName.Text);
            var Age = Convert.ToInt32(tbEditClientAge.Text);

            if (Age < 15)
            {
                MessageBox.Show("Clients under 15 years old are not allowed.");
            }
            else if (Age > 75)
            {
                MessageBox.Show("That is really not a realistic age for a client. Try something under 75.");
            }   
                else foreach (var client in FakeDatabase.Clients)
                {
                    if (client.Id == id)
                    {
                        client.Name = Convert.ToString(tbEditClientName.Text);
                        client.Preference = (CategoryNames)cbEditClientPreference.SelectedItem;
                        client.Age = Convert.ToInt32(tbEditClientAge.Text);

                        this.Hide();
                    }
                }
        }

        private void cbClientPreference_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
