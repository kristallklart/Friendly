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

        

        private void button_UpdateDetails_Click(object sender, EventArgs e)
        {
           
            

        }


    }
}
