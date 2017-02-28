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
//using Friendly.Oberverpattern;

namespace Friendly.View
{
    public partial class MatchForm : Form 
    {
        private User user;
       
        private User currentUser;
        public MatchForm(string selectedUser,User currentuser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            user = Controller.GetUser(selectedUser);
            currentUser = currentuser;

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
        private void buttonMatchMessage_Click(object sender, EventArgs e)
        {
            Controller.AddMatch(currentUser, user.Username);
            this.Close();

            

        }
    }
}
