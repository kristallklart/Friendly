using System;
using Friendly;

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
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.panelIWant = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewMyCities = new System.Windows.Forms.DataGridView();
            this.cueComboBoxInterestedIn = new Friendly.Utilities.CueComboBox();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.labelPreferences = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.cueComboBoxCity = new Friendly.Utilities.CueComboBox();
            this.panelPersonalDetails = new System.Windows.Forms.Panel();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.cueTextBoxProfessionalTitle = new Friendly.Utilities.CueTextBox();
            this.picBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.buttonUpdateDetails = new System.Windows.Forms.Button();
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.textBoxAboutMe = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.cueComboBoxProfessionalField = new Friendly.Utilities.CueComboBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPersonalDetails = new System.Windows.Forms.Label();
            this.tabMyMatches = new System.Windows.Forms.TabPage();
            this.dataGridViewMyMatches = new System.Windows.Forms.DataGridView();
            this.dataGridViewMyMatchesCities = new System.Windows.Forms.DataGridView();
            this.tabMyMessages = new System.Windows.Forms.TabPage();
            this.cueTextBoxMessage = new Friendly.Utilities.CueTextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.dataGridViewMyMessagesTab = new System.Windows.Forms.DataGridView();
            this.labelMessages = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            this.panelIWant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCities)).BeginInit();
            this.panelPersonalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.tabMyMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatchesCities)).BeginInit();
            this.tabMyMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMessagesTab)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabMyProfile);
            this.tabControlMain.Controls.Add(this.tabMyMatches);
            this.tabControlMain.Controls.Add(this.tabMyMessages);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 21);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(814, 446);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.Controls.Add(this.panelIWant);
            this.tabMyProfile.Controls.Add(this.panelPersonalDetails);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 22);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyProfile.Size = new System.Drawing.Size(806, 420);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "My profile";
            this.tabMyProfile.UseVisualStyleBackColor = true;
            // 
            // panelIWant
            // 
            this.panelIWant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIWant.Controls.Add(this.buttonDelete);
            this.panelIWant.Controls.Add(this.dataGridViewMyCities);
            this.panelIWant.Controls.Add(this.cueComboBoxInterestedIn);
            this.panelIWant.Controls.Add(this.buttonAddLocation);
            this.panelIWant.Controls.Add(this.labelPreferences);
            this.panelIWant.Controls.Add(this.labelTo);
            this.panelIWant.Controls.Add(this.labelFrom);
            this.panelIWant.Controls.Add(this.dateTimePickerFrom);
            this.panelIWant.Controls.Add(this.dateTimePickerTo);
            this.panelIWant.Controls.Add(this.cueComboBoxCity);
            this.panelIWant.Location = new System.Drawing.Point(449, 15);
            this.panelIWant.Name = "panelIWant";
            this.panelIWant.Size = new System.Drawing.Size(341, 388);
            this.panelIWant.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(249, 352);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridViewMyCities
            // 
            this.dataGridViewMyCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyCities.Location = new System.Drawing.Point(23, 259);
            this.dataGridViewMyCities.Name = "dataGridViewMyCities";
            this.dataGridViewMyCities.Size = new System.Drawing.Size(220, 116);
            this.dataGridViewMyCities.TabIndex = 20;
            // 
            // cueComboBoxInterestedIn
            // 
            this.cueComboBoxInterestedIn.CueText = "Interested in";
            this.cueComboBoxInterestedIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxInterestedIn.FormattingEnabled = true;
            this.cueComboBoxInterestedIn.Location = new System.Drawing.Point(43, 67);
            this.cueComboBoxInterestedIn.Name = "cueComboBoxInterestedIn";
            this.cueComboBoxInterestedIn.Size = new System.Drawing.Size(136, 21);
            this.cueComboBoxInterestedIn.TabIndex = 19;
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Location = new System.Drawing.Point(104, 202);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLocation.TabIndex = 17;
            this.buttonAddLocation.Text = "Add";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.button_AddLocation_Click);
            // 
            // labelPreferences
            // 
            this.labelPreferences.AutoSize = true;
            this.labelPreferences.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreferences.Location = new System.Drawing.Point(43, 22);
            this.labelPreferences.Name = "labelPreferences";
            this.labelPreferences.Size = new System.Drawing.Size(121, 25);
            this.labelPreferences.TabIndex = 16;
            this.labelPreferences.Text = "Preferences ";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(43, 152);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(18, 13);
            this.labelTo.TabIndex = 15;
            this.labelTo.Text = "Til";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(43, 123);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 14;
            this.labelFrom.Text = "From";
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
            // cueComboBoxCity
            // 
            this.cueComboBoxCity.CueText = "City";
            this.cueComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxCity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxCity.FormattingEnabled = true;
            this.cueComboBoxCity.Items.AddRange(new object[] {
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
            this.cueComboBoxCity.Location = new System.Drawing.Point(46, 175);
            this.cueComboBoxCity.Name = "cueComboBoxCity";
            this.cueComboBoxCity.Size = new System.Drawing.Size(133, 21);
            this.cueComboBoxCity.TabIndex = 11;
            // 
            // panelPersonalDetails
            // 
            this.panelPersonalDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPersonalDetails.Controls.Add(this.buttonAddPicture);
            this.panelPersonalDetails.Controls.Add(this.labelAge);
            this.panelPersonalDetails.Controls.Add(this.cueTextBoxProfessionalTitle);
            this.panelPersonalDetails.Controls.Add(this.picBoxProfilePic);
            this.panelPersonalDetails.Controls.Add(this.buttonUpdateDetails);
            this.panelPersonalDetails.Controls.Add(this.labelAboutMe);
            this.panelPersonalDetails.Controls.Add(this.textBoxAboutMe);
            this.panelPersonalDetails.Controls.Add(this.textBoxLastName);
            this.panelPersonalDetails.Controls.Add(this.cueComboBoxProfessionalField);
            this.panelPersonalDetails.Controls.Add(this.textBoxFirstName);
            this.panelPersonalDetails.Controls.Add(this.labelPersonalDetails);
            this.panelPersonalDetails.Location = new System.Drawing.Point(15, 15);
            this.panelPersonalDetails.Name = "panelPersonalDetails";
            this.panelPersonalDetails.Size = new System.Drawing.Size(417, 388);
            this.panelPersonalDetails.TabIndex = 1;
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.Location = new System.Drawing.Point(19, 182);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(116, 23);
            this.buttonAddPicture.TabIndex = 24;
            this.buttonAddPicture.Text = "Add Picture";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(174, 95);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 13);
            this.labelAge.TabIndex = 23;
            this.labelAge.Text = "Age";
            // 
            // cueTextBoxProfessionalTitle
            // 
            this.cueTextBoxProfessionalTitle.Cue = "Professional title";
            this.cueTextBoxProfessionalTitle.Location = new System.Drawing.Point(177, 147);
            this.cueTextBoxProfessionalTitle.Name = "cueTextBoxProfessionalTitle";
            this.cueTextBoxProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.cueTextBoxProfessionalTitle.TabIndex = 22;
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePic.Image")));
            this.picBoxProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePic.InitialImage")));
            this.picBoxProfilePic.Location = new System.Drawing.Point(19, 65);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(116, 104);
            this.picBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            this.picBoxProfilePic.WaitOnLoad = true;
            // 
            // buttonUpdateDetails
            // 
            this.buttonUpdateDetails.Location = new System.Drawing.Point(324, 352);
            this.buttonUpdateDetails.Name = "buttonUpdateDetails";
            this.buttonUpdateDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDetails.TabIndex = 12;
            this.buttonUpdateDetails.Text = "Update";
            this.buttonUpdateDetails.UseVisualStyleBackColor = true;
            this.buttonUpdateDetails.Click += new System.EventHandler(this.button_UpdateDetails_Click);
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutMe.Location = new System.Drawing.Point(16, 208);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(69, 17);
            this.labelAboutMe.TabIndex = 11;
            this.labelAboutMe.Text = "About me";
            // 
            // textBoxAboutMe
            // 
            this.textBoxAboutMe.Location = new System.Drawing.Point(19, 236);
            this.textBoxAboutMe.MaxLength = 300;
            this.textBoxAboutMe.Multiline = true;
            this.textBoxAboutMe.Name = "textBoxAboutMe";
            this.textBoxAboutMe.Size = new System.Drawing.Size(380, 110);
            this.textBoxAboutMe.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(291, 65);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(108, 22);
            this.textBoxLastName.TabIndex = 9;
            this.textBoxLastName.Text = "Last name";
            // 
            // cueComboBoxProfessionalField
            // 
            this.cueComboBoxProfessionalField.CueText = "Field of profession";
            this.cueComboBoxProfessionalField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxProfessionalField.FormattingEnabled = true;
            this.cueComboBoxProfessionalField.Location = new System.Drawing.Point(177, 119);
            this.cueComboBoxProfessionalField.Name = "cueComboBoxProfessionalField";
            this.cueComboBoxProfessionalField.Size = new System.Drawing.Size(222, 21);
            this.cueComboBoxProfessionalField.TabIndex = 6;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(177, 65);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(108, 22);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Text = "First name";
            // 
            // labelPersonalDetails
            // 
            this.labelPersonalDetails.AutoSize = true;
            this.labelPersonalDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPersonalDetails.Location = new System.Drawing.Point(14, 22);
            this.labelPersonalDetails.Name = "labelPersonalDetails";
            this.labelPersonalDetails.Size = new System.Drawing.Size(150, 25);
            this.labelPersonalDetails.TabIndex = 1;
            this.labelPersonalDetails.Text = "Personal details";
            // 
            // tabMyMatches
            // 
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatches);
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatchesCities);
            this.tabMyMatches.Location = new System.Drawing.Point(4, 22);
            this.tabMyMatches.Name = "tabMyMatches";
            this.tabMyMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyMatches.Size = new System.Drawing.Size(806, 420);
            this.tabMyMatches.TabIndex = 1;
            this.tabMyMatches.Text = "My matches";
            this.tabMyMatches.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMyMatches
            // 
            this.dataGridViewMyMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatches.Location = new System.Drawing.Point(311, 44);
            this.dataGridViewMyMatches.Name = "dataGridViewMyMatches";
            this.dataGridViewMyMatches.Size = new System.Drawing.Size(468, 342);
            this.dataGridViewMyMatches.TabIndex = 1;
            this.dataGridViewMyMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MyMatches_CellClick);
            // 
            // dataGridViewMyMatchesCities
            // 
            this.dataGridViewMyMatchesCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatchesCities.Location = new System.Drawing.Point(31, 42);
            this.dataGridViewMyMatchesCities.Name = "dataGridViewMyMatchesCities";
            this.dataGridViewMyMatchesCities.Size = new System.Drawing.Size(240, 344);
            this.dataGridViewMyMatchesCities.TabIndex = 0;
            this.dataGridViewMyMatchesCities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MyMatchesCities_CellClick);
            // 
            // tabMyMessages
            // 
            this.tabMyMessages.Controls.Add(this.cueTextBoxMessage);
            this.tabMyMessages.Controls.Add(this.buttonSendMessage);
            this.tabMyMessages.Controls.Add(this.textBoxMessages);
            this.tabMyMessages.Controls.Add(this.dataGridViewMyMessagesTab);
            this.tabMyMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMyMessages.Name = "tabMyMessages";
            this.tabMyMessages.Size = new System.Drawing.Size(806, 420);
            this.tabMyMessages.TabIndex = 2;
            this.tabMyMessages.Text = "My messages";
            this.tabMyMessages.UseVisualStyleBackColor = true;
            // 
            // cueTextBoxMessage
            // 
            this.cueTextBoxMessage.Cue = "Write a message...";
            this.cueTextBoxMessage.Location = new System.Drawing.Point(141, 361);
            this.cueTextBoxMessage.Multiline = true;
            this.cueTextBoxMessage.Name = "cueTextBoxMessage";
            this.cueTextBoxMessage.Size = new System.Drawing.Size(581, 56);
            this.cueTextBoxMessage.TabIndex = 3;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(728, 394);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMessage.TabIndex = 2;
            this.buttonSendMessage.Text = "Send";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(141, 4);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(662, 351);
            this.textBoxMessages.TabIndex = 1;
            // 
            // dataGridViewMyMessagesTab
            // 
            this.dataGridViewMyMessagesTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMessagesTab.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewMyMessagesTab.Name = "dataGridViewMyMessagesTab";
            this.dataGridViewMyMessagesTab.Size = new System.Drawing.Size(131, 413);
            this.dataGridViewMyMessagesTab.TabIndex = 0;
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Location = new System.Drawing.Point(16, 470);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(63, 13);
            this.labelMessages.TabIndex = 1;
            this.labelMessages.Text = "Messages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(834, 493);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.panelIWant.ResumeLayout(false);
            this.panelIWant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCities)).EndInit();
            this.panelPersonalDetails.ResumeLayout(false);
            this.panelPersonalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            this.tabMyMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatchesCities)).EndInit();
            this.tabMyMessages.ResumeLayout(false);
            this.tabMyMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMessagesTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMyMatches;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.Panel panelPersonalDetails;
        private System.Windows.Forms.PictureBox picBoxProfilePic;
        private System.Windows.Forms.Label labelPersonalDetails;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private Utilities.CueComboBox cueComboBoxProfessionalField;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Panel panelIWant;
        private System.Windows.Forms.Label labelPreferences;
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.TextBox textBoxAboutMe;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Button buttonUpdateDetails;
        private Utilities.CueComboBox cueComboBoxInterestedIn;
        private System.Windows.Forms.DataGridView dataGridViewMyMatchesCities;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.DataGridView dataGridViewMyCities;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewMyMatches;
        private Utilities.CueTextBox cueTextBoxProfessionalTitle;
        private System.Windows.Forms.Label labelAge;
        private Utilities.CueComboBox cueComboBoxCity;
        private System.Windows.Forms.TabPage tabMyMessages;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.DataGridView dataGridViewMyMessagesTab;
        private Utilities.CueTextBox cueTextBoxMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Button buttonAddPicture;
    }
}

