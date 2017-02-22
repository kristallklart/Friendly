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
            label_Age.Text = Controller.GetAge(currentUser.Username).ToString() + " years";

            cueComboBox_ProfessionalField.DataSource = Controller.GetFieldOfProfessions();
            cueComboBox_ProfessionalField.DisplayMember = "Industry";
            cueComboBox_ProfessionalField.SelectedIndex = -1;
            cueComboBox_ProfessionalField.CueText = "Field of profession";

            if (currentUser.Industry != null)
            {
                cueComboBox_ProfessionalField.Text = currentUser.Industry;
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
            cueComboBox_InterestedIn.DataSource = Controller.GetPurposes();
            cueComboBox_InterestedIn.DisplayMember = "Purposetype";
            cueComboBox_InterestedIn.ValueMember = "Purposetype";
            cueComboBox_InterestedIn.SelectedIndex = -1;
            cueComboBox_InterestedIn.CueText = "Interested in";
            cueComboBox_City.DataSource = Controller.GetLocations();
            cueComboBox_City.DisplayMember = "City";
            cueComboBox_City.ValueMember = "City";
            cueComboBox_City.SelectedIndex = -1;
            cueComboBox_City.CueText = "City";
            
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
            currentUser.FirstName= textBox_FirstName.Text.ToString().Trim();
            currentUser.LastName = textBox_LastName.Text.ToString().Trim();
            currentUser.About = textBox_AboutMe.Text.ToString().Trim();
            currentUser.Profession = cueTextBox_ProfessionalTitle.Text.ToString().Trim();
            currentUser.Industry = cueComboBox_ProfessionalField.Text.ToString().Trim();
            try
            {
                Controller.UpdateUser(currentUser);
            }
            catch (Exception)
            {
            }
        }

        private void button_AddLocation_Click(object sender, EventArgs e)
        {
            User_Location_Purpose ulp = new User_Location_Purpose();
            ulp.Username = currentUser.Username;
            if (cueComboBox_InterestedIn.SelectedIndex >= 0 && cueComboBox_City.SelectedIndex >= 0)
            {
                ulp.Purposetype = cueComboBox_InterestedIn.SelectedValue.ToString().Trim();
                ulp.City = cueComboBox_City.SelectedValue.ToString().Trim();             
                ulp.FromDate = dateTimePickerFrom.Value.Date;
                ulp.ToDate = dateTimePickerTo.Value.Date;              
                try
                {
                    Controller.AddUserLocationPurpose(ulp);
                    UsersLocationsTimesToDataGrid();
                    DefaultValuesLocation();
                }
                catch (DbUpdateException ex)
                {
                    label_Messages.Text = ErrorHandler.HandleError(ex);
                }
            } 
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            User_Location_Purpose ulp = new User_Location_Purpose();
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            ulp.City = selectedRow.Cells[0].Value.ToString();
            ulp.Purposetype = selectedRow.Cells[2].Value.ToString();
            ulp.FromDate = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            ulp.ToDate = Convert.ToDateTime(selectedRow.Cells[4].Value.ToString());
            ulp.Username = currentUser.Username;

            Controller.DeleteUserLocatioPurpose(ulp);
            UsersLocationsTimesToDataGrid();

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.MinDate = dateTimePickerFrom.Value;
        }

     
    }
}


