using System;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Core;
using Friendly.Utilities;
using Friendly.Model;
using Friendly.ControllerLayer;
using Sodium;

namespace Friendly.View
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
            if (this.ValidateChildren())
            {
                try
                {
                    User user = new User();
                    user.Username = textBoxUsername.Text.Trim();
                    user.Password = PasswordHash.ScryptHashString(textBoxPassword.Text.Trim(),
                        PasswordHash.Strength.Medium);
                    user.FirstName = textBoxFirstName.Text.Trim();
                    user.LastName = textBoxLastName.Text.Trim();
                    int day;
                    int month;
                    int year;

                    if (int.TryParse(cueComboBoxDay.SelectedItem.ToString(), out day) &&
                        int.TryParse(cueComboBoxMonth.SelectedItem.ToString(), out month) &&
                        int.TryParse(cueComboBoxYear.SelectedItem.ToString(), out year))
                    {
                        DateTime birthdate = new DateTime(year, month, day);
                        user.Birthdate = birthdate;
                    }

                    Controller.AddNewUser(user);
                    this.DialogResult = DialogResult.OK;
                }
                catch (DbUpdateException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (EntityException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (DbEntityValidationException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }              
            }
        }
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tempBox = sender as TextBox;
            if (tempBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                labelFeedback.Text = "Please fill in all the details.";
                switch (tempBox.Name.Trim())
                {
                    case ("textBoxUsername"):
                        this.errorProvider.SetError(tempBox, "Please enter a username.");
                        break;
                    case ("textBoxPassword"):
                        this.errorProvider.SetError(tempBox, "Please enter a password.");
                        break;
                    case ("textBoxFirstName"):
                        this.errorProvider.SetError(tempBox, "Please enter your firstname.");
                        break;
                    case ("textBoxLastName"):
                        this.errorProvider.SetError(tempBox, "Please enter your lastname.");
                        break;
                    default:
                        this.errorProvider.SetError(tempBox, "Please fill in all the details.");
                        break;
                }
            }
            else
                e.Cancel = false;
        }
        private void control_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(sender as Control, string.Empty);
        }
        private void cueComboBox_Validating(object sender, CancelEventArgs e)
        {
            CueComboBox tempCueBox = sender as CueComboBox;
            if (tempCueBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                labelFeedback.Text = "Please fill in all the details.";
                this.errorProvider.SetError(cueComboBoxYear, "Please fill in a complete birthdate.");
            }
            else
                e.Cancel = false;
        }
        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            int[] days = Enumerable.Range(1, 31).ToArray();

            foreach (int day in days)
            {
                cueComboBoxDay.Items.Add(day);
            }

            int[] months = Enumerable.Range(1, 12).ToArray();

            foreach (int month in months)
            {
                cueComboBoxMonth.Items.Add(month);
            }

            int startYear = 1899;
            int[] years = Enumerable.Range(startYear, (DateTime.Now.Year - 17) - startYear).ToArray();

            foreach (int year in years)
            {
                cueComboBoxYear.Items.Add(year);
            }
        }
    }
}