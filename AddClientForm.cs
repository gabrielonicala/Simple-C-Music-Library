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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();

            cbClientPreference.DataSource = Enum.GetValues(typeof(CategoryNames));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Name = Convert.ToString(tbName.Text);
            var Age = Convert.ToInt32(tbAge.Text);

            bool valid = true;

            if (Age < 15)
            {
                MessageBox.Show("Clients under 15 years old are not allowed.");
                valid = false;
            }
            else if (Age > 75)
            {
                MessageBox.Show("That is not really a realistic age for a client. Try something under 75.");
                valid = false;
            } 
                else foreach (var c in FakeDatabase.Clients)
                {
                    if (c.Name == Name && c.Age == Age)
                    {
                        MessageBox.Show("This client already exists.");
                        valid = false;
                        break;
                    }
                }


            var client = new Client();
            client.Name = Convert.ToString(tbName.Text);
            client.Age = Convert.ToInt32(tbAge.Text);
            client.Preference = (CategoryNames)cbClientPreference.SelectedItem;

            if (valid == true)
            {
                FakeDatabase.Clients.Add(client);
            }

            DialogResult = DialogResult.OK;

            Hide();

        }

        private void cbPreference_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
        //private void lbClientSongs_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    lbClientSongsList.DataSource = FakeDatabase.Songs;
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void btnClientCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
