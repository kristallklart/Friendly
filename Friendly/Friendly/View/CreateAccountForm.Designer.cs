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
            this.components = new System.ComponentModel.Container();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelMustLastName = new System.Windows.Forms.Label();
            this.labelMustPassword = new System.Windows.Forms.Label();
            this.labelMustFirstName = new System.Windows.Forms.Label();
            this.labelMustUsername = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.groupBoxComponents = new System.Windows.Forms.GroupBox();
            this.errorProviderTextBoxes = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(22, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(22, 68);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(22, 94);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(55, 13);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Firstname:";
            // 
            // textBoxUsername
            // 
            this.errorProviderTextBoxes.SetIconPadding(this.textBoxUsername, 4);
            this.textBoxUsername.Location = new System.Drawing.Point(86, 39);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 20);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxUsername.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxPassword
            // 
            this.errorProviderTextBoxes.SetIconPadding(this.textBoxPassword, 4);
            this.textBoxPassword.Location = new System.Drawing.Point(86, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(136, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxPassword.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxFirstName
            // 
            this.errorProviderTextBoxes.SetIconPadding(this.textBoxFirstName, 4);
            this.textBoxFirstName.Location = new System.Drawing.Point(86, 91);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 20);
            this.textBoxFirstName.TabIndex = 5;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxFirstName.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(25, 153);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(91, 23);
            this.buttonCreateAccount.TabIndex = 7;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(22, 121);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Lastname:";
            // 
            // textBoxLastName
            // 
            this.errorProviderTextBoxes.SetIconPadding(this.textBoxLastName, 4);
            this.textBoxLastName.Location = new System.Drawing.Point(86, 117);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(136, 20);
            this.textBoxLastName.TabIndex = 6;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxLastName.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // labelMustLastName
            // 
            this.labelMustLastName.AutoSize = true;
            this.labelMustLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustLastName.ForeColor = System.Drawing.Color.Red;
            this.labelMustLastName.Location = new System.Drawing.Point(228, 121);
            this.labelMustLastName.Name = "labelMustLastName";
            this.labelMustLastName.Size = new System.Drawing.Size(13, 17);
            this.labelMustLastName.TabIndex = 12;
            this.labelMustLastName.Text = "*";
            // 
            // labelMustPassword
            // 
            this.labelMustPassword.AutoSize = true;
            this.labelMustPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustPassword.ForeColor = System.Drawing.Color.Red;
            this.labelMustPassword.Location = new System.Drawing.Point(228, 68);
            this.labelMustPassword.Name = "labelMustPassword";
            this.labelMustPassword.Size = new System.Drawing.Size(13, 17);
            this.labelMustPassword.TabIndex = 11;
            this.labelMustPassword.Text = "*";
            // 
            // labelMustFirstName
            // 
            this.labelMustFirstName.AutoSize = true;
            this.labelMustFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustFirstName.ForeColor = System.Drawing.Color.Red;
            this.labelMustFirstName.Location = new System.Drawing.Point(228, 94);
            this.labelMustFirstName.Name = "labelMustFirstName";
            this.labelMustFirstName.Size = new System.Drawing.Size(13, 17);
            this.labelMustFirstName.TabIndex = 10;
            this.labelMustFirstName.Text = "*";
            // 
            // labelMustUsername
            // 
            this.labelMustUsername.AutoSize = true;
            this.labelMustUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustUsername.ForeColor = System.Drawing.Color.Red;
            this.labelMustUsername.Location = new System.Drawing.Point(228, 42);
            this.labelMustUsername.Name = "labelMustUsername";
            this.labelMustUsername.Size = new System.Drawing.Size(13, 17);
            this.labelMustUsername.TabIndex = 9;
            this.labelMustUsername.Text = "*";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(131, 153);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(12, 283);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 13);
            this.labelFeedback.TabIndex = 13;
            // 
            // groupBoxComponents
            // 
            this.groupBoxComponents.Controls.Add(this.textBoxUsername);
            this.groupBoxComponents.Controls.Add(this.textBoxPassword);
            this.groupBoxComponents.Controls.Add(this.textBoxFirstName);
            this.groupBoxComponents.Controls.Add(this.labelMustLastName);
            this.groupBoxComponents.Controls.Add(this.textBoxLastName);
            this.groupBoxComponents.Controls.Add(this.labelMustPassword);
            this.groupBoxComponents.Controls.Add(this.labelMustFirstName);
            this.groupBoxComponents.Controls.Add(this.labelMustUsername);
            this.groupBoxComponents.Controls.Add(this.buttonCancel);
            this.groupBoxComponents.Controls.Add(this.labelFirstName);
            this.groupBoxComponents.Controls.Add(this.labelPassword);
            this.groupBoxComponents.Controls.Add(this.buttonCreateAccount);
            this.groupBoxComponents.Controls.Add(this.labelLastName);
            this.groupBoxComponents.Controls.Add(this.labelUsername);
            this.groupBoxComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxComponents.Location = new System.Drawing.Point(15, 12);
            this.groupBoxComponents.Name = "groupBoxComponents";
            this.groupBoxComponents.Size = new System.Drawing.Size(344, 260);
            this.groupBoxComponents.TabIndex = 14;
            this.groupBoxComponents.TabStop = false;
            this.groupBoxComponents.Text = "Please fill in your details";
            // 
            // errorProviderTextBoxes
            // 
            this.errorProviderTextBoxes.BlinkRate = 50;
            this.errorProviderTextBoxes.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTextBoxes.ContainerControl = this;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 305);
            this.Controls.Add(this.groupBoxComponents);
            this.Controls.Add(this.labelFeedback);
            this.Name = "CreateAccountForm";
            this.Text = "Create account";
            this.groupBoxComponents.ResumeLayout(false);
            this.groupBoxComponents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMustUsername;
        private System.Windows.Forms.Label labelMustLastName;
        private System.Windows.Forms.Label labelMustPassword;
        private System.Windows.Forms.Label labelMustFirstName;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.GroupBox groupBoxComponents;
        private System.Windows.Forms.ErrorProvider errorProviderTextBoxes;
    }
}