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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();

            ClientDataView.AutoGenerateColumns = false;

            ClientDataView.ColumnCount = 4;

            ClientDataView.DataSource = null;
            ClientDataView.DataSource = FakeDatabase.Clients;

            ClientAddColumn(0, "Id", "Id");
            ClientAddColumn(1, "Name", "Name");
            ClientAddColumn(2, "Age", "Age");
            ClientAddColumn(3, "Preference", "Preference");

            ClientAddButtonColumn("editColumn", "", "Edit");
            ClientAddButtonColumn("deleteColumn", "", "Delete");
            ClientAddButtonColumn("songsColumn", "", "Suggested songs");
            ClientDataView.CellClick += ClientDataView_CellClick;


            ClientDataView.ReadOnly = true;
            ClientDataView.AllowUserToAddRows = false;
        }

        private void ClientDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientAddColumn(int index, string headerText, string propertyName)
        {
            ClientDataView.Columns[index].HeaderText = headerText;
            ClientDataView.Columns[index].DataPropertyName = propertyName;
        }

        private void ClientAddButtonColumn(string name, string headerText, string buttonText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            ClientDataView.Columns.Add(buttonColumn);
        }


        private void ClientDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ClientDataView.Columns["deleteColumn"].Index)
            {
                Client currentObject = (Client)ClientDataView.CurrentRow.DataBoundItem;

                FakeDatabase.Clients.Remove(currentObject);

                ClientDataView.DataSource = null;
                ClientDataView.DataSource = FakeDatabase.Clients;
            }

            if (e.ColumnIndex == ClientDataView.Columns["editColumn"].Index)
            {
                Client currentObject = (Client)ClientDataView.CurrentRow.DataBoundItem;
                var editForm = new EditClientForm(currentObject.Id);
                editForm.ShowDialog();

                ClientDataView.DataSource = null;
                ClientDataView.DataSource = FakeDatabase.Clients;
            }

            if (e.ColumnIndex == ClientDataView.Columns["songsColumn"].Index)
            {
                Client currentObject = (Client)ClientDataView.CurrentRow.DataBoundItem;
                var categorySongsForm = new CategorySongsForm(currentObject.Preference);
                categorySongsForm.ShowDialog();

                ClientDataView.DataSource = null;
                ClientDataView.DataSource = FakeDatabase.Clients;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var addform = new AddClientForm();
            addform.ShowDialog();

            ClientDataView.DataSource = null;
            ClientDataView.DataSource = FakeDatabase.Clients;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
