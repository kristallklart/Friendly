using System;
using System.Drawing;
using System.Windows.Forms;
using Friendly.Model;
using Friendly.ControllerLayer;
using System.Data.Entity.Infrastructure;
using Friendly.Utilities;
using System.Data.Entity.Core;

namespace Friendly.View
{
    public partial class MatchForm : Form 
    {
        private User user;
       
        private User currentUser;

        public MatchForm(string selectedUser, User u)
        {
            try
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterParent;
                user = Controller.GetUser(selectedUser);
                currentUser = u;

                labelFirstName.Text = user.FirstName.ToString().Trim();
                labelLastName.Text = user.LastName.ToString().Trim();
                labelUserName.Text = user.Username.ToString().Trim();
                labelAge.Text = Controller.GetAge(selectedUser).ToString().Trim() + " years";

                if (user.Industry != null)
                {
                    labelProfessionalField.Text = user.Industry.ToString().Trim();
                }

                if (user.Profession != null)
                {
                    labelProfessionalTitle.Text = user.Profession.ToString().Trim();
                }

                if (user.About != null)
                {
                    textBoxAboutMe.Text = user.About.ToString().Trim();
                }

                if (user.Picture != null)
                {
                    picBoxMatchImage.Image = (Image)new ImageConverter().ConvertFrom(user.Picture);
                }
            }
            catch (EntityException e)
            {
                labelFeedbackMatch.Text = ErrorHandler.HandleError(e);
            }
        }
       
        private void buttonMatchMessage_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.AddMatch(currentUser, user.Username);
                Controller.AddMatch(user, currentUser.Username);
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                labelFeedbackMatch.Text = ErrorHandler.HandleError(ex);
            }
            catch (EntityException ex)
            {
                labelFeedbackMatch.Text = ErrorHandler.HandleError(ex);
            }
        }       
    }
}
