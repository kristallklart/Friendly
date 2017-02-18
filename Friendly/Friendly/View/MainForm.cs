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
                    UsersLocationsTimesToDataGrid();

                    break;
                case 1:
                    UsersLocationsToDataGrid();
                    break;
            }
        }
        public void UsersLocationsTimesToDataGrid()
        {
            dataGridView1.DataSource = Controller.GetUserLocations(currentUser.Username);
            dataGridView1.Columns[1].Visible = false;
            for (int i = 5; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;
        }
        public void UsersLocationsToDataGrid()
        {
            dataGridView_MyMatchesCities.DataSource = Controller.GetUserLocations(currentUser.Username);
            for (int i = 1; i < dataGridView_MyMatchesCities.Columns.Count; i++)
                dataGridView_MyMatchesCities.Columns[i].Visible = false;
        }


    

         
        private void MainForm_Load(object sender, EventArgs e)
        {
            UsersLocationsTimesToDataGrid();
            textBox_FirstName.Text = currentUser.FirstName;
            textBox_LastName.Text = currentUser.LastName;     
                  
            if (currentUser.Birthdate != null)
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

       

        private void label_Age_Click(object sender, EventArgs e)
        {

        }
    }
}


