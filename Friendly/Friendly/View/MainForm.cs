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
                    dataGridView1.Columns[1].Visible = false;
                    for (int i = 5;  i < dataGridView1.Columns.Count ; i++)
                        dataGridView1.Columns[i].Visible = false;



                    break;
                case 1:
                    dataGridView_MyMatchesCities.DataSource = Controller.GetUserLocations(currentUser.Username);
                    for (int i = 1; i < dataGridView_MyMatchesCities.Columns.Count; i++)
                        dataGridView_MyMatchesCities.Columns[i].Visible = false;
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


