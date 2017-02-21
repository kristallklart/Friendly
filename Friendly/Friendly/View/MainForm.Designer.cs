using System;
using Friendly.Utilities;

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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tab_MyProfile = new System.Windows.Forms.TabPage();
            this.panel_IWant = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cueComboBox_InterestedIn = new Friendly.Utilities.CueComboBox();
            this.checkBox_Longterm = new System.Windows.Forms.CheckBox();
            this.button_AddLocation = new System.Windows.Forms.Button();
            this.label_Preferences = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.cueComboBox_City = new Friendly.Utilities.CueComboBox();
            this.panel_PersonalDetails = new System.Windows.Forms.Panel();
            this.label_Age = new System.Windows.Forms.Label();
            this.cueTextBox_ProfessionalTitle = new Friendly.Utilities.CueTextBox();
            this.picBox_ProfilePic = new System.Windows.Forms.PictureBox();
            this.button_UpdateDetails = new System.Windows.Forms.Button();
            this.label_AboutMe = new System.Windows.Forms.Label();
            this.textBox_AboutMe = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.cueComboBox_ProfessionalField = new Friendly.Utilities.CueComboBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_PersonalDetails = new System.Windows.Forms.Label();
            this.tab_MyMatches = new System.Windows.Forms.TabPage();
            this.dataGridView_MyMatches = new System.Windows.Forms.DataGridView();
            this.dataGridView_MyMatchesCities = new System.Windows.Forms.DataGridView();
            this.label_Messages = new System.Windows.Forms.Label();
            this.tab_MyMessages = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tab_MyProfile.SuspendLayout();
            this.panel_IWant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_PersonalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfilePic)).BeginInit();
            this.tab_MyMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyMatchesCities)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tab_MyProfile);
            this.tabControlMain.Controls.Add(this.tab_MyMatches);
            this.tabControlMain.Controls.Add(this.tab_MyMessages);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 21);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(814, 446);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
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
            this.panel_IWant.Controls.Add(this.button_Delete);
            this.panel_IWant.Controls.Add(this.dataGridView1);
            this.panel_IWant.Controls.Add(this.cueComboBox_InterestedIn);
            this.panel_IWant.Controls.Add(this.checkBox_Longterm);
            this.panel_IWant.Controls.Add(this.button_AddLocation);
            this.panel_IWant.Controls.Add(this.label_Preferences);
            this.panel_IWant.Controls.Add(this.label_To);
            this.panel_IWant.Controls.Add(this.label_From);
            this.panel_IWant.Controls.Add(this.dateTimePickerFrom);
            this.panel_IWant.Controls.Add(this.dateTimePickerTo);
            this.panel_IWant.Controls.Add(this.cueComboBox_City);
            this.panel_IWant.Location = new System.Drawing.Point(449, 15);
            this.panel_IWant.Name = "panel_IWant";
            this.panel_IWant.Size = new System.Drawing.Size(341, 388);
            this.panel_IWant.TabIndex = 2;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(249, 352);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 21;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(220, 116);
            this.dataGridView1.TabIndex = 20;
            // 
            // cueComboBox_InterestedIn
            // 
            this.cueComboBox_InterestedIn.CueText = "Interested in";
            this.cueComboBox_InterestedIn.FormattingEnabled = true;
            this.cueComboBox_InterestedIn.Location = new System.Drawing.Point(43, 67);
            this.cueComboBox_InterestedIn.Name = "cueComboBox_InterestedIn";
            this.cueComboBox_InterestedIn.Size = new System.Drawing.Size(136, 21);
            this.cueComboBox_InterestedIn.TabIndex = 19;
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
            this.checkBox_Longterm.CheckedChanged += new System.EventHandler(this.checkBox_Longterm_CheckedChanged);
            // 
            // button_AddLocation
            // 
            this.button_AddLocation.Location = new System.Drawing.Point(104, 202);
            this.button_AddLocation.Name = "button_AddLocation";
            this.button_AddLocation.Size = new System.Drawing.Size(75, 23);
            this.button_AddLocation.TabIndex = 17;
            this.button_AddLocation.Text = "Add";
            this.button_AddLocation.UseVisualStyleBackColor = true;
            this.button_AddLocation.Click += new System.EventHandler(this.button_AddLocation_Click);
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
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(80, 114);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(99, 22);
            this.dateTimePickerFrom.TabIndex = 12;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(80, 147);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(99, 22);
            this.dateTimePickerTo.TabIndex = 13;
            // 
            // cueComboBox_City
            // 
            this.cueComboBox_City.CueText = "City";
            this.cueComboBox_City.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBox_City.FormattingEnabled = true;
            this.cueComboBox_City.Items.AddRange(new object[] {
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
            this.cueComboBox_City.Location = new System.Drawing.Point(46, 175);
            this.cueComboBox_City.Name = "cueComboBox_City";
            this.cueComboBox_City.Size = new System.Drawing.Size(133, 21);
            this.cueComboBox_City.TabIndex = 11;
            // 
            // panel_PersonalDetails
            // 
            this.panel_PersonalDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PersonalDetails.Controls.Add(this.label_Age);
            this.panel_PersonalDetails.Controls.Add(this.cueTextBox_ProfessionalTitle);
            this.panel_PersonalDetails.Controls.Add(this.picBox_ProfilePic);
            this.panel_PersonalDetails.Controls.Add(this.button_UpdateDetails);
            this.panel_PersonalDetails.Controls.Add(this.label_AboutMe);
            this.panel_PersonalDetails.Controls.Add(this.textBox_AboutMe);
            this.panel_PersonalDetails.Controls.Add(this.textBox_LastName);
            this.panel_PersonalDetails.Controls.Add(this.cueComboBox_ProfessionalField);
            this.panel_PersonalDetails.Controls.Add(this.textBox_FirstName);
            this.panel_PersonalDetails.Controls.Add(this.label_PersonalDetails);
            this.panel_PersonalDetails.Location = new System.Drawing.Point(15, 15);
            this.panel_PersonalDetails.Name = "panel_PersonalDetails";
            this.panel_PersonalDetails.Size = new System.Drawing.Size(417, 388);
            this.panel_PersonalDetails.TabIndex = 1;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(174, 95);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(28, 13);
            this.label_Age.TabIndex = 23;
            this.label_Age.Text = "Age";
            // 
            // cueTextBox_ProfessionalTitle
            // 
            this.cueTextBox_ProfessionalTitle.Cue = "Professional title";
            this.cueTextBox_ProfessionalTitle.Location = new System.Drawing.Point(177, 147);
            this.cueTextBox_ProfessionalTitle.Name = "cueTextBox_ProfessionalTitle";
            this.cueTextBox_ProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.cueTextBox_ProfessionalTitle.TabIndex = 22;
            // 
            // picBox_ProfilePic
            // 
            this.picBox_ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("picBox_ProfilePic.Image")));
            this.picBox_ProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox_ProfilePic.InitialImage")));
            this.picBox_ProfilePic.Location = new System.Drawing.Point(19, 65);
            this.picBox_ProfilePic.Name = "picBox_ProfilePic";
            this.picBox_ProfilePic.Size = new System.Drawing.Size(116, 104);
            this.picBox_ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_ProfilePic.TabIndex = 0;
            this.picBox_ProfilePic.TabStop = false;
            this.picBox_ProfilePic.WaitOnLoad = true;
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
            this.textBox_LastName.Location = new System.Drawing.Point(291, 65);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(108, 22);
            this.textBox_LastName.TabIndex = 9;
            this.textBox_LastName.Text = "Last name";
            // 
            // cueComboBox_ProfessionalField
            // 
            this.cueComboBox_ProfessionalField.CueText = "Field of profession";
            this.cueComboBox_ProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBox_ProfessionalField.FormattingEnabled = true;
            this.cueComboBox_ProfessionalField.Location = new System.Drawing.Point(177, 119);
            this.cueComboBox_ProfessionalField.Name = "cueComboBox_ProfessionalField";
            this.cueComboBox_ProfessionalField.Size = new System.Drawing.Size(222, 21);
            this.cueComboBox_ProfessionalField.TabIndex = 6;
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
            // tab_MyMatches
            // 
            this.tab_MyMatches.Controls.Add(this.dataGridView_MyMatches);
            this.tab_MyMatches.Controls.Add(this.dataGridView_MyMatchesCities);
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
            this.dataGridView_MyMatches.Location = new System.Drawing.Point(311, 44);
            this.dataGridView_MyMatches.Name = "dataGridView_MyMatches";
            this.dataGridView_MyMatches.Size = new System.Drawing.Size(468, 342);
            this.dataGridView_MyMatches.TabIndex = 1;
            this.dataGridView_MyMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MyMatches_CellClick);
            // 
            // dataGridView_MyMatchesCities
            // 
            this.dataGridView_MyMatchesCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MyMatchesCities.Location = new System.Drawing.Point(31, 42);
            this.dataGridView_MyMatchesCities.Name = "dataGridView_MyMatchesCities";
            this.dataGridView_MyMatchesCities.Size = new System.Drawing.Size(240, 344);
            this.dataGridView_MyMatchesCities.TabIndex = 0;
            this.dataGridView_MyMatchesCities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MyMatchesCities_CellClick);
            // 
            // label_Messages
            // 
            this.label_Messages.AutoSize = true;
            this.label_Messages.Location = new System.Drawing.Point(16, 470);
            this.label_Messages.Name = "label_Messages";
            this.label_Messages.Size = new System.Drawing.Size(63, 13);
            this.label_Messages.TabIndex = 1;
            this.label_Messages.Text = "Messages";
            // 
            // tab_MyMessages
            // 
            this.tab_MyMessages.Location = new System.Drawing.Point(4, 22);
            this.tab_MyMessages.Name = "tab_MyMessages";
            this.tab_MyMessages.Size = new System.Drawing.Size(806, 420);
            this.tab_MyMessages.TabIndex = 2;
            this.tab_MyMessages.Text = "My messages";
            this.tab_MyMessages.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.label_Messages);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tab_MyProfile.ResumeLayout(false);
            this.panel_IWant.ResumeLayout(false);
            this.panel_IWant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_PersonalDetails.ResumeLayout(false);
            this.panel_PersonalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfilePic)).EndInit();
            this.tab_MyMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyMatchesCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tab_MyMatches;
        private System.Windows.Forms.TabPage tab_MyProfile;
        private System.Windows.Forms.Panel panel_PersonalDetails;
        private System.Windows.Forms.PictureBox picBox_ProfilePic;
        private System.Windows.Forms.Label label_PersonalDetails;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private Utilities.CueComboBox cueComboBox_ProfessionalField;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Panel panel_IWant;
        private System.Windows.Forms.Label label_Preferences;
        private System.Windows.Forms.Label label_AboutMe;
        private System.Windows.Forms.TextBox textBox_AboutMe;
        private System.Windows.Forms.Button button_AddLocation;
        private System.Windows.Forms.Button button_UpdateDetails;
        private Utilities.CueComboBox cueComboBox_InterestedIn;
        private System.Windows.Forms.CheckBox checkBox_Longterm;
        private System.Windows.Forms.DataGridView dataGridView_MyMatchesCities;
        private System.Windows.Forms.Label label_Messages;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView_MyMatches;
        private Utilities.CueTextBox cueTextBox_ProfessionalTitle;
        private System.Windows.Forms.Label label_Age;
        private Utilities.CueComboBox cueComboBox_City;
        private System.Windows.Forms.TabPage tab_MyMessages;
    }
}

