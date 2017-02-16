namespace Friendly.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_MyProfile = new System.Windows.Forms.TabPage();
            this.panel_IWant = new System.Windows.Forms.Panel();
            this.comboBox_InterestedIn = new System.Windows.Forms.ComboBox();
            this.checkBox_Longterm = new System.Windows.Forms.CheckBox();
            this.button_AddLocation = new System.Windows.Forms.Button();
            this.label_Preferences = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.panel_PersonalDetails = new System.Windows.Forms.Panel();
            this.button_UpdateDetails = new System.Windows.Forms.Button();
            this.label_AboutMe = new System.Windows.Forms.Label();
            this.textBox_AboutMe = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_ProfessionalTitle = new System.Windows.Forms.TextBox();
            this.comboBox_ProfessionalField = new System.Windows.Forms.ComboBox();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_PersonalDetails = new System.Windows.Forms.Label();
            this.picBox_ProfilePic = new System.Windows.Forms.PictureBox();
            this.tab_MyMatches = new System.Windows.Forms.TabPage();
            this.dataGridView_MyMatches = new System.Windows.Forms.DataGridView();
            this.label_Messages = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_MyProfile.SuspendLayout();
            this.panel_IWant.SuspendLayout();
            this.panel_PersonalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfilePic)).BeginInit();
            this.tab_MyMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_MyProfile);
            this.tabControl1.Controls.Add(this.tab_MyMatches);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_MyProfile
            // 
            this.tab_MyProfile.Controls.Add(this.panel_IWant);
            this.tab_MyProfile.Controls.Add(this.panel_PersonalDetails);
            this.tab_MyProfile.Location = new System.Drawing.Point(4, 22);
            this.tab_MyProfile.Name = "tab_MyProfile";
            this.tab_MyProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MyProfile.Size = new System.Drawing.Size(806, 420);
            this.tab_MyProfile.TabIndex = 0;
            this.tab_MyProfile.Text = "My profile";
            this.tab_MyProfile.UseVisualStyleBackColor = true;
            // 
            // panel_IWant
            // 
            this.panel_IWant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_IWant.Controls.Add(this.comboBox_InterestedIn);
            this.panel_IWant.Controls.Add(this.checkBox_Longterm);
            this.panel_IWant.Controls.Add(this.button_AddLocation);
            this.panel_IWant.Controls.Add(this.label_Preferences);
            this.panel_IWant.Controls.Add(this.label_To);
            this.panel_IWant.Controls.Add(this.label_From);
            this.panel_IWant.Controls.Add(this.dateTimePicker1);
            this.panel_IWant.Controls.Add(this.dateTimePicker2);
            this.panel_IWant.Controls.Add(this.comboBox_City);
            this.panel_IWant.Location = new System.Drawing.Point(449, 15);
            this.panel_IWant.Name = "panel_IWant";
            this.panel_IWant.Size = new System.Drawing.Size(341, 388);
            this.panel_IWant.TabIndex = 2;
            // 
            // comboBox_InterestedIn
            // 
            this.comboBox_InterestedIn.FormattingEnabled = true;
            this.comboBox_InterestedIn.Location = new System.Drawing.Point(43, 67);
            this.comboBox_InterestedIn.Name = "comboBox_InterestedIn";
            this.comboBox_InterestedIn.Size = new System.Drawing.Size(136, 21);
            this.comboBox_InterestedIn.TabIndex = 19;
            this.comboBox_InterestedIn.Text = "Interested in";
            // 
            // checkBox_Longterm
            // 
            this.checkBox_Longterm.AutoSize = true;
            this.checkBox_Longterm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Longterm.Location = new System.Drawing.Point(97, 91);
            this.checkBox_Longterm.Name = "checkBox_Longterm";
            this.checkBox_Longterm.Size = new System.Drawing.Size(82, 17);
            this.checkBox_Longterm.TabIndex = 18;
            this.checkBox_Longterm.Text = "Longterm?";
            this.checkBox_Longterm.UseVisualStyleBackColor = true;
            // 
            // button_AddLocation
            // 
            this.button_AddLocation.Location = new System.Drawing.Point(104, 202);
            this.button_AddLocation.Name = "button_AddLocation";
            this.button_AddLocation.Size = new System.Drawing.Size(75, 23);
            this.button_AddLocation.TabIndex = 17;
            this.button_AddLocation.Text = "Add";
            this.button_AddLocation.UseVisualStyleBackColor = true;
            // 
            // label_Preferences
            // 
            this.label_Preferences.AutoSize = true;
            this.label_Preferences.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Preferences.Location = new System.Drawing.Point(43, 22);
            this.label_Preferences.Name = "label_Preferences";
            this.label_Preferences.Size = new System.Drawing.Size(121, 25);
            this.label_Preferences.TabIndex = 16;
            this.label_Preferences.Text = "Preferences ";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_To.Location = new System.Drawing.Point(43, 152);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(18, 13);
            this.label_To.TabIndex = 15;
            this.label_To.Text = "Til";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_From.Location = new System.Drawing.Point(43, 123);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(33, 13);
            this.label_From.TabIndex = 14;
            this.label_From.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(80, 147);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // comboBox_City
            // 
            this.comboBox_City.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Items.AddRange(new object[] {
            "STOCKHOLM",
            "GÖTEBORG",
            "MALMÖ",
            "",
            "Alingsås",
            "Arboga\t",
            "Arvika",
            "Askersund",
            "Avesta\t",
            "Boden",
            "Bollnäs",
            "Borgholm",
            "Borlänge",
            "Borås",
            "Djursholm",
            "Eksjö",
            "Enköping",
            "Eskilstuna",
            "Eslöv",
            "Fagersta",
            "Falkenberg",
            "Falköping",
            "Falsterbo",
            "Falun",
            "Filipstad",
            "Flen",
            "Gränna",
            "Gävle",
            "Hagfors",
            "Halmstad",
            "Haparanda",
            "Hedemora",
            "Helsingborg",
            "Hjo",
            "Hudiksvall",
            "Huskvarna",
            "Härnösand",
            "Hässleholm",
            "Höganäs",
            "Jönköping",
            "Kalmar",
            "Karlshamn",
            "Karlskoga",
            "Karlskrona",
            "Karlstad",
            "Katrineholm",
            "Kiruna",
            "Kramfors",
            "Kristianstad",
            "Kristinehamn",
            "Kumla",
            "Kungsbacka",
            "Kungälv",
            "Köping",
            "Laholm",
            "Landskrona",
            "Lidingö",
            "Lidköping",
            "Lindesberg",
            "Linköping",
            "Ljungby",
            "Ludvika",
            "Luleå",
            "Lund",
            "Lycksele",
            "Lysekil",
            "Mariefred",
            "Mariestad",
            "Marstrand",
            "Mjölby",
            "Motala",
            "Nacka",
            "Nora",
            "Norrköping",
            "Norrtälje",
            "Nybro",
            "Nyköping",
            "Nynäshamn",
            "Nässjö",
            "Oskarshamn",
            "Oxelösund",
            "Piteå",
            "Ronneby",
            "Sala",
            "Sandviken",
            "Sigtuna",
            "Simrishamn",
            "Skanör",
            "Skara",
            "Skellefteå",
            "Skänninge",
            "Skövde",
            "Sollefteå",
            "Solna",
            "Strängnäs",
            "Strömstad",
            "Sundbyberg",
            "Sundsvall",
            "Säffle",
            "Säter",
            "Sävsjö",
            "Söderhamn",
            "Söderköping",
            "Södertälje",
            "Sölvesborg",
            "Tidaholm",
            "Torshälla",
            "Tranås",
            "Trelleborg",
            "Trollhättan",
            "Trosa",
            "Uddevalla",
            "Ulricehamn",
            "Umeå",
            "Uppsala",
            "Vadstena",
            "Varberg",
            "Vaxholm",
            "Vetlanda",
            "Vimmerby",
            "Visby",
            "Vänersborg",
            "Värnamo",
            "Västervik",
            "Västerås",
            "Växjö",
            "Ystad",
            "Ängelholm",
            "Åmål",
            "Örebro",
            "Öregrund",
            "Örnsköldsvik",
            "Östersund",
            "Östhammar"});
            this.comboBox_City.Location = new System.Drawing.Point(39, 175);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(140, 21);
            this.comboBox_City.TabIndex = 11;
            this.comboBox_City.Text = "City";
            // 
            // panel_PersonalDetails
            // 
            this.panel_PersonalDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PersonalDetails.Controls.Add(this.button_UpdateDetails);
            this.panel_PersonalDetails.Controls.Add(this.label_AboutMe);
            this.panel_PersonalDetails.Controls.Add(this.textBox_AboutMe);
            this.panel_PersonalDetails.Controls.Add(this.textBox_LastName);
            this.panel_PersonalDetails.Controls.Add(this.textBox_ProfessionalTitle);
            this.panel_PersonalDetails.Controls.Add(this.comboBox_ProfessionalField);
            this.panel_PersonalDetails.Controls.Add(this.comboBox_Day);
            this.panel_PersonalDetails.Controls.Add(this.comboBox_Month);
            this.panel_PersonalDetails.Controls.Add(this.comboBox_Year);
            this.panel_PersonalDetails.Controls.Add(this.textBox_FirstName);
            this.panel_PersonalDetails.Controls.Add(this.label_PersonalDetails);
            this.panel_PersonalDetails.Controls.Add(this.picBox_ProfilePic);
            this.panel_PersonalDetails.Location = new System.Drawing.Point(15, 15);
            this.panel_PersonalDetails.Name = "panel_PersonalDetails";
            this.panel_PersonalDetails.Size = new System.Drawing.Size(417, 388);
            this.panel_PersonalDetails.TabIndex = 1;
            // 
            // button_UpdateDetails
            // 
            this.button_UpdateDetails.Location = new System.Drawing.Point(324, 352);
            this.button_UpdateDetails.Name = "button_UpdateDetails";
            this.button_UpdateDetails.Size = new System.Drawing.Size(75, 23);
            this.button_UpdateDetails.TabIndex = 12;
            this.button_UpdateDetails.Text = "Update";
            this.button_UpdateDetails.UseVisualStyleBackColor = true;
            this.button_UpdateDetails.Click += new System.EventHandler(this.button_UpdateDetails_Click);
            // 
            // label_AboutMe
            // 
            this.label_AboutMe.AutoSize = true;
            this.label_AboutMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AboutMe.Location = new System.Drawing.Point(16, 190);
            this.label_AboutMe.Name = "label_AboutMe";
            this.label_AboutMe.Size = new System.Drawing.Size(69, 17);
            this.label_AboutMe.TabIndex = 11;
            this.label_AboutMe.Text = "About me";
            // 
            // textBox_AboutMe
            // 
            this.textBox_AboutMe.Location = new System.Drawing.Point(19, 209);
            this.textBox_AboutMe.MaxLength = 300;
            this.textBox_AboutMe.Multiline = true;
            this.textBox_AboutMe.Name = "textBox_AboutMe";
            this.textBox_AboutMe.Size = new System.Drawing.Size(380, 123);
            this.textBox_AboutMe.TabIndex = 10;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LastName.Location = new System.Drawing.Point(291, 66);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(108, 22);
            this.textBox_LastName.TabIndex = 9;
            this.textBox_LastName.Text = "Last name";
            // 
            // textBox_ProfessionalTitle
            // 
            this.textBox_ProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProfessionalTitle.Location = new System.Drawing.Point(177, 147);
            this.textBox_ProfessionalTitle.Name = "textBox_ProfessionalTitle";
            this.textBox_ProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.textBox_ProfessionalTitle.TabIndex = 8;
            this.textBox_ProfessionalTitle.Text = "Professional title";
            // 
            // comboBox_ProfessionalField
            // 
            this.comboBox_ProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ProfessionalField.FormattingEnabled = true;
            this.comboBox_ProfessionalField.Items.AddRange(new object[] {
            "Administration, economics, law",
            "Agriculture",
            "Beauty care",
            "Building and construction",
            "Computer / IT",
            "Craft professions",
            "Culture, media, design",
            "Educational work",
            "Healthcare",
            "Hotel and restaurant",
            "Industrial manufacturing",
            "Installation, operation, maintenance",
            "Managers and executive directors",
            "Military",
            "Sales, purchases and marketing",
            "Sanitation and cleaning",
            "Scientific work",
            "Security",
            "Social work",
            "Technical work",
            "Transport"});
            this.comboBox_ProfessionalField.Location = new System.Drawing.Point(177, 119);
            this.comboBox_ProfessionalField.Name = "comboBox_ProfessionalField";
            this.comboBox_ProfessionalField.Size = new System.Drawing.Size(222, 21);
            this.comboBox_ProfessionalField.TabIndex = 6;
            this.comboBox_ProfessionalField.Text = "Field of profession";
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Day.FormattingEnabled = true;
            this.comboBox_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_Day.Location = new System.Drawing.Point(349, 92);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(50, 21);
            this.comboBox_Day.TabIndex = 5;
            this.comboBox_Day.Text = "Day";
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Month.FormattingEnabled = true;
            this.comboBox_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "Mars",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox_Month.Location = new System.Drawing.Point(281, 92);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(62, 21);
            this.comboBox_Month.TabIndex = 4;
            this.comboBox_Month.Text = "Month";
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(177, 92);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(97, 21);
            this.comboBox_Year.TabIndex = 3;
            this.comboBox_Year.Text = "Year of birth";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.Location = new System.Drawing.Point(177, 65);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(108, 22);
            this.textBox_FirstName.TabIndex = 2;
            this.textBox_FirstName.Text = "First name";
            // 
            // label_PersonalDetails
            // 
            this.label_PersonalDetails.AutoSize = true;
            this.label_PersonalDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_PersonalDetails.Location = new System.Drawing.Point(14, 22);
            this.label_PersonalDetails.Name = "label_PersonalDetails";
            this.label_PersonalDetails.Size = new System.Drawing.Size(150, 25);
            this.label_PersonalDetails.TabIndex = 1;
            this.label_PersonalDetails.Text = "Personal details";
            // 
            // picBox_ProfilePic
            // 
            this.picBox_ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("picBox_ProfilePic.Image")));
            this.picBox_ProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox_ProfilePic.InitialImage")));
            this.picBox_ProfilePic.Location = new System.Drawing.Point(19, 65);
            this.picBox_ProfilePic.Name = "picBox_ProfilePic";
            this.picBox_ProfilePic.Size = new System.Drawing.Size(116, 104);
            this.picBox_ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_ProfilePic.TabIndex = 0;
            this.picBox_ProfilePic.TabStop = false;
            this.picBox_ProfilePic.WaitOnLoad = true;
            // 
            // tab_MyMatches
            // 
            this.tab_MyMatches.Controls.Add(this.dataGridView_MyMatches);
            this.tab_MyMatches.Location = new System.Drawing.Point(4, 22);
            this.tab_MyMatches.Name = "tab_MyMatches";
            this.tab_MyMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MyMatches.Size = new System.Drawing.Size(806, 420);
            this.tab_MyMatches.TabIndex = 1;
            this.tab_MyMatches.Text = "My matches";
            this.tab_MyMatches.UseVisualStyleBackColor = true;
            // 
            // dataGridView_MyMatches
            // 
            this.dataGridView_MyMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MyMatches.Location = new System.Drawing.Point(31, 42);
            this.dataGridView_MyMatches.Name = "dataGridView_MyMatches";
            this.dataGridView_MyMatches.Size = new System.Drawing.Size(240, 344);
            this.dataGridView_MyMatches.TabIndex = 0;
            // 
            // label_Messages
            // 
            this.label_Messages.AutoSize = true;
            this.label_Messages.Location = new System.Drawing.Point(16, 470);
            this.label_Messages.Name = "label_Messages";
            this.label_Messages.Size = new System.Drawing.Size(0, 13);
            this.label_Messages.TabIndex = 1;
            this.label_Messages.Text = "Messages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.label_Messages);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tab_MyProfile.ResumeLayout(false);
            this.panel_IWant.ResumeLayout(false);
            this.panel_IWant.PerformLayout();
            this.panel_PersonalDetails.ResumeLayout(false);
            this.panel_PersonalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfilePic)).EndInit();
            this.tab_MyMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_MyMatches;
        private System.Windows.Forms.TabPage tab_MyProfile;
        private System.Windows.Forms.Panel panel_PersonalDetails;
        private System.Windows.Forms.PictureBox picBox_ProfilePic;
        private System.Windows.Forms.Label label_PersonalDetails;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.ComboBox comboBox_ProfessionalField;
        private System.Windows.Forms.TextBox textBox_ProfessionalTitle;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Panel panel_IWant;
        private System.Windows.Forms.Label label_Preferences;
        private System.Windows.Forms.Label label_AboutMe;
        private System.Windows.Forms.TextBox textBox_AboutMe;
        private System.Windows.Forms.Button button_AddLocation;
        private System.Windows.Forms.Button button_UpdateDetails;
        private System.Windows.Forms.ComboBox comboBox_InterestedIn;
        private System.Windows.Forms.CheckBox checkBox_Longterm;
        private System.Windows.Forms.DataGridView dataGridView_MyMatches;
        private System.Windows.Forms.Label label_Messages;
    }
}

