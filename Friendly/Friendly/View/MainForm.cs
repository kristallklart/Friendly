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

        }

        private void dataGridView_MyMatchesCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_Age_Click(object sender, EventArgs e)
        {

        }
    }
}


