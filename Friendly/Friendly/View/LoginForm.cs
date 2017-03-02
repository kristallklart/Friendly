using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.Entity.Core;
using Friendly.ControllerLayer;
using Friendly.Model;
using Friendly.Utilities;

namespace Friendly.View
{
    public partial class LoginForm : Form
    {
        private User user;
        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public LoginForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CreateAccountForm form = new CreateAccountForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    labelFeedback.Text = "Successfully created a new user";
                }
            }   
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
            if (this.ValidateChildren())
            {
                try
                {
                    User = Controller.CheckUsernameAndPassword(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                    this.DialogResult = DialogResult.OK;               
                }
                catch (EntityException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (InvalidUserOrPasswordException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
                }
                catch (ArgumentNullException ex)
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
                labelFeedback.Text = "Please fill in your username and password.";
                switch (tempBox.Name.Trim())
                {
                    case ("textBoxUsername"):
                        this.errorProviderTextBoxes.SetError(tempBox, "Please enter your username.");
                        break;
                    case ("textBoxPassword"):
                        this.errorProviderTextBoxes.SetError(tempBox, "Please enter your password.");
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
            this.errorProviderTextBoxes.SetError(sender as TextBox, string.Empty);
        }
    }
}
