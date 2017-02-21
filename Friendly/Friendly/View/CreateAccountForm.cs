using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using Friendly.Utilities;
using Friendly.Model;
using Friendly.DatabaseAccessLayer;
using Friendly.ControllerLayer;
using Sodium;
using Sodium.Exceptions;

namespace Friendly.View
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
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
                User user = new User();
                user.Username = textBoxUsername.Text.Trim();
                user.Password = PasswordHash.ScryptHashString(textBoxPassword.Text.Trim(), PasswordHash.Strength.Medium);
                user.FirstName = textBoxFirstName.Text.Trim();
                user.LastName = textBoxLastName.Text.Trim();
                try
                {
                    Controller.AddNewUser(user);
                }
                catch (SqlException ex)
                {
                   labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (Exception ex)
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
                        this.errorProviderTextBoxes.SetError(tempBox, "Please enter a username.");
                        break;
                    case ("textBoxPassword"):
                        this.errorProviderTextBoxes.SetError(tempBox, "Please enter a password.");
                        break;
                    case ("textBoxFirstName"):
                        this.errorProviderTextBoxes.SetError(tempBox, "Please enter your firstname.");
                        break;
                    case ("textBoxLastName"):
                        this.errorProviderTextBoxes.SetError(tempBox, "Please enter your lastname.");
                        break;
                    default:
                        this.errorProviderTextBoxes.SetError(tempBox, "Please fill in all the details.");
                        break;
                }
            }
            else
                e.Cancel = false;
        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            this.errorProviderTextBoxes.SetError(sender as Control, string.Empty);
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            //int[] days = Enumerable.Range(1, 31).ToArray();
            //comboBoxDay.Items.Add("Day");
            //foreach (int day in days)
            //{
            //    comboBoxDay.Items.Add(day);
            //}
            
            //comboBoxDay.SelectedIndex = 0;
            
        }
    }
}
