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
    public partial class CategorySongsForm2 : Form
    {
        private readonly CategoryNames Preference;
        public CategorySongsForm2(CategoryNames _preference)
        {
            Preference = _preference;
            InitializeComponent();
            CategorySongFormDataView2.DataSource = null;
            CategorySongFormDataView2.DataSource = FakeDatabase.Songs.Where(s => s.Category == Preference).ToList();
        }

        private void CategorySongsForm2_Load(object sender, EventArgs e)
        {

        }

        private void btnASIC_Click(object sender, EventArgs e)
        {
            var addSongForm = new AddSongInCategoryForm(Preference);
            addSongForm.ShowDialog();

            CategorySongFormDataView2.DataSource = null;
            CategorySongFormDataView2.DataSource = FakeDatabase.Songs.Where(s => s.Category == Preference).ToList();
        }
    }
}
