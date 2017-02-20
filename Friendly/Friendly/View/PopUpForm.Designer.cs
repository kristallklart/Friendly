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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxMatchImage
            // 
            this.picBoxMatchImage.Location = new System.Drawing.Point(46, 82);
            this.picBoxMatchImage.Name = "picBoxMatchImage";
            this.picBoxMatchImage.Size = new System.Drawing.Size(100, 86);
            this.picBoxMatchImage.TabIndex = 0;
            this.picBoxMatchImage.TabStop = false;
            this.picBoxMatchImage.Click += new System.EventHandler(this.picBoxMatchImage_Click);
            // 
            // label_MatchFirstName
            // 
            this.label_MatchFirstName.Location = new System.Drawing.Point(152, 82);
            this.label_MatchFirstName.Name = "label_MatchFirstName";
            this.label_MatchFirstName.Size = new System.Drawing.Size(100, 20);
            this.label_MatchFirstName.TabIndex = 9;
            this.label_MatchFirstName.Text = "FirstName";
            // 
            // label_MatchLastName
            // 
            this.label_MatchLastName.Location = new System.Drawing.Point(247, 82);
            this.label_MatchLastName.Name = "label_MatchLastName";
            this.label_MatchLastName.Size = new System.Drawing.Size(100, 20);
            this.label_MatchLastName.TabIndex = 10;
            this.label_MatchLastName.Text = "LastName";
            this.label_MatchLastName.Click += new System.EventHandler(this.label_MatchLastName_Click);
            // 
            // label_MatchAge
            // 
            this.label_MatchAge.Location = new System.Drawing.Point(152, 107);
            this.label_MatchAge.Name = "label_MatchAge";
            this.label_MatchAge.Size = new System.Drawing.Size(100, 20);
            this.label_MatchAge.TabIndex = 11;
            this.label_MatchAge.Text = "Age";
            this.label_MatchAge.Click += new System.EventHandler(this.label_MatchAge_Click);
            // 
            // label_MatchProfessionalField
            // 
            this.label_MatchProfessionalField.Location = new System.Drawing.Point(152, 127);
            this.label_MatchProfessionalField.Name = "label_MatchProfessionalField";
            this.label_MatchProfessionalField.Size = new System.Drawing.Size(150, 20);
            this.label_MatchProfessionalField.TabIndex = 12;
            this.label_MatchProfessionalField.Text = "FieldOfProfession";
            // 
            // label_ProfessionalTitle
            // 
            this.label_ProfessionalTitle.Location = new System.Drawing.Point(152, 148);
            this.label_ProfessionalTitle.Name = "label_ProfessionalTitle";
            this.label_ProfessionalTitle.Size = new System.Drawing.Size(150, 20);
            this.label_ProfessionalTitle.TabIndex = 13;
            this.label_ProfessionalTitle.Text = "ProfessionalTitle";
            this.label_ProfessionalTitle.Click += new System.EventHandler(this.label_ProfessionalTitle_Click);
            // 
            // label_Aboutme
            // 
            this.label_Aboutme.AutoSize = true;
            this.label_Aboutme.Location = new System.Drawing.Point(43, 235);
            this.label_Aboutme.Name = "label_Aboutme";
            this.label_Aboutme.Size = new System.Drawing.Size(50, 13);
            this.label_Aboutme.TabIndex = 14;
            this.label_Aboutme.Text = "AboutMe";
            // 
            // textBox_AboutMe
            // 
            this.textBox_AboutMe.Location = new System.Drawing.Point(46, 251);
            this.textBox_AboutMe.Multiline = true;
            this.textBox_AboutMe.Name = "textBox_AboutMe";
            this.textBox_AboutMe.ReadOnly = true;
            this.textBox_AboutMe.Size = new System.Drawing.Size(380, 123);
            this.textBox_AboutMe.TabIndex = 15;
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 400);
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
    }
}