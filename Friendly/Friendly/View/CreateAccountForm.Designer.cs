namespace Friendly.View
{
    partial class CreateAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.groupBoxCreateAccount = new System.Windows.Forms.GroupBox();
            this.labelMustUsername = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMustFirstName = new System.Windows.Forms.Label();
            this.labelMustPassword = new System.Windows.Forms.Label();
            this.labelMustLastName = new System.Windows.Forms.Label();
            this.groupBoxCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(11, 44);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(11, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(11, 96);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(55, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Firstname:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(75, 41);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(75, 67);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(136, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(75, 93);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(14, 155);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(91, 23);
            this.buttonCreateAccount.TabIndex = 7;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 123);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Lastname:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(75, 120);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(136, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // groupBoxCreateAccount
            // 
            this.groupBoxCreateAccount.Controls.Add(this.labelMustLastName);
            this.groupBoxCreateAccount.Controls.Add(this.labelMustPassword);
            this.groupBoxCreateAccount.Controls.Add(this.labelMustFirstName);
            this.groupBoxCreateAccount.Controls.Add(this.labelMustUsername);
            this.groupBoxCreateAccount.Controls.Add(this.buttonCancel);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxUsername);
            this.groupBoxCreateAccount.Controls.Add(this.buttonCreateAccount);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxLastName);
            this.groupBoxCreateAccount.Controls.Add(this.labelUsername);
            this.groupBoxCreateAccount.Controls.Add(this.labelLastName);
            this.groupBoxCreateAccount.Controls.Add(this.labelPassword);
            this.groupBoxCreateAccount.Controls.Add(this.labelFirstName);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxFirstName);
            this.groupBoxCreateAccount.Controls.Add(this.textBoxPassword);
            this.groupBoxCreateAccount.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCreateAccount.Name = "groupBoxCreateAccount";
            this.groupBoxCreateAccount.Size = new System.Drawing.Size(257, 247);
            this.groupBoxCreateAccount.TabIndex = 9;
            this.groupBoxCreateAccount.TabStop = false;
            this.groupBoxCreateAccount.Text = "Create account";
            // 
            // labelMustUsername
            // 
            this.labelMustUsername.AutoSize = true;
            this.labelMustUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustUsername.ForeColor = System.Drawing.Color.Red;
            this.labelMustUsername.Location = new System.Drawing.Point(217, 44);
            this.labelMustUsername.Name = "labelMustUsername";
            this.labelMustUsername.Size = new System.Drawing.Size(13, 17);
            this.labelMustUsername.TabIndex = 9;
            this.labelMustUsername.Text = "*";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(120, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMustFirstName
            // 
            this.labelMustFirstName.AutoSize = true;
            this.labelMustFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustFirstName.ForeColor = System.Drawing.Color.Red;
            this.labelMustFirstName.Location = new System.Drawing.Point(217, 96);
            this.labelMustFirstName.Name = "labelMustFirstName";
            this.labelMustFirstName.Size = new System.Drawing.Size(13, 17);
            this.labelMustFirstName.TabIndex = 10;
            this.labelMustFirstName.Text = "*";
            // 
            // labelMustPassword
            // 
            this.labelMustPassword.AutoSize = true;
            this.labelMustPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustPassword.ForeColor = System.Drawing.Color.Red;
            this.labelMustPassword.Location = new System.Drawing.Point(217, 70);
            this.labelMustPassword.Name = "labelMustPassword";
            this.labelMustPassword.Size = new System.Drawing.Size(13, 17);
            this.labelMustPassword.TabIndex = 11;
            this.labelMustPassword.Text = "*";
            // 
            // labelMustLastName
            // 
            this.labelMustLastName.AutoSize = true;
            this.labelMustLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustLastName.ForeColor = System.Drawing.Color.Red;
            this.labelMustLastName.Location = new System.Drawing.Point(217, 123);
            this.labelMustLastName.Name = "labelMustLastName";
            this.labelMustLastName.Size = new System.Drawing.Size(13, 17);
            this.labelMustLastName.TabIndex = 12;
            this.labelMustLastName.Text = "*";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 280);
            this.Controls.Add(this.groupBoxCreateAccount);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account";
            this.groupBoxCreateAccount.ResumeLayout(false);
            this.groupBoxCreateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.GroupBox groupBoxCreateAccount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMustUsername;
        private System.Windows.Forms.Label labelMustLastName;
        private System.Windows.Forms.Label labelMustPassword;
        private System.Windows.Forms.Label labelMustFirstName;
    }
}