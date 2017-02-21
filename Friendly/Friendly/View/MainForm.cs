using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Friendly.Model;
using Friendly.ControllerLayer;
using System.Data.Entity.Infrastructure;
using Friendly.Utilities;

namespace Friendly.View
{
    public partial class MainForm : Form
    {
        private User currentUser;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(User user)
        {
            currentUser = user;
            InitializeComponent();
        }
        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    UsersLocationsTimesToDataGrid();

                    break;
                case 1:
                    UsersLocationsToDataGrid();
                    break;
            }
        }
        public void UsersLocationsTimesToDataGrid()
        {
            dataGridView1.DataSource = Controller.GetUserLocations(currentUser.Username);
            dataGridView1.Columns[1].Visible = false;
            for (int i = 5; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;
        }
        public void UsersLocationsToDataGrid()
        {
            dataGridView_MyMatchesCities.DataSource = Controller.GetUserLocations(currentUser.Username);
            for (int i = 1; i < dataGridView_MyMatchesCities.Columns.Count; i++)
                dataGridView_MyMatchesCities.Columns[i].Visible = false;
        }
        public void UsersByCityToDataGrid(string selectedCity, User currentuser)
        {
            dataGridView_MyMatches.DataSource = Controller.GetUsersByCity(selectedCity, currentuser);
            for (int i = 5; i < dataGridView_MyMatches.Columns.Count; i++)
                dataGridView_MyMatches.Columns[i].Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.MinDate = DateTime.Today;
            dateTimePickerTo.MinDate = DateTime.Today;
            UsersLocationsTimesToDataGrid();
            textBox_FirstName.Text = currentUser.FirstName;
            textBox_LastName.Text = currentUser.LastName;

            if (currentUser.Birthdate != null)
                label_Age.Text = Controller.GetAge(currentUser.Username).ToString() + " years";

            comboBox_ProfessionalField.DataSource = Controller.GetFieldOfProfessions();
            comboBox_ProfessionalField.DisplayMember = "Industry";

            if (currentUser.Industry != null)
            {
                comboBox_ProfessionalField.Text = currentUser.Industry;
            }
            else
            {
                comboBox_ProfessionalField.Text = "Field of profession";
            }

            if (currentUser.Profession != null)
            {
                cueTextBox_ProfessionalTitle.Text = currentUser.Profession;
            }

            if (currentUser.About != null)
            {
                textBox_AboutMe.Text = currentUser.About;
            }


            DefaultValuesLocation();
        }
        private void DefaultValuesLocation()
        {
            comboBox_InterestedIn.DataSource = Controller.GetPurposes();
            comboBox_InterestedIn.DisplayMember = "Purposetype";
            comboBox_InterestedIn.ValueMember = "Purposetype";
            comboBox_InterestedIn.Text = "Interested In";
            comboBox_City.DataSource = Controller.GetLocations();
            comboBox_City.DisplayMember = "City";
            comboBox_City.ValueMember = "City";
            comboBox_City.Text = "In City";
        }

        private void dataGridView_MyMatchesCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_MyMatchesCities.Rows[e.RowIndex];
                string selectedCity = selectedRow.Cells[0].Value.ToString();
                UsersByCityToDataGrid(selectedCity, currentUser);
            }
        }

        private void dataGridView_MyMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_MyMatches.Rows[e.RowIndex];
                string selectedUser = selectedRow.Cells[1].Value.ToString();
                PopUpForm showUserForm = new PopUpForm(selectedUser);
                showUserForm.Show();
            }
        }

        private void button_UpdateDetails_Click(object sender, EventArgs e)
        {

                    
            currentUser.About = textBox_AboutMe.Text.ToString();
            currentUser.Profession = cueTextBox_ProfessionalTitle.Text.ToString();
            currentUser.Industry = comboBox_ProfessionalField.Text.ToString();
            Controller.UpdateUser(currentUser);
        }

        private void button_AddLocation_Click(object sender, EventArgs e)
        {
            User_Location_Purpose ulp = new User_Location_Purpose();
            ulp.Username = currentUser.Username;
            ulp.Purposetype = comboBox_InterestedIn.SelectedValue.ToString().Trim();
            ulp.City = comboBox_City.SelectedValue.ToString().Trim();
            
            if (checkBox_Longterm.Checked)
            {
                ulp.FromDate = null;
                ulp.ToDate = null;
            }
            else if (!checkBox_Longterm.Checked)
            {
                ulp.FromDate = dateTimePickerFrom.Value.Date;
                ulp.ToDate = dateTimePickerTo.Value.Date;
            }
            try
            {
                Controller.AddUserLocationPurpose(ulp);
                UsersLocationsTimesToDataGrid();
                DefaultValuesLocation();
            }
            catch(DbUpdateException ex)
            {
                label_Messages.Text = ErrorHandler.HandleError(ex);
            }
        }

        private void checkBox_Longterm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Longterm.Checked)
            {
                dateTimePickerFrom.Enabled = false;
                dateTimePickerTo.Enabled = false;
            }
            else
            {
                dateTimePickerFrom.Enabled = true;
                dateTimePickerTo.Enabled = true;
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.MinDate = dateTimePickerFrom.Value;
        }
    }
}


