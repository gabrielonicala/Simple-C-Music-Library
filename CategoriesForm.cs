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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();

            CategoriesDataView.AutoGenerateColumns = false;

            CategoriesDataView.ColumnCount = 2;

            CategoriesDataView.DataSource = null;
            CategoriesDataView.DataSource = FakeDatabase.Categories;

            CategoryAddColumn(0, "Name", "Name");
            CategoryAddColumn(1, "Popularity", "Popularity");
      

            CategoryAddButtonColumn("songsColumn", "", "View songs.");
            CategoriesDataView.CellClick += ClientDataView_CellClick;


            CategoriesDataView.ReadOnly = true;
            CategoriesDataView.AllowUserToAddRows = false;
        }

        private void CategoryAddColumn(int index, string headerText, string propertyName)
        {
            CategoriesDataView.Columns[index].HeaderText = headerText;
            CategoriesDataView.Columns[index].DataPropertyName = propertyName;
        }

        private void CategoryAddButtonColumn(string name, string headerText, string buttonText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            CategoriesDataView.Columns.Add(buttonColumn);
        }


        private void ClientDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            if (e.ColumnIndex == CategoriesDataView.Columns["songsColumn"].Index)
            {
                Category currentObject = (Category)CategoriesDataView.CurrentRow.DataBoundItem;
                var categorySongsForm = new CategorySongsForm2(currentObject.Name);
                categorySongsForm.ShowDialog();

                CategoriesDataView.DataSource = null;
                CategoriesDataView.DataSource = FakeDatabase.Categories;
            }
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
