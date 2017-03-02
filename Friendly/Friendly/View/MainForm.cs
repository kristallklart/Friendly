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
using System.Data.Entity.Core;
using System.Linq.Expressions;
using System.IO;
using Friendly.Utilities;

namespace Friendly.View
{
    public partial class MainForm : Form
    {
        private User currentUser;
        public delegate void UpdateTextMessage(string message);
        public UpdateTextMessage writeMessageDelegate;

        public MainForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
            TabControl tempTabControl = sender as TabControl;
            if (tempTabControl != null)
            {
                try
                {
                    switch (tempTabControl.SelectedIndex)
                    {
                        case 0:
                            UsersLocationsTimesToDataGrid();
                            break;
                        case 1:
                            UsersLocationsToDataGrid();
                            dataGridViewMyMatches.DataSource = null;
                            break;
                        case 2:
                            DataGridViewMyMessagesTab(currentUser);
                            break;
                    }
                }
                catch (EntityException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
            }            
        }

        public void CheckDate()
        {
            List<User_Location_Purpose> ulp = Controller.GetUserLocations(currentUser.Username);
            foreach (User_Location_Purpose u in ulp)
            {
                if (u.ToDate < DateTime.Today)
                {
                    Controller.DeleteUserLocationPurpose(u);
                }
            }
        }

        public void UsersLocationsTimesToDataGrid()
        {
            CheckDate();
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

        public void UsersLocationsToDataGrid()
        {
            try
            {
                dataGridViewMyMatchesCities.DataSource = Controller.GetUserOwnLocations(currentUser.Username);
                dataGridViewMyMatchesCities.Columns[0].HeaderText = "CITY";
                for (int i = 1; i < dataGridViewMyMatchesCities.Columns.Count; i++)
                {
                    dataGridViewMyMatchesCities.Columns[i].Visible = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                labelFeedback.Text = ErrorHandler.HandleError(ex);
            }
        }

        public void DataGridViewMyMessagesTab(User currentuser)
        {
            try
            {
                dataGridViewMyMessagesTab.DataSource = Controller.GetMatches(currentuser);
                dataGridViewMyMessagesTab.Columns[0].HeaderText = "USERNAME";
                for (int i = 1; i < dataGridViewMyMessagesTab.Columns.Count; i++)
                {
                    dataGridViewMyMessagesTab.Columns[i].Visible = false;
                }
            }
            catch (ArgumentNullException ex)
            {
                labelFeedback.Text = ErrorHandler.HandleError(ex);
            }
        }

        public void UsersByCityToDataGrid(string selectedCity, User currentuser)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.MinDate = DateTime.Today;
            dateTimePickerTo.MinDate = DateTime.Today;            
            textBoxFirstName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            
            try
            {
                UsersLocationsTimesToDataGrid();
                DefaultValuesLocation();
                labelAge.Text = Controller.GetAge(currentUser.Username).ToString().Trim() + " years";         
                cueComboBoxProfessionalField.DataSource = Controller.GetFieldOfProfessions();             
            }
            catch (EntityException ex)
            {
                labelFeedback.Text = ErrorHandler.HandleError(ex);
            }
            catch (ArgumentNullException ex)
            {
                labelFeedback.Text = ErrorHandler.HandleError(ex);
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
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today;
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

        private void dataGridViewMyMatchesCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewMyMatchesCities.Rows[e.RowIndex];
                    string selectedCity = selectedRow.Cells[0].Value.ToString().Trim();
                    UsersByCityToDataGrid(selectedCity, currentUser);
                }
                catch (EntityException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
            }
        }

        private void dataGridViewMyMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMyMatches.Rows[e.RowIndex];
                string selectedUser = selectedRow.Cells[1].Value.ToString().Trim();
                using (MatchForm showUserForm = new MatchForm(selectedUser,currentUser))
                {
                    showUserForm.ShowDialog();
                }
            }
        }

        private void buttonUpdateDetails_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    currentUser.FirstName = textBoxFirstName.Text.ToString().Trim();
                    currentUser.LastName = textBoxLastName.Text.ToString().Trim();
                    currentUser.About = textBoxAboutMe.Text.ToString().Trim();
                    currentUser.Profession = cueTextBoxProfessionalTitle.Text.ToString().Trim();

                    if (!cueComboBoxProfessionalField.Text.ToString().Trim().Equals(""))
                    {
                        currentUser.Industry = cueComboBoxProfessionalField.Text.ToString().Trim();
                    }

                    Controller.UpdateUser(currentUser);
                }
                catch (DbUpdateException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (EntityException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                labelFeedback.Text = "Successfully updated your details.";
            }
        }

        private void buttonAddLocation_Click(object sender, EventArgs e)
        {
            User_Location_Purpose ulp = new User_Location_Purpose();
            ulp.Username = currentUser.Username;

            if (cueComboBoxInterestedIn.SelectedIndex >= 0 && cueComboBoxCity.SelectedIndex >= 0)
            {
                try
                {
                    ulp.Purposetype = cueComboBoxInterestedIn.SelectedValue.ToString().Trim();
                    ulp.City = cueComboBoxCity.SelectedValue.ToString().Trim();
                    ulp.FromDate = dateTimePickerFrom.Value.Date;
                    ulp.ToDate = dateTimePickerTo.Value.Date;
                    Controller.AddUserLocationPurpose(ulp);
                    UsersLocationsTimesToDataGrid();
                    DefaultValuesLocation();
                    this.errorProvider.SetError(cueComboBoxCity, string.Empty);
                    labelFeedback.Text = "Successfully added a new preference to your account";
                   
                }
                catch (DbUpdateException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (EntityException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }              
            }
            else
            {
                labelFeedback.Text = "Please select an interest and a city.";
                this.errorProvider.SetError(cueComboBoxCity, "Please enter an interest and a city.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                User_Location_Purpose ulp = new User_Location_Purpose();
                DataGridViewRow selectedRow = dataGridViewMyCities.CurrentRow;
                if (selectedRow != null)
                {
                    ulp.City = selectedRow.Cells[0].Value.ToString().Trim();
                    ulp.Purposetype = selectedRow.Cells[2].Value.ToString().Trim();
                    ulp.FromDate = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString().Trim());
                    ulp.ToDate = Convert.ToDateTime(selectedRow.Cells[4].Value.ToString().Trim());
                    ulp.Username = currentUser.Username;
                    Controller.DeleteUserLocationPurpose(ulp);
                    UsersLocationsTimesToDataGrid();
                    labelFeedback.Text = "Successfully deleted a preference from your account";
                }
                else
                {
                    labelFeedback.Text = "Please select a preference from the table.";
                }
                
            }
            catch (DbUpdateException ex)
            {
                labelFeedback.Text = ErrorHandler.HandleError(ex);
            }         
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTo.MinDate = dateTimePickerFrom.Value;
        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    openFile.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                    try
                    {
                        string fileContent = openFile.FileName;
                        Image newImage = Image.FromFile(fileContent);
                        byte[] result = (byte[]) new ImageConverter().ConvertTo(newImage, typeof(byte[]));
                        picBoxProfilePic.Image = newImage;
                        currentUser.Picture = result;
                        Controller.SaveProfilePicture(currentUser.Username, result);
                        labelFeedback.Text = "Picture saved";
                    }
                    catch (DbUpdateException ex)
                    {
                        labelFeedback.Text = ErrorHandler.HandleError(ex);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        labelFeedback.Text = ErrorHandler.HandleError(ex);
                    }
                    catch (FileNotFoundException ex)
                    {
                        labelFeedback.Text = ErrorHandler.HandleError(ex);
                    }
                    catch (ArgumentException ex)
                    {
                        labelFeedback.Text = ErrorHandler.HandleError(ex);
                    }          
                }
            }              
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            string message = cueTextBoxMessage.Text.Trim();
            DataGridViewRow selectedRow = dataGridViewMyMessagesTab.CurrentRow;
            string dcc2Name = selectedRow.Cells[0].Value.ToString().Trim();
            DelegateBroadcastClient dcc1 = new DelegateBroadcastClient(currentUser.Username);
            DelegateBroadcastClient dcc2 = new DelegateBroadcastClient(dcc2Name);
            Controller.AddMessage(currentUser.Username, dcc2Name, message);
            DelegateBroadcastServer.sendMsgToAll(message);
            WriteMessages();


        }
        private void WriteMessage(string message)
        {
            textBoxMessages.Text = message;
        }
        public void ShowMessage(string message)
        {
            string msg = message;
            textBoxMessages.Text = msg;
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tempBox = sender as TextBox;
            if (tempBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                labelFeedback.Text = "Please make sure both firstname and lastname are entered.";
                this.errorProvider.SetError(textBoxLastName, "Please enter a firstname and a lastname.");
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

        private void dataGridViewMyMessagesTab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            WriteMessages();
            

    }
        private void WriteMessages ()
        {
            DataGridViewRow selectedR = dataGridViewMyMessagesTab.CurrentRow;
            string TheSender = currentUser.Username;
            string reciever = selectedR.Cells[0].Value.ToString().Trim();
            List<string> messageContent = new List<string>();
            List<Friendly.Model.Message> allmessages = Controller.GetAllMessages(TheSender, reciever);
            foreach (Friendly.Model.Message m in allmessages)
            {
                string a = (m.Sender.ToString()+": "+m.Content.ToString());
                messageContent.Add(a);
            }
            textBoxMessages.Text = String.Join(Environment.NewLine, messageContent);
            cueTextBoxMessage.Text = string.Empty;

        }

        private void cueTextBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


