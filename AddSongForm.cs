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
    public partial class AddSongForm : Form
    {
        public AddSongForm()
        {
            InitializeComponent();

            cbSongCategory.DataSource = Enum.GetValues(typeof(CategoryNames));
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSongSave_Click(object sender, EventArgs e)
        {
            var Title = Convert.ToString(tbTitle.Text);
            var Artist = Convert.ToString(tbArtist.Text);

            bool duplicate = false;
            foreach (var s in FakeDatabase.Songs)
            {
                if (s.Title == Title && s.Artist == Artist)
                {
                    MessageBox.Show("This song already exists.");
                    duplicate = true;
                    break;
                }
            }

            var song = new Song();
            song.Title = Convert.ToString(tbTitle.Text);
            song.Artist = Convert.ToString(tbArtist.Text);
            song.Category = (CategoryNames)cbSongCategory.SelectedItem;

            if (duplicate == false)
            {
                FakeDatabase.Songs.Add(song);
            }

            DialogResult = DialogResult.OK;

            Hide();
        }



        private void AddSongForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSongCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
