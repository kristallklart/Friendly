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


namespace Friendly.View
{
    public partial class MainForm : Form
    {

        private User currentUser;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(User user)
        {
            currentUser = user;
            InitializeComponent();
            tabControlMain.SelectedIndexChanged += new EventHandler(TabControlMain_SelectedIndexChanged);
            
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = Controller.GetUserLocations(currentUser.Username);
                    break;
                case 1:
                    dataGridView_MyMatchesCities.DataSource = Controller.GetUserLocations(currentUser.Username);
                    break;
            }
        }
    



        private void button_UpdateDetails_Click(object sender, EventArgs e)
        {

        }
         
        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox_FirstName.Text = currentUser.FirstName;
            textBox_LastName.Text = currentUser.LastName;
            label_Age.Text = Controller.GetAge(currentUser.Username).ToString();
            comboBox_ProfessionalField.DataSource = Controller.GetFieldOfProfessions();
            comboBox_ProfessionalField.DisplayMember = "Industry";
            
            if (currentUser.Industry != null)
            {
                comboBox_ProfessionalField.Text = currentUser.Industry;
            }else
            {
                comboBox_ProfessionalField.Text = "Field of profession";
            }

            if (currentUser.Profession != null)
            {
                cueTextBox_ProfessionalTitle.Text = currentUser.Profession;
            }

            if(currentUser.About != null)
            {
                textBox_AboutMe.Text = currentUser.About;
            }
        }

        private void dataGridView_MyMatchesCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_Age_Click(object sender, EventArgs e)
        {

        }
    }
}


