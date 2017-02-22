namespace Friendly.View
{
    partial class PopUpForm
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
            this.picBoxMatchImage = new System.Windows.Forms.PictureBox();
            this.label_MatchFirstName = new System.Windows.Forms.Label();
            this.label_MatchLastName = new System.Windows.Forms.Label();
            this.label_MatchAge = new System.Windows.Forms.Label();
            this.label_MatchProfessionalField = new System.Windows.Forms.Label();
            this.label_ProfessionalTitle = new System.Windows.Forms.Label();
            this.label_Aboutme = new System.Windows.Forms.Label();
            this.textBox_AboutMe = new System.Windows.Forms.TextBox();
            this.buttonMatchMessage = new System.Windows.Forms.Button();
            this.labelMatchFirstName = new System.Windows.Forms.Label();
            this.labelMatchLastName = new System.Windows.Forms.Label();
            this.labelMatchAge = new System.Windows.Forms.Label();
            this.labelMatchProfessionalField = new System.Windows.Forms.Label();
            this.labelProfessionalTitle = new System.Windows.Forms.Label();
            this.labelAboutme = new System.Windows.Forms.Label();
            this.textBoxAboutMe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxMatchImage
            // 
            this.picBoxMatchImage.Location = new System.Drawing.Point(46, 82);
            this.picBoxMatchImage.Name = "picBoxMatchImage";
            this.picBoxMatchImage.Size = new System.Drawing.Size(108, 109);
            this.picBoxMatchImage.TabIndex = 0;
            this.picBoxMatchImage.TabStop = false;
            // 
            // label_MatchFirstName
            // 
            this.labelMatchFirstName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchFirstName.Location = new System.Drawing.Point(192, 84);
            this.labelMatchFirstName.Name = "label_MatchFirstName";
            this.labelMatchFirstName.Size = new System.Drawing.Size(100, 20);
            this.labelMatchFirstName.TabIndex = 9;
            this.labelMatchFirstName.Text = "FirstName";
            // 
            // label_MatchLastName
            // 
            this.labelMatchLastName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchLastName.Location = new System.Drawing.Point(326, 84);
            this.labelMatchLastName.Name = "label_MatchLastName";
            this.labelMatchLastName.Size = new System.Drawing.Size(100, 20);
            this.labelMatchLastName.TabIndex = 10;
            this.labelMatchLastName.Text = "LastName";
            // 
            // label_MatchAge
            // 
            this.labelMatchAge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchAge.Location = new System.Drawing.Point(192, 109);
            this.labelMatchAge.Name = "label_MatchAge";
            this.labelMatchAge.Size = new System.Drawing.Size(100, 20);
            this.labelMatchAge.TabIndex = 11;
            this.labelMatchAge.Text = "Age";
            // 
            // label_MatchProfessionalField
            // 
            this.labelMatchProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchProfessionalField.Location = new System.Drawing.Point(192, 140);
            this.labelMatchProfessionalField.Name = "label_MatchProfessionalField";
            this.labelMatchProfessionalField.Size = new System.Drawing.Size(150, 20);
            this.labelMatchProfessionalField.TabIndex = 12;
            this.labelMatchProfessionalField.Text = "FieldOfProfession";
            // 
            // label_ProfessionalTitle
            // 
            this.labelProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfessionalTitle.Location = new System.Drawing.Point(192, 171);
            this.labelProfessionalTitle.Name = "label_ProfessionalTitle";
            this.labelProfessionalTitle.Size = new System.Drawing.Size(150, 20);
            this.labelProfessionalTitle.TabIndex = 13;
            this.labelProfessionalTitle.Text = "ProfessionalTitle";
            // 
            // label_Aboutme
            // 
            this.labelAboutme.AutoSize = true;
            this.labelAboutme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutme.Location = new System.Drawing.Point(43, 235);
            this.labelAboutme.Name = "label_Aboutme";
            this.labelAboutme.Size = new System.Drawing.Size(71, 19);
            this.labelAboutme.TabIndex = 14;
            this.labelAboutme.Text = "About Me";
            // 
            // textBox_AboutMe
            // 
            this.textBoxAboutMe.Location = new System.Drawing.Point(46, 251);
            this.textBoxAboutMe.Multiline = true;
            this.textBoxAboutMe.Name = "textBox_AboutMe";
            this.textBoxAboutMe.ReadOnly = true;
            this.textBoxAboutMe.Size = new System.Drawing.Size(380, 123);
            this.textBoxAboutMe.TabIndex = 15;
            // 
            // buttonMatchMessage
            // 
            this.buttonMatchMessage.Location = new System.Drawing.Point(442, 335);
            this.buttonMatchMessage.Name = "buttonMatchMessage";
            this.buttonMatchMessage.Size = new System.Drawing.Size(111, 39);
            this.buttonMatchMessage.TabIndex = 16;
            this.buttonMatchMessage.Text = "Match and Message";
            this.buttonMatchMessage.UseVisualStyleBackColor = true;
            this.buttonMatchMessage.Click += new System.EventHandler(this.buttonMatchMessage_Click);
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 400);
            this.Controls.Add(this.textBoxAboutMe);
            this.Controls.Add(this.labelAboutme);
            this.Controls.Add(this.labelProfessionalTitle);
            this.Controls.Add(this.labelMatchProfessionalField);
            this.Controls.Add(this.labelMatchAge);
            this.Controls.Add(this.labelMatchLastName);
            this.Controls.Add(this.labelMatchFirstName);
            this.Controls.Add(this.buttonMatchMessage);
            this.Controls.Add(this.textBox_AboutMe);
            this.Controls.Add(this.label_Aboutme);
            this.Controls.Add(this.label_ProfessionalTitle);
            this.Controls.Add(this.label_MatchProfessionalField);
            this.Controls.Add(this.label_MatchAge);
            this.Controls.Add(this.label_MatchLastName);
            this.Controls.Add(this.label_MatchFirstName);
            this.Controls.Add(this.picBoxMatchImage);
            this.Name = "PopUpForm";
            this.Text = " PopUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatchImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMatchImage;
        private System.Windows.Forms.Label label_MatchFirstName;
        private System.Windows.Forms.Label label_MatchLastName;
        private System.Windows.Forms.Label label_MatchAge;
        private System.Windows.Forms.Label label_MatchProfessionalField;
        private System.Windows.Forms.Label label_ProfessionalTitle;
        private System.Windows.Forms.Label label_Aboutme;
        private System.Windows.Forms.TextBox textBox_AboutMe;
        private System.Windows.Forms.Button buttonMatchMessage;
        private System.Windows.Forms.Label labelMatchFirstName;
        private System.Windows.Forms.Label labelMatchLastName;
        private System.Windows.Forms.Label labelMatchAge;
        private System.Windows.Forms.Label labelMatchProfessionalField;
        private System.Windows.Forms.Label labelProfessionalTitle;
        private System.Windows.Forms.Label labelAboutme;
        private System.Windows.Forms.TextBox textBoxAboutMe;
    }
}