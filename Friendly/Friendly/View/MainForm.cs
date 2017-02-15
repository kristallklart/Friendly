using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for (int i = 1940; i <= 1999; i++)
            {
                comboBox_Year.Items.Add(i);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //private void tabSearchMatch_Click(object sender, EventArgs e)
        //{

        //}

        //private void tabMyProfile_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void txtBox_ProfessionalTitle_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        //{

        //}

        //private void picBox_ProfilePic_Click(object sender, EventArgs e)
        //{

        //}

        //private void label_From_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBox_Hometown_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox_Month_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox_Money_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkBox_Time_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void label_To_Click(object sender, EventArgs e)
        //{

        //}
    }
}
