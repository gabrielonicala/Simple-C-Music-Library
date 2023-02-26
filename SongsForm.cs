using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPAW.Database;

namespace ProiectPAW
{
    public partial class SongsForm : Form
    {
        public SongsForm()
        {
            InitializeComponent();

            SongsDataView.AutoGenerateColumns = false;

            SongsDataView.ColumnCount = 4;

            SongsDataView.DataSource = null;
            SongsDataView.DataSource = FakeDatabase.Songs;

            AddColumn(0, "Id", "Id");
            AddColumn(1, "Title", "Title");
            AddColumn(2, "Artist", "Artist");
            AddColumn(3, "Category", "Category");

            AddButtonColumn("editColumn", "", "Edit");
            AddButtonColumn("deleteColumn", "", "Delete");

            SongsDataView.CellClick += SongsDataView_CellClick;


            SongsDataView.ReadOnly = true;
            SongsDataView.AllowUserToAddRows = false;
        }

        private void AddColumn(int index, string headerText, string propertyName)
        {
            SongsDataView.Columns[index].HeaderText = headerText;
            SongsDataView.Columns[index].DataPropertyName = propertyName;
        }

        private void AddButtonColumn(string name, string headerText, string buttonText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            SongsDataView.Columns.Add(buttonColumn);
        }

        private void SongsDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SongsDataView.Columns["deleteColumn"].Index)
            {
                Song currentObject = (Song)SongsDataView.CurrentRow.DataBoundItem;

                FakeDatabase.Songs.Remove(currentObject);

                SongsDataView.DataSource = null;
                SongsDataView.DataSource = FakeDatabase.Songs;
            }

            if (e.ColumnIndex == SongsDataView.Columns["editColumn"].Index)
            {
                Song currentObject = (Song)SongsDataView.CurrentRow.DataBoundItem;
                var editForm = new EditSongForm(currentObject.Id);
                editForm.ShowDialog();

                SongsDataView.DataSource = null;
                SongsDataView.DataSource = FakeDatabase.Songs;
            }
        }

        private void AddSongInFormBtn_Click(object sender, EventArgs e)
        {
            var addSongForm = new AddSongForm();
            addSongForm.ShowDialog();

            SongsDataView.DataSource = null;
            SongsDataView.DataSource = FakeDatabase.Songs;
        }

        private void SongsForm_Load(object sender, EventArgs e)
        {

        }

        private void SongsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    FakeDatabase.Songs = formatter.Deserialize(fileStream) as List<Song>;
                    fileStream.Close();
                }
            }

            SongsDataView.DataSource = null;
            SongsDataView.DataSource = FakeDatabase.Songs;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {

                    FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, FakeDatabase.Songs);
                    fileStream.Close();
                }
            }
        }
    }
}
