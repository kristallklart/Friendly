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
        
            label_MatchFirstName.Text = user.FirstName.ToString();
            label_MatchLastName.Text = user.LastName.ToString();
            label_ProfessionalTitle.Text = user.Profession.ToString();
            label_MatchAge.Text = Controller.GetAge(selectedUser).ToString() + " years";
            label_MatchProfessionalField.Text = user.Industry.ToString();
            textBox_AboutMe.Text = user.About.ToString();
        }
        public void Update(Observable o)
        {
            throw new NotImplementedException();
        }

        private void buttonMatchMessage_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
