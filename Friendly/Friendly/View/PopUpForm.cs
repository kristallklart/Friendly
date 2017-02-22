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
using Friendly.Oberverpattern;

namespace Friendly.View
{
    public partial class PopUpForm : Form ,IObserver
    {
        private User user;
        public PopUpForm(string selectedUser)
        {
            InitializeComponent();
            user = Controller.GetUser(selectedUser);
        
            labelMatchFirstName.Text = user.FirstName.ToString().Trim();
            labelMatchLastName.Text = user.LastName.ToString().Trim();
            labelMatchAge.Text = Controller.GetAge(selectedUser).ToString().Trim() + " years";
            if (user.Industry != null)
            {
                labelMatchProfessionalField.Text = user.Industry.ToString().Trim();
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



        private void buttonMatchMessage_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
