using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Friendly.ControllerLayer;
using Friendly.Utilities;

namespace Friendly.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private void buttonNoLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm form = new CreateAccountForm();
            form.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
            if (this.ValidateChildren())
            {
                try
                {
                    if (Controller.CheckUsernameAndPassword(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim()))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (InvalidUserOrPasswordException ex)
                {
                    labelFeedback.Text = ErrorHandler.HandleError(ex);
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
