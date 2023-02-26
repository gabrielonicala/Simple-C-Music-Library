using ProiectPAW.Database;
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
    public partial class AddSongInCategoryForm : Form
    {
        private readonly CategoryNames Category;
        public AddSongInCategoryForm(CategoryNames _category)
        {
            Category = _category;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSongInCategory_Click(object sender, EventArgs e)
        {
            var Title = Convert.ToString(tbTitleSongInCategory.Text);
            var Artist = Convert.ToString(tbArtistSongInCategory.Text);

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
            song.Title = Convert.ToString(tbTitleSongInCategory.Text);
            song.Artist = Convert.ToString(tbArtistSongInCategory.Text);
            song.Category = Category;

            if (duplicate == false)
            {
                FakeDatabase.Songs.Add(song);
            }

            DialogResult = DialogResult.OK;

            Hide();
        }

        private void AddSongInCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelSongInCategory_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
