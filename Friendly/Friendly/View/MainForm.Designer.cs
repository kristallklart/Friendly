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
            this.tabMyProfile = new System.Windows.Forms.TabPage();
            this.panel_Location = new System.Windows.Forms.Panel();
            this.label_Location = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.comboBox_Hometown = new System.Windows.Forms.ComboBox();
            this.label_From = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_TempLoc = new System.Windows.Forms.ComboBox();
            this.pnl_PersDet = new System.Windows.Forms.Panel();
            this.label_InShort = new System.Windows.Forms.Label();
            this.checkBox_Kids = new System.Windows.Forms.CheckBox();
            this.checkBox_Freedom = new System.Windows.Forms.CheckBox();
            this.checkBox_Money = new System.Windows.Forms.CheckBox();
            this.checkBox_Time = new System.Windows.Forms.CheckBox();
            this.checkBox_Countryside = new System.Windows.Forms.CheckBox();
            this.checkBox_City = new System.Windows.Forms.CheckBox();
            this.label_AboutMe = new System.Windows.Forms.Label();
            this.txtBox_AboutMe = new System.Windows.Forms.TextBox();
            this.txtBox_LastName = new System.Windows.Forms.TextBox();
            this.txtBox_ProfessionalTitle = new System.Windows.Forms.TextBox();
            this.comboBox_ProfessionalField = new System.Windows.Forms.ComboBox();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.lblPersonalDetails = new System.Windows.Forms.Label();
            this.picBox_ProfilePic = new System.Windows.Forms.PictureBox();
            this.tabSearchMatch = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabMyProfile.SuspendLayout();
            this.panel_Location.SuspendLayout();
            this.pnl_PersDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMyProfile);
            this.tabControl1.Controls.Add(this.tabSearchMatch);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMyProfile
            // 
            this.tabMyProfile.Controls.Add(this.panel_Location);
            this.tabMyProfile.Controls.Add(this.pnl_PersDet);
            this.tabMyProfile.Location = new System.Drawing.Point(4, 22);
            this.tabMyProfile.Name = "tabMyProfile";
            this.tabMyProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabMyProfile.Size = new System.Drawing.Size(806, 420);
            this.tabMyProfile.TabIndex = 0;
            this.tabMyProfile.Text = "My Profile";
            this.tabMyProfile.UseVisualStyleBackColor = true;
           // this.tabMyProfile.Click += new System.EventHandler(this.tabMyProfile_Click);
            // 
            // panel_Location
            // 
            this.panel_Location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Location.Controls.Add(this.label_Location);
            this.panel_Location.Controls.Add(this.label_To);
            this.panel_Location.Controls.Add(this.comboBox_Hometown);
            this.panel_Location.Controls.Add(this.label_From);
            this.panel_Location.Controls.Add(this.dateTimePicker1);
            this.panel_Location.Controls.Add(this.dateTimePicker2);
            this.panel_Location.Controls.Add(this.comboBox_TempLoc);
            this.panel_Location.Location = new System.Drawing.Point(449, 15);
            this.panel_Location.Name = "panel_Location";
            this.panel_Location.Size = new System.Drawing.Size(341, 388);
            this.panel_Location.TabIndex = 2;
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Location.Location = new System.Drawing.Point(237, 22);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(89, 25);
            this.label_Location.TabIndex = 16;
            this.label_Location.Text = "Location";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_To.Location = new System.Drawing.Point(202, 130);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(18, 13);
            this.label_To.TabIndex = 15;
            this.label_To.Text = "Til";
          //  this.label_To.Click += new System.EventHandler(this.label_To_Click);
            // 
            // comboBox_Hometown
            // 
            this.comboBox_Hometown.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Hometown.FormattingEnabled = true;
            this.comboBox_Hometown.Items.AddRange(new object[] {
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
            this.comboBox_Hometown.Location = new System.Drawing.Point(17, 65);
            this.comboBox_Hometown.Name = "comboBox_Hometown";
            this.comboBox_Hometown.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Hometown.TabIndex = 10;
            this.comboBox_Hometown.Text = "Hometown";
       //     this.comboBox_Hometown.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hometown_SelectedIndexChanged);
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_From.Location = new System.Drawing.Point(187, 101);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(33, 13);
            this.label_From.TabIndex = 14;
            this.label_From.Text = "From";
            //this.label_From.Click += new System.EventHandler(this.label_From_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(227, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // comboBox_TempLoc
            // 
            this.comboBox_TempLoc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TempLoc.FormattingEnabled = true;
            this.comboBox_TempLoc.Items.AddRange(new object[] {
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
            this.comboBox_TempLoc.Location = new System.Drawing.Point(186, 67);
            this.comboBox_TempLoc.Name = "comboBox_TempLoc";
            this.comboBox_TempLoc.Size = new System.Drawing.Size(140, 21);
            this.comboBox_TempLoc.TabIndex = 11;
            this.comboBox_TempLoc.Text = "Temporary location";
            // 
            // pnl_PersDet
            // 
            this.pnl_PersDet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_PersDet.Controls.Add(this.label_InShort);
            this.pnl_PersDet.Controls.Add(this.checkBox_Kids);
            this.pnl_PersDet.Controls.Add(this.checkBox_Freedom);
            this.pnl_PersDet.Controls.Add(this.checkBox_Money);
            this.pnl_PersDet.Controls.Add(this.checkBox_Time);
            this.pnl_PersDet.Controls.Add(this.checkBox_Countryside);
            this.pnl_PersDet.Controls.Add(this.checkBox_City);
            this.pnl_PersDet.Controls.Add(this.label_AboutMe);
            this.pnl_PersDet.Controls.Add(this.txtBox_AboutMe);
            this.pnl_PersDet.Controls.Add(this.txtBox_LastName);
            this.pnl_PersDet.Controls.Add(this.txtBox_ProfessionalTitle);
            this.pnl_PersDet.Controls.Add(this.comboBox_ProfessionalField);
            this.pnl_PersDet.Controls.Add(this.comboBox_Day);
            this.pnl_PersDet.Controls.Add(this.comboBox_Month);
            this.pnl_PersDet.Controls.Add(this.comboBox_Year);
            this.pnl_PersDet.Controls.Add(this.txtBox_FirstName);
            this.pnl_PersDet.Controls.Add(this.lblPersonalDetails);
            this.pnl_PersDet.Controls.Add(this.picBox_ProfilePic);
            this.pnl_PersDet.Location = new System.Drawing.Point(15, 15);
            this.pnl_PersDet.Name = "pnl_PersDet";
            this.pnl_PersDet.Size = new System.Drawing.Size(417, 388);
            this.pnl_PersDet.TabIndex = 1;
          //  this.pnl_PersDet.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_InShort
            // 
            this.label_InShort.AutoSize = true;
            this.label_InShort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InShort.Location = new System.Drawing.Point(16, 310);
            this.label_InShort.Name = "label_InShort";
            this.label_InShort.Size = new System.Drawing.Size(56, 17);
            this.label_InShort.TabIndex = 18;
            this.label_InShort.Text = "In short";
            // 
            // checkBox_Kids
            // 
            this.checkBox_Kids.AutoSize = true;
            this.checkBox_Kids.Location = new System.Drawing.Point(19, 354);
            this.checkBox_Kids.Name = "checkBox_Kids";
            this.checkBox_Kids.Size = new System.Drawing.Size(48, 17);
            this.checkBox_Kids.TabIndex = 17;
            this.checkBox_Kids.Text = "Kids";
            this.checkBox_Kids.UseVisualStyleBackColor = true;
            // 
            // checkBox_Freedom
            // 
            this.checkBox_Freedom.AutoSize = true;
            this.checkBox_Freedom.Location = new System.Drawing.Point(19, 330);
            this.checkBox_Freedom.Name = "checkBox_Freedom";
            this.checkBox_Freedom.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Freedom.TabIndex = 16;
            this.checkBox_Freedom.Text = "Freedom";
            this.checkBox_Freedom.UseVisualStyleBackColor = true;
            // 
            // checkBox_Money
            // 
            this.checkBox_Money.AutoSize = true;
            this.checkBox_Money.Location = new System.Drawing.Point(177, 354);
            this.checkBox_Money.Name = "checkBox_Money";
            this.checkBox_Money.Size = new System.Drawing.Size(63, 17);
            this.checkBox_Money.TabIndex = 15;
            this.checkBox_Money.Text = "Money";
            this.checkBox_Money.UseVisualStyleBackColor = true;
           // this.checkBox_Money.CheckedChanged += new System.EventHandler(this.checkBox_Money_CheckedChanged);
            // 
            // checkBox_Time
            // 
            this.checkBox_Time.AutoSize = true;
            this.checkBox_Time.Location = new System.Drawing.Point(177, 330);
            this.checkBox_Time.Name = "checkBox_Time";
            this.checkBox_Time.Size = new System.Drawing.Size(51, 17);
            this.checkBox_Time.TabIndex = 14;
            this.checkBox_Time.Text = "Time";
            this.checkBox_Time.UseVisualStyleBackColor = true;
           // this.checkBox_Time.CheckedChanged += new System.EventHandler(this.checkBox_Time_CheckedChanged);
            // 
            // checkBox_Countryside
            // 
            this.checkBox_Countryside.AutoSize = true;
            this.checkBox_Countryside.Location = new System.Drawing.Point(316, 354);
            this.checkBox_Countryside.Name = "checkBox_Countryside";
            this.checkBox_Countryside.Size = new System.Drawing.Size(89, 17);
            this.checkBox_Countryside.TabIndex = 13;
            this.checkBox_Countryside.Text = "Countryside";
            this.checkBox_Countryside.UseVisualStyleBackColor = true;
            // 
            // checkBox_City
            // 
            this.checkBox_City.AutoSize = true;
            this.checkBox_City.Location = new System.Drawing.Point(316, 330);
            this.checkBox_City.Name = "checkBox_City";
            this.checkBox_City.Size = new System.Drawing.Size(46, 17);
            this.checkBox_City.TabIndex = 12;
            this.checkBox_City.Text = "City";
            this.checkBox_City.UseVisualStyleBackColor = true;
            // 
            // label_AboutMe
            // 
            this.label_AboutMe.AutoSize = true;
            this.label_AboutMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AboutMe.Location = new System.Drawing.Point(16, 181);
            this.label_AboutMe.Name = "label_AboutMe";
            this.label_AboutMe.Size = new System.Drawing.Size(69, 17);
            this.label_AboutMe.TabIndex = 11;
            this.label_AboutMe.Text = "About me";
            // 
            // txtBox_AboutMe
            // 
            this.txtBox_AboutMe.Location = new System.Drawing.Point(19, 201);
            this.txtBox_AboutMe.MaxLength = 300;
            this.txtBox_AboutMe.Multiline = true;
            this.txtBox_AboutMe.Name = "txtBox_AboutMe";
            this.txtBox_AboutMe.Size = new System.Drawing.Size(380, 95);
            this.txtBox_AboutMe.TabIndex = 10;
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_LastName.Location = new System.Drawing.Point(291, 66);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(108, 22);
            this.txtBox_LastName.TabIndex = 9;
            this.txtBox_LastName.Text = "Last name";
            // 
            // txtBox_ProfessionalTitle
            // 
            this.txtBox_ProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ProfessionalTitle.Location = new System.Drawing.Point(177, 147);
            this.txtBox_ProfessionalTitle.Name = "txtBox_ProfessionalTitle";
            this.txtBox_ProfessionalTitle.Size = new System.Drawing.Size(222, 22);
            this.txtBox_ProfessionalTitle.TabIndex = 8;
            this.txtBox_ProfessionalTitle.Text = "Professional title";
           // this.txtBox_ProfessionalTitle.TextChanged += new System.EventHandler(this.txtBox_ProfessionalTitle_TextChanged);
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
        //    this.comboBox_Month.SelectedIndexChanged += new System.EventHandler(this.comboBox_Month_SelectedIndexChanged);
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
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FirstName.Location = new System.Drawing.Point(177, 65);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(108, 22);
            this.txtBox_FirstName.TabIndex = 2;
            this.txtBox_FirstName.Text = "First name";
            // 
            // lblPersonalDetails
            // 
            this.lblPersonalDetails.AutoSize = true;
            this.lblPersonalDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPersonalDetails.Location = new System.Drawing.Point(14, 15);
            this.lblPersonalDetails.Name = "lblPersonalDetails";
            this.lblPersonalDetails.Size = new System.Drawing.Size(150, 25);
            this.lblPersonalDetails.TabIndex = 1;
            this.lblPersonalDetails.Text = "Personal details";
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
            //this.picBox_ProfilePic.Click += new System.EventHandler(this.picBox_ProfilePic_Click);
            // 
            // tabSearchMatch
            // 
            this.tabSearchMatch.Location = new System.Drawing.Point(4, 22);
            this.tabSearchMatch.Name = "tabSearchMatch";
            this.tabSearchMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchMatch.Size = new System.Drawing.Size(806, 420);
            this.tabSearchMatch.TabIndex = 1;
            this.tabSearchMatch.Text = "Search and Match";
            this.tabSearchMatch.UseVisualStyleBackColor = true;
           // this.tabSearchMatch.Click += new System.EventHandler(this.tabSearchMatch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormContainer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMyProfile.ResumeLayout(false);
            this.panel_Location.ResumeLayout(false);
            this.panel_Location.PerformLayout();
            this.pnl_PersDet.ResumeLayout(false);
            this.pnl_PersDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearchMatch;
        private System.Windows.Forms.TabPage tabMyProfile;
        private System.Windows.Forms.Panel pnl_PersDet;
        private System.Windows.Forms.PictureBox picBox_ProfilePic;
        private System.Windows.Forms.Label lblPersonalDetails;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.ComboBox comboBox_ProfessionalField;
        private System.Windows.Forms.TextBox txtBox_ProfessionalTitle;
        private System.Windows.Forms.TextBox txtBox_LastName;
        private System.Windows.Forms.ComboBox comboBox_Hometown;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_TempLoc;
        private System.Windows.Forms.Panel panel_Location;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Label label_InShort;
        private System.Windows.Forms.CheckBox checkBox_Kids;
        private System.Windows.Forms.CheckBox checkBox_Freedom;
        private System.Windows.Forms.CheckBox checkBox_Money;
        private System.Windows.Forms.CheckBox checkBox_Time;
        private System.Windows.Forms.CheckBox checkBox_Countryside;
        private System.Windows.Forms.CheckBox checkBox_City;
        private System.Windows.Forms.Label label_AboutMe;
        private System.Windows.Forms.TextBox txtBox_AboutMe;
    }
}

