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
    public partial class EditSongForm : Form
    {
        private readonly Guid Id;
        public EditSongForm(Guid _id)
        {
            Id = _id;
            InitializeComponent();
            cbEditSongCategory.DataSource = Enum.GetValues(typeof(CategoryNames));

            Song s = new Song();

            foreach (var song in FakeDatabase.Songs)
            {
                if (song.Id == Id)
                {
                     s=song;
                }
            }

            tbEditSongTitle.Text = s.Title;
            tbEditSongArtist.Text = s.Artist;
            cbEditSongCategory.Text = Convert.ToString(s.Category);   
        }

        private void EditSongForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditSongSave_Click(object sender, EventArgs e)
        {
            foreach (var song in FakeDatabase.Songs)
            {
                if (song.Id == Id)
                {
                    song.Title = Convert.ToString(tbEditSongTitle.Text);
                    song.Artist = Convert.ToString(tbEditSongArtist.Text);
                    song.Category = (CategoryNames)cbEditSongCategory.SelectedItem;

                    this.Hide();
                }
            }
        }
    }
}
