using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Music_Library : Form
    {
        public Music_Library()
        {
            InitializeComponent();
        }

        private void btnViewClients_Click(object sender, EventArgs e)
        {
            var clientsform = new ClientsForm();
            clientsform.ShowDialog();

        }

        private void btnViewSongs_Click(object sender, EventArgs e)
        {
            var songsForm = new SongsForm();
            songsForm.ShowDialog();
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            var categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }

        private void Music_Library_Load(object sender, EventArgs e)
        {

        }
    }
}
