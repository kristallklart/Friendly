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
            AutoValidate = AutoValidate.Disable;
        }
        public MainForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Ser till att inga validation events körs innan "X" knappen        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // The upper right "X" was clicked
            {
                AutoValidate = AutoValidate.Disable;
            }
            base.WndProc(ref m);
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
                dataGridViewMyCities.Columns[0].HeaderText = "CITY";
                dataGridViewMyCities.Columns[2].HeaderText = "PURPOSE";
                dataGridViewMyCities.Columns[3].HeaderText = "FROM";
                dataGridViewMyCities.Columns[4].HeaderText = "TO";
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
                dataGridViewMyMatchesCities.Columns[0].HeaderText = "CITY";
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
                dataGridViewMyMatches.Columns[0].HeaderText = "CITY";
                dataGridViewMyMatches.Columns[1].HeaderText = "USERNAME";
                dataGridViewMyMatches.Columns[2].HeaderText = "PURPOSE";
                dataGridViewMyMatches.Columns[3].HeaderText = "FROM";
                dataGridViewMyMatches.Columns[4].HeaderText = "TO";
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
            dateTimePickerFrom.MinDate = DateTime.Today;
            dateTimePickerTo.MinDate = DateTime.Today;            
            textBoxFirstName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            UsersLocationsTimesToDataGrid();
            DefaultValuesLocation();
            try
            {
                labelAge.Text = Controller.GetAge(currentUser.Username).ToString().Trim() + " years";         
                cueComboBoxProfessionalField.DataSource = Controller.GetFieldOfProfessions();             
            }
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }
            cueComboBoxProfessionalField.DisplayMember = "Industry";
            cueComboBoxProfessionalField.CueText = "Field of profession";
            cueComboBoxProfessionalField.SelectedIndex = -1;
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
            if (currentUser.Picture != null)
            {
                picBoxProfilePic.Image = (Image)new ImageConverter().ConvertFrom(currentUser.Picture);
            }             
        }
        private void DefaultValuesLocation()
        {
            try
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
            catch (ArgumentNullException ex)
            {
                labelMessages.Text = ErrorHandler.HandleError(ex);
            }         
        }

        private void dataGridViewMyMatchesCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMyMatchesCities.Rows[e.RowIndex];
                string selectedCity = selectedRow.Cells[0].Value.ToString().Trim();
                UsersByCityToDataGrid(selectedCity, currentUser);
            }
        }

        private void dataGridViewMyMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMyMatches.Rows[e.RowIndex];
                string selectedUser = selectedRow.Cells[1].Value.ToString().Trim();
                using (PopUpForm showUserForm = new PopUpForm(selectedUser))
                {
                    showUserForm.ShowDialog();
                }
            }
        }

        private void buttonUpdateDetails_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                currentUser.FirstName = textBoxFirstName.Text.ToString().Trim();
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
                labelMessages.Text = "Successfully updated your details.";
            }
            else
            {
                
            }
        }

        private void buttonAddLocation_Click(object sender, EventArgs e)
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
                    
                }
                catch (DbUpdateException ex)
                {
                    labelMessages.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
                {
                    labelMessages.Text = ErrorHandler.HandleError(ex);
                }
                UsersLocationsTimesToDataGrid();
                DefaultValuesLocation();
            } 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK) // Ser till att koden inte fortsätter om man inte valt att öppna en fil.
                {
                    string fileContent = openFile.FileName;

                    try
                    {
                        Image newImage = Image.FromFile(fileContent);
                        byte[] result = (byte[]) new ImageConverter().ConvertTo(newImage, typeof(byte[]));
                        picBoxProfilePic.Image = newImage;
                        Controller.SaveProfilePicture(currentUser.Username, result);
                    }
                    catch (DbUpdateException ex)
                    {
                        labelMessages.Text = ErrorHandler.HandleError(ex);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        labelMessages.Text = ErrorHandler.HandleError(ex);
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        labelMessages.Text = ErrorHandler.HandleError(ex);
                    }
                    catch (ArgumentException ex)
                    {
                        labelMessages.Text = ErrorHandler.HandleError(ex);
                    }          
                }
            }              
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            string message = cueTextBoxMessage.Text;
            DelegateBroadcastClient dcc1 = new DelegateBroadcastClient(currentUser.Username);
            //DelegateBroadcastClient dcc2 = new DelegateBroadcastClient();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tempBox = sender as TextBox;
            if (tempBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                labelMessages.Text = "Please make sure both Firstname and Lastname is entered";
                this.errorProvider.SetError(textBoxLastName, "Please enter a firstname and lastname.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void control_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(sender as Control, string.Empty);
        }
    }
}


