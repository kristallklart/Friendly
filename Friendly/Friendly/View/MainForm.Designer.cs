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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.groupBoxMyDetails = new System.Windows.Forms.GroupBox();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.picBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.textBoxAboutMe = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.cueTextBoxProfessionalTitle = new Friendly.Utilities.CueTextBox();
            this.cueComboBoxProfessionalField = new Friendly.Utilities.CueComboBox();
            this.buttonUpdateDetails = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxPreferences = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.cueComboBoxInterestedIn = new Friendly.Utilities.CueComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dataGridViewMyCities = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.cueComboBoxCity = new Friendly.Utilities.CueComboBox();
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
            this.groupBoxMyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.groupBoxPreferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCities)).BeginInit();
            this.tabMyMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatchesCities)).BeginInit();
            this.tabMyMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMessagesTab)).BeginInit();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabMyProfile);
            this.tabControlMain.Controls.Add(this.tabMyMatches);
            this.tabControlMain.Controls.Add(this.tabMyMessages);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(915, 486);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.Controls.Add(this.groupBoxMyDetails);
            this.tabMyProfile.Controls.Add(this.groupBoxPreferences);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 22);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyProfile.Size = new System.Drawing.Size(907, 460);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "My profile";
            this.tabMyProfile.UseVisualStyleBackColor = true;
            // 
            // groupBoxMyDetails
            // 
            this.groupBoxMyDetails.Controls.Add(this.buttonAddPicture);
            this.groupBoxMyDetails.Controls.Add(this.picBoxProfilePic);
            this.groupBoxMyDetails.Controls.Add(this.textBoxAboutMe);
            this.groupBoxMyDetails.Controls.Add(this.labelAge);
            this.groupBoxMyDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxMyDetails.Controls.Add(this.labelAboutMe);
            this.groupBoxMyDetails.Controls.Add(this.cueTextBoxProfessionalTitle);
            this.groupBoxMyDetails.Controls.Add(this.cueComboBoxProfessionalField);
            this.groupBoxMyDetails.Controls.Add(this.buttonUpdateDetails);
            this.groupBoxMyDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxMyDetails.Location = new System.Drawing.Point(6, 15);
            this.groupBoxMyDetails.Name = "groupBoxMyDetails";
            this.groupBoxMyDetails.Size = new System.Drawing.Size(417, 435);
            this.groupBoxMyDetails.TabIndex = 3;
            this.groupBoxMyDetails.TabStop = false;
            this.groupBoxMyDetails.Text = "My details";
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.Location = new System.Drawing.Point(6, 137);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(116, 23);
            this.buttonAddPicture.TabIndex = 24;
            this.buttonAddPicture.Text = "Add Picture";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePic.Image")));
            this.picBoxProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePic.InitialImage")));
            this.picBoxProfilePic.Location = new System.Drawing.Point(6, 21);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(116, 104);
            this.picBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            this.picBoxProfilePic.WaitOnLoad = true;
            // 
            // textBoxAboutMe
            // 
            this.textBoxAboutMe.Location = new System.Drawing.Point(6, 184);
            this.textBoxAboutMe.MaxLength = 300;
            this.textBoxAboutMe.Multiline = true;
            this.textBoxAboutMe.Name = "textBoxAboutMe";
            this.textBoxAboutMe.Size = new System.Drawing.Size(376, 211);
            this.textBoxAboutMe.TabIndex = 10;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(153, 46);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 13);
            this.labelAge.TabIndex = 23;
            this.labelAge.Text = "Age";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(270, 21);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(108, 22);
            this.textBoxLastName.TabIndex = 9;
            this.textBoxLastName.Text = "Last name";
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxLastName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutMe.Location = new System.Drawing.Point(6, 164);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(69, 17);
            this.labelAboutMe.TabIndex = 11;
            this.labelAboutMe.Text = "About me";
            // 
            // cueTextBoxProfessionalTitle
            // 
            this.cueTextBoxProfessionalTitle.Cue = "Professional title";
            this.cueTextBoxProfessionalTitle.Location = new System.Drawing.Point(156, 92);
            this.cueTextBoxProfessionalTitle.Name = "cueTextBoxProfessionalTitle";
            this.cueTextBoxProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.cueTextBoxProfessionalTitle.TabIndex = 22;
            // 
            // cueComboBoxProfessionalField
            // 
            this.cueComboBoxProfessionalField.CueText = "Field of profession";
            this.cueComboBoxProfessionalField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxProfessionalField.FormattingEnabled = true;
            this.cueComboBoxProfessionalField.Location = new System.Drawing.Point(156, 64);
            this.cueComboBoxProfessionalField.Name = "cueComboBoxProfessionalField";
            this.cueComboBoxProfessionalField.Size = new System.Drawing.Size(222, 21);
            this.cueComboBoxProfessionalField.TabIndex = 6;
            // 
            // buttonUpdateDetails
            // 
            this.buttonUpdateDetails.Location = new System.Drawing.Point(307, 401);
            this.buttonUpdateDetails.Name = "buttonUpdateDetails";
            this.buttonUpdateDetails.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDetails.TabIndex = 12;
            this.buttonUpdateDetails.Text = "Update";
            this.buttonUpdateDetails.UseVisualStyleBackColor = true;
            this.buttonUpdateDetails.Click += new System.EventHandler(this.buttonUpdateDetails_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(156, 21);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(108, 22);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.Text = "First name";
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxFirstName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // groupBoxPreferences
            // 
            this.groupBoxPreferences.Controls.Add(this.buttonDelete);
            this.groupBoxPreferences.Controls.Add(this.cueComboBoxInterestedIn);
            this.groupBoxPreferences.Controls.Add(this.labelFrom);
            this.groupBoxPreferences.Controls.Add(this.dataGridViewMyCities);
            this.groupBoxPreferences.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxPreferences.Controls.Add(this.labelTo);
            this.groupBoxPreferences.Controls.Add(this.dateTimePickerTo);
            this.groupBoxPreferences.Controls.Add(this.buttonAddLocation);
            this.groupBoxPreferences.Controls.Add(this.cueComboBoxCity);
            this.groupBoxPreferences.Location = new System.Drawing.Point(442, 15);
            this.groupBoxPreferences.Name = "groupBoxPreferences";
            this.groupBoxPreferences.Size = new System.Drawing.Size(458, 435);
            this.groupBoxPreferences.TabIndex = 2;
            this.groupBoxPreferences.TabStop = false;
            this.groupBoxPreferences.Text = "Preferences";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(375, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // cueComboBoxInterestedIn
            // 
            this.cueComboBoxInterestedIn.CueText = "Interested in";
            this.cueComboBoxInterestedIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxInterestedIn.FormattingEnabled = true;
            this.cueComboBoxInterestedIn.Location = new System.Drawing.Point(9, 22);
            this.cueComboBoxInterestedIn.Name = "cueComboBoxInterestedIn";
            this.cueComboBoxInterestedIn.Size = new System.Drawing.Size(136, 21);
            this.cueComboBoxInterestedIn.TabIndex = 19;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(3, 65);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 14;
            this.labelFrom.Text = "From";
            // 
            // dataGridViewMyCities
            // 
            this.dataGridViewMyCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyCities.Location = new System.Drawing.Point(6, 184);
            this.dataGridViewMyCities.Name = "dataGridViewMyCities";
            this.dataGridViewMyCities.Size = new System.Drawing.Size(444, 211);
            this.dataGridViewMyCities.TabIndex = 20;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(42, 58);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerFrom.TabIndex = 12;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(158, 65);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(18, 13);
            this.labelTo.TabIndex = 15;
            this.labelTo.Text = "Til";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(182, 58);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(99, 22);
            this.dateTimePickerTo.TabIndex = 13;
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Location = new System.Drawing.Point(206, 86);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLocation.TabIndex = 17;
            this.buttonAddLocation.Text = "Add";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // tabMyMatches
            // 
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatches);
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatchesCities);
            this.tabMyMatches.Location = new System.Drawing.Point(4, 22);
            this.tabMyMatches.Name = "tabMyMatches";
            this.tabMyMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyMatches.Size = new System.Drawing.Size(907, 460);
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
            this.dataGridViewMyMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyMatches_CellClick);
            // 
            // dataGridViewMyMatchesCities
            // 
            this.dataGridViewMyMatchesCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatchesCities.Location = new System.Drawing.Point(31, 42);
            this.dataGridViewMyMatchesCities.Name = "dataGridViewMyMatchesCities";
            this.dataGridViewMyMatchesCities.Size = new System.Drawing.Size(240, 344);
            this.dataGridViewMyMatchesCities.TabIndex = 0;
            this.dataGridViewMyMatchesCities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyMatchesCities_CellClick);
            // 
            // tabMyMessages
            // 
            this.tabMyMessages.Controls.Add(this.cueTextBoxMessage);
            this.tabMyMessages.Controls.Add(this.buttonSendMessage);
            this.tabMyMessages.Controls.Add(this.textBoxMessages);
            this.tabMyMessages.Controls.Add(this.dataGridViewMyMessagesTab);
            this.tabMyMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMyMessages.Name = "tabMyMessages";
            this.tabMyMessages.Size = new System.Drawing.Size(907, 460);
            this.tabMyMessages.TabIndex = 2;
            this.tabMyMessages.Text = "My messages";
            this.tabMyMessages.UseVisualStyleBackColor = true;
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
            this.labelMessages.Location = new System.Drawing.Point(12, 501);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(63, 13);
            this.labelMessages.TabIndex = 1;
            this.labelMessages.Text = "Messages";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cueTextBoxProfessionalTitle
            // 
            this.cueTextBoxProfessionalTitle.Cue = "Professional title";
            this.cueTextBoxProfessionalTitle.Location = new System.Drawing.Point(156, 92);
            this.cueTextBoxProfessionalTitle.Name = "cueTextBoxProfessionalTitle";
            this.cueTextBoxProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.cueTextBoxProfessionalTitle.TabIndex = 22;
            // 
            // cueComboBoxProfessionalField
            // 
            this.cueComboBoxProfessionalField.CueText = "Field of profession";
            this.cueComboBoxProfessionalField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxProfessionalField.FormattingEnabled = true;
            this.cueComboBoxProfessionalField.Location = new System.Drawing.Point(156, 64);
            this.cueComboBoxProfessionalField.Name = "cueComboBoxProfessionalField";
            this.cueComboBoxProfessionalField.Size = new System.Drawing.Size(222, 21);
            this.cueComboBoxProfessionalField.TabIndex = 6;
            // 
            // cueComboBoxInterestedIn
            // 
            this.cueComboBoxInterestedIn.CueText = "Interested in";
            this.cueComboBoxInterestedIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxInterestedIn.FormattingEnabled = true;
            this.cueComboBoxInterestedIn.Location = new System.Drawing.Point(6, 22);
            this.cueComboBoxInterestedIn.Name = "cueComboBoxInterestedIn";
            this.cueComboBoxInterestedIn.Size = new System.Drawing.Size(136, 21);
            this.cueComboBoxInterestedIn.TabIndex = 19;
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
            this.cueComboBoxCity.Location = new System.Drawing.Point(148, 22);
            this.cueComboBoxCity.Name = "cueComboBoxCity";
            this.cueComboBoxCity.Size = new System.Drawing.Size(133, 21);
            this.cueComboBoxCity.TabIndex = 11;
            // 
            // tabMyMatches
            // 
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatches);
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatchesCities);
            this.tabMyMatches.Location = new System.Drawing.Point(4, 22);
            this.tabMyMatches.Name = "tabMyMatches";
            this.tabMyMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyMatches.Size = new System.Drawing.Size(866, 460);
            this.tabMyMatches.TabIndex = 1;
            this.tabMyMatches.Text = "My matches";
            this.tabMyMatches.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMyMatches
            // 
            this.dataGridViewMyMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatches.Location = new System.Drawing.Point(222, 44);
            this.dataGridViewMyMatches.Name = "dataGridViewMyMatches";
            this.dataGridViewMyMatches.Size = new System.Drawing.Size(557, 342);
            this.dataGridViewMyMatches.TabIndex = 1;
            this.dataGridViewMyMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyMatches_CellClick);
            // 
            // dataGridViewMyMatchesCities
            // 
            this.dataGridViewMyMatchesCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatchesCities.Location = new System.Drawing.Point(31, 42);
            this.dataGridViewMyMatchesCities.Name = "dataGridViewMyMatchesCities";
            this.dataGridViewMyMatchesCities.Size = new System.Drawing.Size(170, 344);
            this.dataGridViewMyMatchesCities.TabIndex = 0;
            this.dataGridViewMyMatchesCities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyMatchesCities_CellClick);
            // 
            // tabMyMessages
            // 
            this.tabMyMessages.Controls.Add(this.cueTextBoxMessage);
            this.tabMyMessages.Controls.Add(this.buttonSendMessage);
            this.tabMyMessages.Controls.Add(this.textBoxMessages);
            this.tabMyMessages.Controls.Add(this.dataGridViewMyMessagesTab);
            this.tabMyMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMyMessages.Name = "tabMyMessages";
            this.tabMyMessages.Size = new System.Drawing.Size(866, 460);
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
            this.labelMessages.Location = new System.Drawing.Point(12, 501);
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
            this.ClientSize = new System.Drawing.Size(939, 523);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.groupBoxMyDetails.ResumeLayout(false);
            this.groupBoxMyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            this.groupBoxPreferences.ResumeLayout(false);
            this.groupBoxPreferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCities)).EndInit();
            this.tabMyMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatchesCities)).EndInit();
            this.tabMyMessages.ResumeLayout(false);
            this.tabMyMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMessagesTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMyMatches;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.PictureBox picBoxProfilePic;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private Utilities.CueComboBox cueComboBoxProfessionalField;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
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
        private System.Windows.Forms.GroupBox groupBoxMyDetails;
        private System.Windows.Forms.GroupBox groupBoxPreferences;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

