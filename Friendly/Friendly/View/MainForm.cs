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
            TabControlMain.SelectedIndexChanged += new EventHandler(TabControlMain_SelectedIndexChanged);
            for (int i = 1940; i <= 1999; i++)
            {
                comboBox_Year.Items.Add(i);
            }
            
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Not it works");
                    break;
                case 1:
                    MessageBox.Show("YMjip it works");
                    break;
            }
        }
    }




}

