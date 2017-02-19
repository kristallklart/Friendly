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
            for (int i = 1940; i <= 1999; i++)
            {
                comboBox_Year.Items.Add(i);
            }
        }
        private void button_UpdateDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
