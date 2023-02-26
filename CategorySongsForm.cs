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
    public partial class CategorySongsForm : Form
    {
        private readonly CategoryNames Preference;

        public CategorySongsForm(CategoryNames _preference)
        {
            Preference = _preference;
            InitializeComponent();
            CategorySongFormDataView.DataSource = null;
            CategorySongFormDataView.DataSource = FakeDatabase.Songs.Where(s => s.Category == Preference).ToList();
              
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategorySongsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
