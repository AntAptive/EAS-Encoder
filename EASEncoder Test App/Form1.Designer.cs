namespace EASEncoder_Test_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCounty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOriginator = new System.Windows.Forms.ComboBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkEbsTones = new System.Windows.Forms.CheckBox();
            this.chkNwsTone = new System.Windows.Forms.CheckBox();
            this.txtAnnouncement = new System.Windows.Forms.TextBox();
            this.btnGeneratePlay = new System.Windows.Forms.Button();
            this.datagridRegions = new System.Windows.Forms.DataGridView();
            this.btnAddRegion = new System.Windows.Forms.Button();
            this.locCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClearRegions = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tonePage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timeDurationGroupBox = new System.Windows.Forms.GroupBox();
            this.setTimeToRightNowBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMins = new System.Windows.Forms.NumericUpDown();
            this.eventDescGroupBox = new System.Windows.Forms.GroupBox();
            this.speechPage = new System.Windows.Forms.TabPage();
            this.speechGroupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.installedVoicesComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.enableSpeechCheckBox = new System.Windows.Forms.CheckBox();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.resetDataBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRegions)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tonePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.timeDurationGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMins)).BeginInit();
            this.eventDescGroupBox.SuspendLayout();
            this.speechPage.SuspendLayout();
            this.speechGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.aboutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboState
            // 
            this.comboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(9, 38);
            this.comboState.Margin = new System.Windows.Forms.Padding(2);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(179, 24);
            this.comboState.TabIndex = 0;
            this.comboState.SelectedIndexChanged += new System.EventHandler(this.comboState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "County";
            // 
            // comboCounty
            // 
            this.comboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboCounty.FormattingEnabled = true;
            this.comboCounty.Location = new System.Drawing.Point(200, 38);
            this.comboCounty.Margin = new System.Windows.Forms.Padding(2);
            this.comboCounty.Name = "comboCounty";
            this.comboCounty.Size = new System.Drawing.Size(179, 24);
            this.comboCounty.TabIndex = 2;
            this.comboCounty.SelectedIndexChanged += new System.EventHandler(this.comboCounty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code";
            // 
            // comboCode
            // 
            this.comboCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCode.FormattingEnabled = true;
            this.comboCode.Location = new System.Drawing.Point(5, 83);
            this.comboCode.Margin = new System.Windows.Forms.Padding(2);
            this.comboCode.Name = "comboCode";
            this.comboCode.Size = new System.Drawing.Size(248, 24);
            this.comboCode.TabIndex = 4;
            this.comboCode.SelectedIndexChanged += new System.EventHandler(this.comboCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Originator";
            // 
            // comboOriginator
            // 
            this.comboOriginator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOriginator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOriginator.FormattingEnabled = true;
            this.comboOriginator.Location = new System.Drawing.Point(5, 37);
            this.comboOriginator.Margin = new System.Windows.Forms.Padding(2);
            this.comboOriginator.Name = "comboOriginator";
            this.comboOriginator.Size = new System.Drawing.Size(248, 24);
            this.comboOriginator.TabIndex = 6;
            this.comboOriginator.SelectedIndexChanged += new System.EventHandler(this.comboOriginator_SelectedIndexChanged);
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateStart.Location = new System.Drawing.Point(5, 35);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(237, 22);
            this.dateStart.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Event Begin Date && Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hours";
            // 
            // txtSender
            // 
            this.txtSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSender.Location = new System.Drawing.Point(261, 37);
            this.txtSender.Margin = new System.Windows.Forms.Padding(2);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(118, 24);
            this.txtSender.TabIndex = 12;
            this.txtSender.TextChanged += new System.EventHandler(this.txtSender_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sender ID (8 Chars)";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.Location = new System.Drawing.Point(207, 522);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(189, 28);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate EAS File";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkEbsTones
            // 
            this.chkEbsTones.AutoSize = true;
            this.chkEbsTones.Checked = true;
            this.chkEbsTones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEbsTones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkEbsTones.Location = new System.Drawing.Point(5, 18);
            this.chkEbsTones.Margin = new System.Windows.Forms.Padding(2);
            this.chkEbsTones.Name = "chkEbsTones";
            this.chkEbsTones.Size = new System.Drawing.Size(177, 20);
            this.chkEbsTones.TabIndex = 15;
            this.chkEbsTones.Text = "Use EBS Attention Tones";
            this.chkEbsTones.UseVisualStyleBackColor = true;
            // 
            // chkNwsTone
            // 
            this.chkNwsTone.AutoSize = true;
            this.chkNwsTone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkNwsTone.Location = new System.Drawing.Point(5, 42);
            this.chkNwsTone.Margin = new System.Windows.Forms.Padding(2);
            this.chkNwsTone.Name = "chkNwsTone";
            this.chkNwsTone.Size = new System.Drawing.Size(175, 20);
            this.chkNwsTone.TabIndex = 16;
            this.chkNwsTone.Text = "Use NWS Attention Tone";
            this.chkNwsTone.UseVisualStyleBackColor = true;
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Location = new System.Drawing.Point(9, 119);
            this.txtAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnouncement.Multiline = true;
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnnouncement.Size = new System.Drawing.Size(370, 352);
            this.txtAnnouncement.TabIndex = 17;
            // 
            // btnGeneratePlay
            // 
            this.btnGeneratePlay.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneratePlay.Location = new System.Drawing.Point(207, 488);
            this.btnGeneratePlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneratePlay.Name = "btnGeneratePlay";
            this.btnGeneratePlay.Size = new System.Drawing.Size(189, 28);
            this.btnGeneratePlay.TabIndex = 18;
            this.btnGeneratePlay.Text = "Preview EAS";
            this.btnGeneratePlay.UseVisualStyleBackColor = false;
            this.btnGeneratePlay.Click += new System.EventHandler(this.btnGeneratePlay_Click);
            // 
            // datagridRegions
            // 
            this.datagridRegions.AllowUserToAddRows = false;
            this.datagridRegions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridRegions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRegions.Location = new System.Drawing.Point(9, 105);
            this.datagridRegions.Margin = new System.Windows.Forms.Padding(2);
            this.datagridRegions.Name = "datagridRegions";
            this.datagridRegions.RowHeadersVisible = false;
            this.datagridRegions.RowTemplate.Height = 24;
            this.datagridRegions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridRegions.Size = new System.Drawing.Size(370, 111);
            this.datagridRegions.TabIndex = 19;
            this.datagridRegions.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.datagridRegions_UserDeletedRow);
            this.datagridRegions.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.datagridRegions_UserDeletingRow);
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddRegion.Location = new System.Drawing.Point(290, 76);
            this.btnAddRegion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(89, 25);
            this.btnAddRegion.TabIndex = 20;
            this.btnAddRegion.Text = "Add Location";
            this.btnAddRegion.UseVisualStyleBackColor = false;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // locCountLabel
            // 
            this.locCountLabel.AutoSize = true;
            this.locCountLabel.ForeColor = System.Drawing.Color.Red;
            this.locCountLabel.Location = new System.Drawing.Point(7, 223);
            this.locCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locCountLabel.Name = "locCountLabel";
            this.locCountLabel.Size = new System.Drawing.Size(96, 13);
            this.locCountLabel.TabIndex = 21;
            this.locCountLabel.Text = "Event Locations: 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Announcement Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Minutes";
            // 
            // btnClearRegions
            // 
            this.btnClearRegions.BackColor = System.Drawing.Color.LightCoral;
            this.btnClearRegions.Location = new System.Drawing.Point(10, 76);
            this.btnClearRegions.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearRegions.Name = "btnClearRegions";
            this.btnClearRegions.Size = new System.Drawing.Size(126, 25);
            this.btnClearRegions.TabIndex = 30;
            this.btnClearRegions.Text = "Clear All Locations";
            this.btnClearRegions.UseVisualStyleBackColor = false;
            this.btnClearRegions.Click += new System.EventHandler(this.btnClearRegions_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tonePage);
            this.tabControl1.Controls.Add(this.speechPage);
            this.tabControl1.Controls.Add(this.aboutPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 583);
            this.tabControl1.TabIndex = 32;
            // 
            // tonePage
            // 
            this.tonePage.Controls.Add(this.groupBox1);
            this.tonePage.Controls.Add(this.locationGroupBox);
            this.tonePage.Controls.Add(this.timeDurationGroupBox);
            this.tonePage.Controls.Add(this.eventDescGroupBox);
            this.tonePage.Controls.Add(this.btnGeneratePlay);
            this.tonePage.Controls.Add(this.btnGenerate);
            this.tonePage.Location = new System.Drawing.Point(4, 22);
            this.tonePage.Name = "tonePage";
            this.tonePage.Padding = new System.Windows.Forms.Padding(3);
            this.tonePage.Size = new System.Drawing.Size(404, 557);
            this.tonePage.TabIndex = 0;
            this.tonePage.Text = "Tone Generator";
            this.tonePage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEbsTones);
            this.groupBox1.Controls.Add(this.chkNwsTone);
            this.groupBox1.Location = new System.Drawing.Point(6, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 67);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Tones";
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.label8);
            this.locationGroupBox.Controls.Add(this.comboState);
            this.locationGroupBox.Controls.Add(this.label1);
            this.locationGroupBox.Controls.Add(this.btnClearRegions);
            this.locationGroupBox.Controls.Add(this.comboCounty);
            this.locationGroupBox.Controls.Add(this.label2);
            this.locationGroupBox.Controls.Add(this.btnAddRegion);
            this.locationGroupBox.Controls.Add(this.datagridRegions);
            this.locationGroupBox.Controls.Add(this.locCountLabel);
            this.locationGroupBox.Location = new System.Drawing.Point(6, 232);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(389, 245);
            this.locationGroupBox.TabIndex = 25;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Click a location and press Delete to delete it.";
            // 
            // timeDurationGroupBox
            // 
            this.timeDurationGroupBox.Controls.Add(this.setTimeToRightNowBtn);
            this.timeDurationGroupBox.Controls.Add(this.groupBox3);
            this.timeDurationGroupBox.Controls.Add(this.label5);
            this.timeDurationGroupBox.Controls.Add(this.dateStart);
            this.timeDurationGroupBox.Location = new System.Drawing.Point(6, 130);
            this.timeDurationGroupBox.Name = "timeDurationGroupBox";
            this.timeDurationGroupBox.Size = new System.Drawing.Size(389, 95);
            this.timeDurationGroupBox.TabIndex = 1;
            this.timeDurationGroupBox.TabStop = false;
            this.timeDurationGroupBox.Text = "Time && Duration";
            // 
            // setTimeToRightNowBtn
            // 
            this.setTimeToRightNowBtn.Location = new System.Drawing.Point(5, 63);
            this.setTimeToRightNowBtn.Name = "setTimeToRightNowBtn";
            this.setTimeToRightNowBtn.Size = new System.Drawing.Size(237, 23);
            this.setTimeToRightNowBtn.TabIndex = 29;
            this.setTimeToRightNowBtn.Text = "Set Date && Time to Right Now";
            this.setTimeToRightNowBtn.UseVisualStyleBackColor = true;
            this.setTimeToRightNowBtn.Click += new System.EventHandler(this.setTimeToRightNowBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownHours);
            this.groupBox3.Controls.Add(this.numericUpDownMins);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(246, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 79);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valid Duration";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numericUpDownHours.Location = new System.Drawing.Point(54, 18);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownHours.TabIndex = 26;
            // 
            // numericUpDownMins
            // 
            this.numericUpDownMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numericUpDownMins.Location = new System.Drawing.Point(54, 46);
            this.numericUpDownMins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMins.Name = "numericUpDownMins";
            this.numericUpDownMins.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownMins.TabIndex = 27;
            // 
            // eventDescGroupBox
            // 
            this.eventDescGroupBox.Controls.Add(this.comboOriginator);
            this.eventDescGroupBox.Controls.Add(this.label7);
            this.eventDescGroupBox.Controls.Add(this.comboCode);
            this.eventDescGroupBox.Controls.Add(this.label3);
            this.eventDescGroupBox.Controls.Add(this.label4);
            this.eventDescGroupBox.Controls.Add(this.txtSender);
            this.eventDescGroupBox.Location = new System.Drawing.Point(6, 3);
            this.eventDescGroupBox.Name = "eventDescGroupBox";
            this.eventDescGroupBox.Size = new System.Drawing.Size(389, 121);
            this.eventDescGroupBox.TabIndex = 0;
            this.eventDescGroupBox.TabStop = false;
            this.eventDescGroupBox.Text = "Event Description";
            // 
            // speechPage
            // 
            this.speechPage.Controls.Add(this.speechGroupBox);
            this.speechPage.Controls.Add(this.enableSpeechCheckBox);
            this.speechPage.Location = new System.Drawing.Point(4, 22);
            this.speechPage.Name = "speechPage";
            this.speechPage.Padding = new System.Windows.Forms.Padding(3);
            this.speechPage.Size = new System.Drawing.Size(404, 557);
            this.speechPage.TabIndex = 1;
            this.speechPage.Text = "Speech";
            this.speechPage.UseVisualStyleBackColor = true;
            // 
            // speechGroupBox
            // 
            this.speechGroupBox.Controls.Add(this.label17);
            this.speechGroupBox.Controls.Add(this.label16);
            this.speechGroupBox.Controls.Add(this.label15);
            this.speechGroupBox.Controls.Add(this.label14);
            this.speechGroupBox.Controls.Add(this.speedTrackBar);
            this.speechGroupBox.Controls.Add(this.installedVoicesComboBox);
            this.speechGroupBox.Controls.Add(this.label13);
            this.speechGroupBox.Controls.Add(this.txtAnnouncement);
            this.speechGroupBox.Controls.Add(this.label9);
            this.speechGroupBox.Enabled = false;
            this.speechGroupBox.Location = new System.Drawing.Point(6, 32);
            this.speechGroupBox.Name = "speechGroupBox";
            this.speechGroupBox.Size = new System.Drawing.Size(392, 519);
            this.speechGroupBox.TabIndex = 25;
            this.speechGroupBox.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(356, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "20";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(206, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(52, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Speed";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(50, 49);
            this.speedTrackBar.Minimum = -10;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(329, 45);
            this.speedTrackBar.TabIndex = 33;
            // 
            // installedVoicesComboBox
            // 
            this.installedVoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.installedVoicesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.installedVoicesComboBox.FormattingEnabled = true;
            this.installedVoicesComboBox.Location = new System.Drawing.Point(50, 19);
            this.installedVoicesComboBox.Name = "installedVoicesComboBox";
            this.installedVoicesComboBox.Size = new System.Drawing.Size(329, 24);
            this.installedVoicesComboBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Voice";
            // 
            // enableSpeechCheckBox
            // 
            this.enableSpeechCheckBox.AutoSize = true;
            this.enableSpeechCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.enableSpeechCheckBox.Location = new System.Drawing.Point(8, 10);
            this.enableSpeechCheckBox.Name = "enableSpeechCheckBox";
            this.enableSpeechCheckBox.Size = new System.Drawing.Size(119, 20);
            this.enableSpeechCheckBox.TabIndex = 0;
            this.enableSpeechCheckBox.Text = "Enable Speech";
            this.enableSpeechCheckBox.UseVisualStyleBackColor = true;
            this.enableSpeechCheckBox.CheckedChanged += new System.EventHandler(this.enableSpeechCheckBox_CheckedChanged);
            // 
            // aboutPage
            // 
            this.aboutPage.Controls.Add(this.resetDataBtn);
            this.aboutPage.Controls.Add(this.label22);
            this.aboutPage.Controls.Add(this.pictureBox1);
            this.aboutPage.Controls.Add(this.richTextBox1);
            this.aboutPage.Controls.Add(this.label21);
            this.aboutPage.Controls.Add(this.label20);
            this.aboutPage.Controls.Add(this.label19);
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(404, 557);
            this.aboutPage.TabIndex = 2;
            this.aboutPage.Text = "About";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // resetDataBtn
            // 
            this.resetDataBtn.BackColor = System.Drawing.Color.LightCoral;
            this.resetDataBtn.Location = new System.Drawing.Point(8, 520);
            this.resetDataBtn.Name = "resetDataBtn";
            this.resetDataBtn.Size = new System.Drawing.Size(145, 30);
            this.resetDataBtn.TabIndex = 7;
            this.resetDataBtn.Text = "Reset Program Data";
            this.resetDataBtn.UseVisualStyleBackColor = false;
            this.resetDataBtn.Click += new System.EventHandler(this.resetDataBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(118, 317);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(168, 26);
            this.label22.TabIndex = 6;
            this.label22.Text = "Special thanks to our beta testers!\r\nAntWaifu && Mr. Yeast";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EASEncoder_Test_App.Properties.Resources.Logo_Black;
            this.pictureBox1.Location = new System.Drawing.Point(77, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 356);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(358, 158);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(323, 532);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Version 2.0.2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(94, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(222, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "by Sasquelch, AntAptive, k2fc && jemerson722";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(127, 270);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "EAS Encoder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 581);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "EAS Encoder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridRegions)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tonePage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            this.timeDurationGroupBox.ResumeLayout(false);
            this.timeDurationGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMins)).EndInit();
            this.eventDescGroupBox.ResumeLayout(false);
            this.eventDescGroupBox.PerformLayout();
            this.speechPage.ResumeLayout(false);
            this.speechPage.PerformLayout();
            this.speechGroupBox.ResumeLayout(false);
            this.speechGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.aboutPage.ResumeLayout(false);
            this.aboutPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCounty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboOriginator;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkEbsTones;
        private System.Windows.Forms.CheckBox chkNwsTone;
        private System.Windows.Forms.TextBox txtAnnouncement;
        private System.Windows.Forms.Button btnGeneratePlay;
        private System.Windows.Forms.DataGridView datagridRegions;
        private System.Windows.Forms.Button btnAddRegion;
        private System.Windows.Forms.Label locCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClearRegions;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tonePage;
        private System.Windows.Forms.TabPage speechPage;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.GroupBox eventDescGroupBox;
        private System.Windows.Forms.GroupBox timeDurationGroupBox;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMins;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button setTimeToRightNowBtn;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox enableSpeechCheckBox;
        private System.Windows.Forms.ComboBox installedVoicesComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox speechGroupBox;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button resetDataBtn;
    }
}

