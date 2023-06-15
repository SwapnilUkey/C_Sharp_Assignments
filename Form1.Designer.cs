namespace Assignment2._1
{
    partial class MainFormL2P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormL2P));
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.MainFormGroupBox = new System.Windows.Forms.GroupBox();
            this.CertificateGroupBox = new System.Windows.Forms.GroupBox();
            this.DigCertCheckBox = new System.Windows.Forms.CheckBox();
            this.UpgradeBox = new System.Windows.Forms.GroupBox();
            this.NoupgradeRadioButton = new System.Windows.Forms.RadioButton();
            this.ExecutiveRadioButton = new System.Windows.Forms.RadioButton();
            this.JuniorRadioButton = new System.Windows.Forms.RadioButton();
            this.MasterRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.ParticipantTextBox = new System.Windows.Forms.TextBox();
            this.ParticipantGroupBox = new System.Windows.Forms.GroupBox();
            this.Participantlabel = new System.Windows.Forms.Label();
            this.LocationFeesListBox = new System.Windows.Forms.ListBox();
            this.CoursesListBox = new System.Windows.Forms.ListBox();
            this.LoactionHeader = new System.Windows.Forms.GroupBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.AccFeelabel = new System.Windows.Forms.Label();
            this.CoursesHeader = new System.Windows.Forms.GroupBox();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.TrainDayLabel = new System.Windows.Forms.Label();
            this.EnrolLabel = new System.Windows.Forms.Label();
            this.DisplaytoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BooktoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummarytoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CleartoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExittoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MastertoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExecutivetoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.JuniortoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CertificatetoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DisplayTextBox = new System.Windows.Forms.Label();
            this.DisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.Buttons.SuspendLayout();
            this.MainFormGroupBox.SuspendLayout();
            this.CertificateGroupBox.SuspendLayout();
            this.UpgradeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.ParticipantGroupBox.SuspendLayout();
            this.LoactionHeader.SuspendLayout();
            this.CoursesHeader.SuspendLayout();
            this.DisplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buttons
            // 
            this.Buttons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buttons.Controls.Add(this.ExitButton);
            this.Buttons.Controls.Add(this.DisplayButton);
            this.Buttons.Controls.Add(this.ClearButton);
            this.Buttons.Controls.Add(this.SummaryButton);
            this.Buttons.Controls.Add(this.BookButton);
            this.Buttons.Location = new System.Drawing.Point(992, 322);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(200, 303);
            this.Buttons.TabIndex = 0;
            this.Buttons.TabStop = false;
            this.Buttons.Text = "Buttons";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(49, 247);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 30);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExittoolTip.SetToolTip(this.ExitButton, "Click To Exdwit Application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(49, 27);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(100, 30);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "Display";
            this.DisplaytoolTip.SetToolTip(this.DisplayButton, "Click To Display Current Booking");
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(49, 196);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 30);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.CleartoolTip.SetToolTip(this.ClearButton, "Click To Book New Participant");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(49, 140);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(100, 30);
            this.SummaryButton.TabIndex = 4;
            this.SummaryButton.Text = "Summary";
            this.SummarytoolTip.SetToolTip(this.SummaryButton, "Click To View Summary");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.Location = new System.Drawing.Point(49, 83);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(100, 30);
            this.BookButton.TabIndex = 2;
            this.BookButton.Text = "Book";
            this.BooktoolTip.SetToolTip(this.BookButton, "Click To Book");
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // MainFormGroupBox
            // 
            this.MainFormGroupBox.Controls.Add(this.CertificateGroupBox);
            this.MainFormGroupBox.Controls.Add(this.UpgradeBox);
            this.MainFormGroupBox.Controls.Add(this.LogoPicBox);
            this.MainFormGroupBox.Controls.Add(this.ParticipantTextBox);
            this.MainFormGroupBox.Controls.Add(this.ParticipantGroupBox);
            this.MainFormGroupBox.Controls.Add(this.LocationFeesListBox);
            this.MainFormGroupBox.Controls.Add(this.CoursesListBox);
            this.MainFormGroupBox.Controls.Add(this.LoactionHeader);
            this.MainFormGroupBox.Controls.Add(this.CoursesHeader);
            this.MainFormGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainFormGroupBox.Name = "MainFormGroupBox";
            this.MainFormGroupBox.Size = new System.Drawing.Size(1469, 292);
            this.MainFormGroupBox.TabIndex = 2;
            this.MainFormGroupBox.TabStop = false;
            this.MainFormGroupBox.Text = "Main Form";
            // 
            // CertificateGroupBox
            // 
            this.CertificateGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CertificateGroupBox.Controls.Add(this.DigCertCheckBox);
            this.CertificateGroupBox.Location = new System.Drawing.Point(1208, 195);
            this.CertificateGroupBox.Name = "CertificateGroupBox";
            this.CertificateGroupBox.Size = new System.Drawing.Size(245, 68);
            this.CertificateGroupBox.TabIndex = 11;
            this.CertificateGroupBox.TabStop = false;
            this.CertificateGroupBox.Text = "Certificate";
            // 
            // DigCertCheckBox
            // 
            this.DigCertCheckBox.AutoSize = true;
            this.DigCertCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigCertCheckBox.Location = new System.Drawing.Point(6, 29);
            this.DigCertCheckBox.Name = "DigCertCheckBox";
            this.DigCertCheckBox.Size = new System.Drawing.Size(187, 24);
            this.DigCertCheckBox.TabIndex = 0;
            this.DigCertCheckBox.Text = "Certificate - £ 39.99";
            this.CertificatetoolTip.SetToolTip(this.DigCertCheckBox, "£ 39.99");
            this.DigCertCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpgradeBox
            // 
            this.UpgradeBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpgradeBox.Controls.Add(this.NoupgradeRadioButton);
            this.UpgradeBox.Controls.Add(this.ExecutiveRadioButton);
            this.UpgradeBox.Controls.Add(this.JuniorRadioButton);
            this.UpgradeBox.Controls.Add(this.MasterRadioButton);
            this.UpgradeBox.Location = new System.Drawing.Point(1208, 19);
            this.UpgradeBox.Name = "UpgradeBox";
            this.UpgradeBox.Size = new System.Drawing.Size(245, 159);
            this.UpgradeBox.TabIndex = 10;
            this.UpgradeBox.TabStop = false;
            this.UpgradeBox.Text = "Room Upgrades";
            // 
            // NoupgradeRadioButton
            // 
            this.NoupgradeRadioButton.AutoSize = true;
            this.NoupgradeRadioButton.Checked = true;
            this.NoupgradeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoupgradeRadioButton.Location = new System.Drawing.Point(6, 122);
            this.NoupgradeRadioButton.Name = "NoupgradeRadioButton";
            this.NoupgradeRadioButton.Size = new System.Drawing.Size(189, 24);
            this.NoupgradeRadioButton.TabIndex = 3;
            this.NoupgradeRadioButton.TabStop = true;
            this.NoupgradeRadioButton.Text = "No Upgrade - £ 0.00";
            this.NoupgradeRadioButton.UseVisualStyleBackColor = true;
            this.NoupgradeRadioButton.Visible = false;
            // 
            // ExecutiveRadioButton
            // 
            this.ExecutiveRadioButton.AutoSize = true;
            this.ExecutiveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecutiveRadioButton.Location = new System.Drawing.Point(6, 63);
            this.ExecutiveRadioButton.Name = "ExecutiveRadioButton";
            this.ExecutiveRadioButton.Size = new System.Drawing.Size(227, 24);
            this.ExecutiveRadioButton.TabIndex = 2;
            this.ExecutiveRadioButton.Text = "Executive Suite - £ 69.99";
            this.ExecutivetoolTip.SetToolTip(this.ExecutiveRadioButton, "£ 69.99");
            this.ExecutiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // JuniorRadioButton
            // 
            this.JuniorRadioButton.AutoSize = true;
            this.JuniorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JuniorRadioButton.Location = new System.Drawing.Point(6, 93);
            this.JuniorRadioButton.Name = "JuniorRadioButton";
            this.JuniorRadioButton.Size = new System.Drawing.Size(199, 24);
            this.JuniorRadioButton.TabIndex = 1;
            this.JuniorRadioButton.Text = "Junior Suite - £ 49.99";
            this.JuniortoolTip.SetToolTip(this.JuniorRadioButton, "£ 49.99");
            this.JuniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasterRadioButton
            // 
            this.MasterRadioButton.AutoSize = true;
            this.MasterRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterRadioButton.Location = new System.Drawing.Point(6, 32);
            this.MasterRadioButton.Name = "MasterRadioButton";
            this.MasterRadioButton.Size = new System.Drawing.Size(205, 24);
            this.MasterRadioButton.TabIndex = 0;
            this.MasterRadioButton.Text = "Master Suite - £ 99.99";
            this.MastertoolTip.SetToolTip(this.MasterRadioButton, "£ 99.99");
            this.MasterRadioButton.UseVisualStyleBackColor = true;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.BackColor = System.Drawing.Color.White;
            this.LogoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicBox.Image")));
            this.LogoPicBox.Location = new System.Drawing.Point(1060, 140);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(130, 123);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicBox.TabIndex = 9;
            this.LogoPicBox.TabStop = false;
            // 
            // ParticipantTextBox
            // 
            this.ParticipantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantTextBox.Location = new System.Drawing.Point(1060, 80);
            this.ParticipantTextBox.Name = "ParticipantTextBox";
            this.ParticipantTextBox.Size = new System.Drawing.Size(130, 27);
            this.ParticipantTextBox.TabIndex = 8;
            this.ParticipantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ParticipantGroupBox
            // 
            this.ParticipantGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ParticipantGroupBox.Controls.Add(this.Participantlabel);
            this.ParticipantGroupBox.Location = new System.Drawing.Point(1060, 19);
            this.ParticipantGroupBox.Name = "ParticipantGroupBox";
            this.ParticipantGroupBox.Size = new System.Drawing.Size(130, 54);
            this.ParticipantGroupBox.TabIndex = 7;
            this.ParticipantGroupBox.TabStop = false;
            // 
            // Participantlabel
            // 
            this.Participantlabel.AutoSize = true;
            this.Participantlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participantlabel.Location = new System.Drawing.Point(6, 16);
            this.Participantlabel.Name = "Participantlabel";
            this.Participantlabel.Size = new System.Drawing.Size(114, 20);
            this.Participantlabel.TabIndex = 5;
            this.Participantlabel.Text = "  Participants";
            this.Participantlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationFeesListBox
            // 
            this.LocationFeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationFeesListBox.FormattingEnabled = true;
            this.LocationFeesListBox.ItemHeight = 20;
            this.LocationFeesListBox.Items.AddRange(new object[] {
            "    Be Im ullet\t\t\t£ 219,99",
            "    Clifden\t\t\t\t£ 119,99",
            "    Cork\t\t\t\t£ 149,99",
            "    Dublin\t\t\t\t£ 179,99",
            "    Killamy\t\t\t\t£ 149,99",
            "    LetterKenny\t\t\t£   89,99",
            "    Sligo\t\t\t\t£ 119,99"});
            this.LocationFeesListBox.Location = new System.Drawing.Point(540, 79);
            this.LocationFeesListBox.Name = "LocationFeesListBox";
            this.LocationFeesListBox.Size = new System.Drawing.Size(503, 184);
            this.LocationFeesListBox.TabIndex = 3;
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.ItemHeight = 20;
            this.CoursesListBox.Items.AddRange(new object[] {
            "C# Fundamentals\t\t2 Days\t\t£ 900",
            "C# Basics for Beginners\t4 Days\t\t£ 1,500",
            "C# Intermidiate \t\t4 Days\t\t£ 1,800",
            "C# Advance Topics\t\t2 Days\t\t£ 2,300",
            "ASP.NET with C# Part A\t5 Days\t\t£ 1,250",
            "ASP.NET with C# Part B\t5 Days\t\t£ 1,250"});
            this.CoursesListBox.Location = new System.Drawing.Point(12, 80);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(503, 184);
            this.CoursesListBox.TabIndex = 2;
            // 
            // LoactionHeader
            // 
            this.LoactionHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoactionHeader.Controls.Add(this.LocationLabel);
            this.LoactionHeader.Controls.Add(this.AccFeelabel);
            this.LoactionHeader.Location = new System.Drawing.Point(540, 19);
            this.LoactionHeader.Name = "LoactionHeader";
            this.LoactionHeader.Size = new System.Drawing.Size(503, 54);
            this.LoactionHeader.TabIndex = 1;
            this.LoactionHeader.TabStop = false;
            this.LoactionHeader.Text = "Select Location";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(6, 21);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(87, 20);
            this.LocationLabel.TabIndex = 5;
            this.LocationLabel.Text = "Locations";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccFeelabel
            // 
            this.AccFeelabel.AutoSize = true;
            this.AccFeelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccFeelabel.Location = new System.Drawing.Point(248, 11);
            this.AccFeelabel.Name = "AccFeelabel";
            this.AccFeelabel.Size = new System.Drawing.Size(219, 40);
            this.AccFeelabel.TabIndex = 6;
            this.AccFeelabel.Text = "Accommodation Fees Per \r\nDays";
            this.AccFeelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoursesHeader
            // 
            this.CoursesHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoursesHeader.Controls.Add(this.CoursesLabel);
            this.CoursesHeader.Controls.Add(this.TrainDayLabel);
            this.CoursesHeader.Controls.Add(this.EnrolLabel);
            this.CoursesHeader.Location = new System.Drawing.Point(12, 19);
            this.CoursesHeader.Name = "CoursesHeader";
            this.CoursesHeader.Size = new System.Drawing.Size(503, 54);
            this.CoursesHeader.TabIndex = 0;
            this.CoursesHeader.TabStop = false;
            this.CoursesHeader.Text = "Select Course";
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesLabel.Location = new System.Drawing.Point(25, 21);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(75, 20);
            this.CoursesLabel.TabIndex = 2;
            this.CoursesLabel.Text = "Courses";
            this.CoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainDayLabel
            // 
            this.TrainDayLabel.AutoSize = true;
            this.TrainDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainDayLabel.Location = new System.Drawing.Point(224, 11);
            this.TrainDayLabel.Name = "TrainDayLabel";
            this.TrainDayLabel.Size = new System.Drawing.Size(78, 40);
            this.TrainDayLabel.TabIndex = 4;
            this.TrainDayLabel.Text = "Training \r\nDays";
            this.TrainDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnrolLabel
            // 
            this.EnrolLabel.AutoSize = true;
            this.EnrolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrolLabel.Location = new System.Drawing.Point(380, 11);
            this.EnrolLabel.Name = "EnrolLabel";
            this.EnrolLabel.Size = new System.Drawing.Size(100, 40);
            this.EnrolLabel.TabIndex = 3;
            this.EnrolLabel.Text = "Enrollment \r\nFees";
            this.EnrolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplaytoolTip
            // 
            this.DisplaytoolTip.IsBalloon = true;
            this.DisplaytoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DisplaytoolTip.ToolTipTitle = "Display Info";
            // 
            // BooktoolTip
            // 
            this.BooktoolTip.IsBalloon = true;
            this.BooktoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.BooktoolTip.ToolTipTitle = "Book Info";
            // 
            // SummarytoolTip
            // 
            this.SummarytoolTip.IsBalloon = true;
            this.SummarytoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SummarytoolTip.ToolTipTitle = "Summary Info";
            // 
            // CleartoolTip
            // 
            this.CleartoolTip.IsBalloon = true;
            this.CleartoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CleartoolTip.ToolTipTitle = "Clear Info";
            // 
            // ExittoolTip
            // 
            this.ExittoolTip.IsBalloon = true;
            this.ExittoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExittoolTip.ToolTipTitle = "Exit Info";
            // 
            // MastertoolTip
            // 
            this.MastertoolTip.IsBalloon = true;
            this.MastertoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MastertoolTip.ToolTipTitle = "Price";
            // 
            // ExecutivetoolTip
            // 
            this.ExecutivetoolTip.IsBalloon = true;
            this.ExecutivetoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExecutivetoolTip.ToolTipTitle = "Price";
            // 
            // JuniortoolTip
            // 
            this.JuniortoolTip.IsBalloon = true;
            this.JuniortoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.JuniortoolTip.ToolTipTitle = "Price";
            // 
            // CertificatetoolTip
            // 
            this.CertificatetoolTip.IsBalloon = true;
            this.CertificatetoolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.CertificatetoolTip.ToolTipTitle = "Price";
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.AutoSize = true;
            this.DisplayTextBox.BackColor = System.Drawing.Color.White;
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.Location = new System.Drawing.Point(61, 27);
            this.DisplayTextBox.MinimumSize = new System.Drawing.Size(500, 250);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(500, 250);
            this.DisplayTextBox.TabIndex = 3;
            // 
            // DisplayGroupBox
            // 
            this.DisplayGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DisplayGroupBox.Controls.Add(this.DisplayTextBox);
            this.DisplayGroupBox.Location = new System.Drawing.Point(320, 322);
            this.DisplayGroupBox.Name = "DisplayGroupBox";
            this.DisplayGroupBox.Size = new System.Drawing.Size(634, 303);
            this.DisplayGroupBox.TabIndex = 4;
            this.DisplayGroupBox.TabStop = false;
            this.DisplayGroupBox.Text = "Display Booking";
            // 
            // MainFormL2P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 648);
            this.Controls.Add(this.DisplayGroupBox);
            this.Controls.Add(this.MainFormGroupBox);
            this.Controls.Add(this.Buttons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormL2P";
            this.Text = "L2P LTD.";
            this.Load += new System.EventHandler(this.MainFormL2P_Load);
            this.Buttons.ResumeLayout(false);
            this.MainFormGroupBox.ResumeLayout(false);
            this.MainFormGroupBox.PerformLayout();
            this.CertificateGroupBox.ResumeLayout(false);
            this.CertificateGroupBox.PerformLayout();
            this.UpgradeBox.ResumeLayout(false);
            this.UpgradeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ParticipantGroupBox.ResumeLayout(false);
            this.ParticipantGroupBox.PerformLayout();
            this.LoactionHeader.ResumeLayout(false);
            this.LoactionHeader.PerformLayout();
            this.CoursesHeader.ResumeLayout(false);
            this.CoursesHeader.PerformLayout();
            this.DisplayGroupBox.ResumeLayout(false);
            this.DisplayGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.GroupBox MainFormGroupBox;
        private System.Windows.Forms.GroupBox CertificateGroupBox;
        private System.Windows.Forms.CheckBox DigCertCheckBox;
        private System.Windows.Forms.GroupBox UpgradeBox;
        private System.Windows.Forms.RadioButton ExecutiveRadioButton;
        private System.Windows.Forms.RadioButton JuniorRadioButton;
        private System.Windows.Forms.RadioButton MasterRadioButton;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.TextBox ParticipantTextBox;
        private System.Windows.Forms.GroupBox ParticipantGroupBox;
        private System.Windows.Forms.Label Participantlabel;
        private System.Windows.Forms.ListBox LocationFeesListBox;
        private System.Windows.Forms.ListBox CoursesListBox;
        private System.Windows.Forms.GroupBox LoactionHeader;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label AccFeelabel;
        private System.Windows.Forms.GroupBox CoursesHeader;
        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.Label TrainDayLabel;
        private System.Windows.Forms.Label EnrolLabel;
        private System.Windows.Forms.ToolTip DisplaytoolTip;
        private System.Windows.Forms.ToolTip BooktoolTip;
        private System.Windows.Forms.ToolTip SummarytoolTip;
        private System.Windows.Forms.ToolTip CleartoolTip;
        private System.Windows.Forms.ToolTip ExittoolTip;
        private System.Windows.Forms.ToolTip MastertoolTip;
        private System.Windows.Forms.ToolTip ExecutivetoolTip;
        private System.Windows.Forms.ToolTip JuniortoolTip;
        private System.Windows.Forms.ToolTip CertificatetoolTip;
        private System.Windows.Forms.RadioButton NoupgradeRadioButton;
        private System.Windows.Forms.Label DisplayTextBox;
        private System.Windows.Forms.GroupBox DisplayGroupBox;
    }
}

