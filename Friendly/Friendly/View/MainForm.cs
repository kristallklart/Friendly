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
using System.Linq.Expressions;
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
            TabControl tempTabControl = sender as TabControl;
            if (tempTabControl != null)
            {
                switch (tempTabControl.SelectedIndex)
                {
                case 0:
                    UsersLocationsTimesToDataGrid();
                    break;
                case 1:
                    UsersLocationsToDataGrid();
                    break;
                }
            }            
        }
        public void UsersLocationsTimesToDataGrid()
        {
            try
            {
                dataGridViewMyCities.DataSource = Controller.GetUserLocations(currentUser.Username);
                dataGridViewMyCities.Columns[1].Visible = false;
                for (int i = 5; i < dataGridViewMyCities.Columns.Count; i++)
                {
                    dataGridViewMyCities.Columns[i].Visible = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
        }
        public void UsersLocationsToDataGrid()
        {
            try
            {
                dataGridViewMyMatchesCities.DataSource = Controller.GetUserLocations(currentUser.Username);
                for (int i = 1; i < dataGridViewMyMatchesCities.Columns.Count; i++)
                {
                    dataGridViewMyMatchesCities.Columns[i].Visible = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
        }
        public void UsersByCityToDataGrid(string selectedCity, User currentuser)
        {
            try
            {
                dataGridViewMyMatches.DataSource = Controller.GetUsersByCity(selectedCity, currentuser);
                for (int i = 5; i < dataGridViewMyMatches.Columns.Count; i++)
                {
                    dataGridViewMyMatches.Columns[i].Visible = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser.Industry != null)
            {
                cueComboBoxProfessionalField.Text = currentUser.Industry;
            }

            if (currentUser.Profession != null)
            {
                cueTextBoxProfessionalTitle.Text = currentUser.Profession;
            }

            if (currentUser.About != null)
            {
                textBoxAboutMe.Text = currentUser.About;
            }

            dateTimePickerFrom.MinDate = DateTime.Today;
            dateTimePickerTo.MinDate = DateTime.Today;
            UsersLocationsTimesToDataGrid();
            textBoxFirstName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;

            try
            {
                labelAge.Text = Controller.GetAge(currentUser.Username).ToString() + " years";
                cueComboBoxProfessionalField.DataSource = Controller.GetFieldOfProfessions();
                DefaultValuesLocation();
            }
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }

            cueComboBoxProfessionalField.DisplayMember = "Industry";
            cueComboBoxProfessionalField.SelectedIndex = -1;
            cueComboBoxProfessionalField.CueText = "Field of profession";            
        }
        private void DefaultValuesLocation()
        {
            cueComboBoxInterestedIn.DataSource = Controller.GetPurposes();
            cueComboBoxInterestedIn.DisplayMember = "Purposetype";
            cueComboBoxInterestedIn.ValueMember = "Purposetype";
            cueComboBoxInterestedIn.SelectedIndex = -1;
            cueComboBoxInterestedIn.CueText = "Interested in";
            cueComboBoxCity.DataSource = Controller.GetLocations();
            cueComboBoxCity.DisplayMember = "City";
            cueComboBoxCity.ValueMember = "City";
            cueComboBoxCity.SelectedIndex = -1;
            cueComboBoxCity.CueText = "City";            
        }

        private void dataGridView_MyMatchesCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMyMatchesCities.Rows[e.RowIndex];
                string selectedCity = selectedRow.Cells[0].Value.ToString();
                UsersByCityToDataGrid(selectedCity, currentUser);
            }
        }

        private void dataGridView_MyMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMyMatches.Rows[e.RowIndex];
                string selectedUser = selectedRow.Cells[1].Value.ToString();
                using (PopUpForm showUserForm = new PopUpForm(selectedUser))
                {
                    showUserForm.Show();
                }
            }
        }

        private void button_UpdateDetails_Click(object sender, EventArgs e)
        {
            currentUser.FirstName= textBoxFirstName.Text.ToString().Trim();
            currentUser.LastName = textBoxLastName.Text.ToString().Trim();
            currentUser.About = textBoxAboutMe.Text.ToString().Trim();
            currentUser.Profession = cueTextBoxProfessionalTitle.Text.ToString().Trim();
            if (!cueComboBoxProfessionalField.Text.ToString().Trim().Equals(""))
            {
                currentUser.Industry = cueComboBoxProfessionalField.Text.ToString().Trim();
            }            
            try
            {
                Controller.UpdateUser(currentUser);
            }
            catch (DbUpdateException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
        }

        private void button_AddLocation_Click(object sender, EventArgs e)
        {
            User_Location_Purpose ulp = new User_Location_Purpose();
            ulp.Username = currentUser.Username;
            if (cueComboBoxInterestedIn.SelectedIndex >= 0 && cueComboBoxCity.SelectedIndex >= 0)
            {
                ulp.Purposetype = cueComboBoxInterestedIn.SelectedValue.ToString().Trim();
                ulp.City = cueComboBoxCity.SelectedValue.ToString().Trim();             
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
                    labelMessages.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
                {
                    labelMessages.Text = ErrorHandler.HandleError(ex);
                }             
            } 
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            User_Location_Purpose ulp = new User_Location_Purpose();
            DataGridViewRow selectedRow = dataGridViewMyCities.CurrentRow;
            ulp.City = selectedRow.Cells[0].Value.ToString().Trim();
            ulp.Purposetype = selectedRow.Cells[2].Value.ToString().Trim();
            ulp.FromDate = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString().Trim());
            ulp.ToDate = Convert.ToDateTime(selectedRow.Cells[4].Value.ToString().Trim());
            ulp.Username = currentUser.Username;

            try
            {
                Controller.DeleteUserLocatioPurpose(ulp);
            }
            catch (DbUpdateException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
            UsersLocationsTimesToDataGrid();
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.MinDate = dateTimePickerFrom.Value;
        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {

        }
    }
}


