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
            this.labelMustNames = new System.Windows.Forms.Label();
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
            this.labelMustInterestCity = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMyMatches = new System.Windows.Forms.DataGridView();
            this.dataGridViewMyMatchesCities = new System.Windows.Forms.DataGridView();
            this.tabMyMessages = new System.Windows.Forms.TabPage();
            this.cueTextBoxMessage = new Friendly.Utilities.CueTextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.dataGridViewMyMessagesTab = new System.Windows.Forms.DataGridView();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            this.groupBoxMyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.groupBoxPreferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCities)).BeginInit();
            this.tabMyMatches.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMatchesCities)).BeginInit();
            this.tabMyMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyMessagesTab)).BeginInit();
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
            this.groupBoxMyDetails.Controls.Add(this.labelMustNames);
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
            this.groupBoxMyDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxMyDetails.Location = new System.Drawing.Point(6, 3);
            this.groupBoxMyDetails.Name = "groupBoxMyDetails";
            this.groupBoxMyDetails.Size = new System.Drawing.Size(417, 447);
            this.groupBoxMyDetails.TabIndex = 3;
            this.groupBoxMyDetails.TabStop = false;
            this.groupBoxMyDetails.Text = "My details";
            // 
            // labelMustNames
            // 
            this.labelMustNames.AutoSize = true;
            this.labelMustNames.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMustNames.ForeColor = System.Drawing.Color.Red;
            this.labelMustNames.Location = new System.Drawing.Point(374, 45);
            this.labelMustNames.Name = "labelMustNames";
            this.labelMustNames.Size = new System.Drawing.Size(13, 17);
            this.labelMustNames.TabIndex = 25;
            this.labelMustNames.Text = "*";
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddPicture.Location = new System.Drawing.Point(6, 146);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(116, 23);
            this.buttonAddPicture.TabIndex = 5;
            this.buttonAddPicture.Text = "Add picture";
            this.buttonAddPicture.UseVisualStyleBackColor = true;
            this.buttonAddPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePic.Image")));
            this.picBoxProfilePic.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePic.InitialImage")));
            this.picBoxProfilePic.Location = new System.Drawing.Point(6, 40);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(116, 104);
            this.picBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            this.picBoxProfilePic.WaitOnLoad = true;
            // 
            // textBoxAboutMe
            // 
            this.textBoxAboutMe.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAboutMe.Location = new System.Drawing.Point(6, 230);
            this.textBoxAboutMe.MaxLength = 300;
            this.textBoxAboutMe.Multiline = true;
            this.textBoxAboutMe.Name = "textBoxAboutMe";
            this.textBoxAboutMe.Size = new System.Drawing.Size(405, 177);
            this.textBoxAboutMe.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelAge.Location = new System.Drawing.Point(143, 77);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 13);
            this.labelAge.TabIndex = 23;
            this.labelAge.Text = "Age";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconPadding(this.textBoxLastName, 4);
            this.textBoxLastName.Location = new System.Drawing.Point(260, 40);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(108, 22);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Text = "Last name";
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxLastName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutMe.Location = new System.Drawing.Point(6, 210);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(69, 17);
            this.labelAboutMe.TabIndex = 11;
            this.labelAboutMe.Text = "About me";
            // 
            // cueTextBoxProfessionalTitle
            // 
            this.cueTextBoxProfessionalTitle.Cue = "Professional title";
            this.cueTextBoxProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cueTextBoxProfessionalTitle.Location = new System.Drawing.Point(146, 122);
            this.cueTextBoxProfessionalTitle.Name = "cueTextBoxProfessionalTitle";
            this.cueTextBoxProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.cueTextBoxProfessionalTitle.TabIndex = 4;
            // 
            // cueComboBoxProfessionalField
            // 
            this.cueComboBoxProfessionalField.CueText = "Field of profession";
            this.cueComboBoxProfessionalField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxProfessionalField.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxProfessionalField.FormattingEnabled = true;
            this.cueComboBoxProfessionalField.Location = new System.Drawing.Point(146, 95);
            this.cueComboBoxProfessionalField.Name = "cueComboBoxProfessionalField";
            this.cueComboBoxProfessionalField.Size = new System.Drawing.Size(222, 21);
            this.cueComboBoxProfessionalField.TabIndex = 3;
            // 
            // buttonUpdateDetails
            // 
            this.buttonUpdateDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateDetails.Location = new System.Drawing.Point(313, 413);
            this.buttonUpdateDetails.Name = "buttonUpdateDetails";
            this.buttonUpdateDetails.Size = new System.Drawing.Size(98, 23);
            this.buttonUpdateDetails.TabIndex = 7;
            this.buttonUpdateDetails.Text = "Update details";
            this.buttonUpdateDetails.UseVisualStyleBackColor = true;
            this.buttonUpdateDetails.Click += new System.EventHandler(this.buttonUpdateDetails_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(146, 40);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(108, 22);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "First name";
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxFirstName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // groupBoxPreferences
            // 
            this.groupBoxPreferences.Controls.Add(this.labelMustInterestCity);
            this.groupBoxPreferences.Controls.Add(this.buttonDelete);
            this.groupBoxPreferences.Controls.Add(this.cueComboBoxInterestedIn);
            this.groupBoxPreferences.Controls.Add(this.labelFrom);
            this.groupBoxPreferences.Controls.Add(this.dataGridViewMyCities);
            this.groupBoxPreferences.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxPreferences.Controls.Add(this.labelTo);
            this.groupBoxPreferences.Controls.Add(this.dateTimePickerTo);
            this.groupBoxPreferences.Controls.Add(this.buttonAddLocation);
            this.groupBoxPreferences.Controls.Add(this.cueComboBoxCity);
            this.groupBoxPreferences.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxPreferences.Location = new System.Drawing.Point(442, 3);
            this.groupBoxPreferences.Name = "groupBoxPreferences";
            this.groupBoxPreferences.Size = new System.Drawing.Size(458, 447);
            this.groupBoxPreferences.TabIndex = 2;
            this.groupBoxPreferences.TabStop = false;
            this.groupBoxPreferences.Text = "Preferences";
            // 
            // labelMustInterestCity
            // 
            this.labelMustInterestCity.AutoSize = true;
            this.labelMustInterestCity.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelMustInterestCity.ForeColor = System.Drawing.Color.Red;
            this.labelMustInterestCity.Location = new System.Drawing.Point(439, 127);
            this.labelMustInterestCity.Name = "labelMustInterestCity";
            this.labelMustInterestCity.Size = new System.Drawing.Size(13, 17);
            this.labelMustInterestCity.TabIndex = 24;
            this.labelMustInterestCity.Text = "*";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(8, 413);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // cueComboBoxInterestedIn
            // 
            this.cueComboBoxInterestedIn.CueText = "Interested in";
            this.cueComboBoxInterestedIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxInterestedIn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.cueComboBoxInterestedIn.FormattingEnabled = true;
            this.cueComboBoxInterestedIn.Location = new System.Drawing.Point(163, 123);
            this.cueComboBoxInterestedIn.Name = "cueComboBoxInterestedIn";
            this.cueComboBoxInterestedIn.Size = new System.Drawing.Size(136, 21);
            this.cueComboBoxInterestedIn.TabIndex = 8;
            this.cueComboBoxInterestedIn.Validated += new System.EventHandler(this.control_Validated);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(160, 159);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 14;
            this.labelFrom.Text = "From";
            // 
            // dataGridViewMyCities
            // 
            this.dataGridViewMyCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyCities.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMyCities.Location = new System.Drawing.Point(8, 230);
            this.dataGridViewMyCities.Name = "dataGridViewMyCities";
            this.dataGridViewMyCities.ReadOnly = true;
            this.dataGridViewMyCities.Size = new System.Drawing.Size(444, 177);
            this.dataGridViewMyCities.TabIndex = 23;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(196, 152);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerFrom.TabIndex = 10;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(312, 159);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(18, 13);
            this.labelTo.TabIndex = 15;
            this.labelTo.Text = "Til";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(336, 152);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(99, 22);
            this.dateTimePickerTo.TabIndex = 11;
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddLocation.Location = new System.Drawing.Point(360, 180);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLocation.TabIndex = 12;
            this.buttonAddLocation.Text = "Add";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // cueComboBoxCity
            // 
            this.cueComboBoxCity.CueText = "City";
            this.cueComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cueComboBoxCity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cueComboBoxCity.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cueComboBoxCity, 4);
            this.cueComboBoxCity.Location = new System.Drawing.Point(302, 123);
            this.cueComboBoxCity.Name = "cueComboBoxCity";
            this.cueComboBoxCity.Size = new System.Drawing.Size(133, 21);
            this.cueComboBoxCity.TabIndex = 9;
            this.cueComboBoxCity.Validated += new System.EventHandler(this.control_Validated);
            // 
            // tabMyMatches
            // 
            this.tabMyMatches.Controls.Add(this.panel1);
            this.tabMyMatches.Controls.Add(this.dataGridViewMyMatchesCities);
            this.tabMyMatches.Location = new System.Drawing.Point(4, 22);
            this.tabMyMatches.Name = "tabMyMatches";
            this.tabMyMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyMatches.Size = new System.Drawing.Size(907, 460);
            this.tabMyMatches.TabIndex = 1;
            this.tabMyMatches.Text = "My matches";
            this.tabMyMatches.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMyMatches);
            this.panel1.Location = new System.Drawing.Point(249, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 380);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewMyMatches
            // 
            this.dataGridViewMyMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMyMatches.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMyMatches.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMyMatches.Name = "dataGridViewMyMatches";
            this.dataGridViewMyMatches.ReadOnly = true;
            this.dataGridViewMyMatches.Size = new System.Drawing.Size(539, 380);
            this.dataGridViewMyMatches.TabIndex = 1;
            this.dataGridViewMyMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyMatches_CellClick);
            // 
            // dataGridViewMyMatchesCities
            // 
            this.dataGridViewMyMatchesCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMatchesCities.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMyMatchesCities.Location = new System.Drawing.Point(78, 40);
            this.dataGridViewMyMatchesCities.Name = "dataGridViewMyMatchesCities";
            this.dataGridViewMyMatchesCities.ReadOnly = true;
            this.dataGridViewMyMatchesCities.Size = new System.Drawing.Size(136, 380);
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
            // cueTextBoxMessage
            // 
            this.cueTextBoxMessage.Cue = "Write a message...";
            this.cueTextBoxMessage.Location = new System.Drawing.Point(203, 374);
            this.cueTextBoxMessage.Multiline = true;
            this.cueTextBoxMessage.Name = "cueTextBoxMessage";
            this.cueTextBoxMessage.Size = new System.Drawing.Size(566, 56);
            this.cueTextBoxMessage.TabIndex = 3;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(775, 407);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMessage.TabIndex = 2;
            this.buttonSendMessage.Text = "Send";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(203, 17);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(647, 341);
            this.textBoxMessages.TabIndex = 1;
            // 
            // dataGridViewMyMessagesTab
            // 
            this.dataGridViewMyMessagesTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyMessagesTab.Location = new System.Drawing.Point(51, 17);
            this.dataGridViewMyMessagesTab.Name = "dataGridViewMyMessagesTab";
            this.dataGridViewMyMessagesTab.ReadOnly = true;
            this.dataGridViewMyMessagesTab.Size = new System.Drawing.Size(131, 413);
            this.dataGridViewMyMessagesTab.TabIndex = 0;
            this.dataGridViewMyMessagesTab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyMessagesTab_CellClick);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(12, 501);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(63, 13);
            this.labelFeedback.TabIndex = 1;
            this.labelFeedback.Text = "Messages";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Friendly";
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelFeedback;
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
        private System.Windows.Forms.Label labelMustNames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMustInterestCity;
    }
}

