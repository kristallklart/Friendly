using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Friendly.Utilities;

namespace Friendly.View
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            //if(textBoxUsername.Text.Trim() != "" && textBoxPassword.Text.Trim() != "" && textBoxFirstName.Text.Trim() != "" &&)
            //{
            //    textBoxLastName.Text = "haha";
            //}
            if (Utils.CheckTextBoxes(this))
                textBoxFirstName.Text = "haha";
        }
    }
}
