namespace Managed_Doom_Launcher
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstIWADS = new System.Windows.Forms.ListBox();
            this.BtnEngineLocation = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnIWADSLocation = new System.Windows.Forms.Button();
            this.cmbMonsters = new System.Windows.Forms.ComboBox();
            this.cmbGameMods = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaps2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaps3 = new System.Windows.Forms.ComboBox();
            this.cmbMaps4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaps5 = new System.Windows.Forms.ComboBox();
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.cmbSkills = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMonsters = new System.Windows.Forms.Label();
            this.lblWarp = new System.Windows.Forms.Label();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSaveAdditional = new System.Windows.Forms.CheckBox();
            this.IWAD_SelectedItem = new System.Windows.Forms.GroupBox();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.Logo_Box = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdditionalCmds = new System.Windows.Forms.TextBox();
            this.tabAddons = new System.Windows.Forms.TabPage();
            this.current_deh = new System.Windows.Forms.TextBox();
            this.current_pwad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableRemoveAll = new System.Windows.Forms.CheckBox();
            this.btnClearAll_RecentDeh = new System.Windows.Forms.Button();
            this.btnClearAll_RecentPwads = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lstRecent_Pwads = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear_RecentPwads = new System.Windows.Forms.Button();
            this.lstRecent_Deh = new System.Windows.Forms.ListBox();
            this.btnClear_RecentDeh = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoadDeh = new System.Windows.Forms.Button();
            this.btnClearDeh = new System.Windows.Forms.Button();
            this.LoadPwads = new System.Windows.Forms.TextBox();
            this.btnLoadPwads = new System.Windows.Forms.Button();
            this.LoadDeh = new System.Windows.Forms.TextBox();
            this.btnClearPwads = new System.Windows.Forms.Button();
            this.current_iwad = new System.Windows.Forms.TextBox();
            this.IWAD_Index = new System.Windows.Forms.TextBox();
            this.cmbMaps6 = new System.Windows.Forms.ComboBox();
            this.cmbMaps7 = new System.Windows.Forms.ComboBox();
            this.txtRecent_Deh = new System.Windows.Forms.TextBox();
            this.txtRecent_Pwads = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.IWAD_SelectedItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Box)).BeginInit();
            this.tabAddons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstIWADS
            // 
            this.lstIWADS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstIWADS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIWADS.FormattingEnabled = true;
            this.lstIWADS.Location = new System.Drawing.Point(16, 19);
            this.lstIWADS.Name = "lstIWADS";
            this.lstIWADS.Size = new System.Drawing.Size(159, 95);
            this.lstIWADS.TabIndex = 173;
            this.lstIWADS.Tag = "";
            this.lstIWADS.SelectedIndexChanged += new System.EventHandler(this.lstIWADS_SelectedIndexChanged);
            this.lstIWADS.MouseEnter += new System.EventHandler(this.lstIWADS_MouseEnter);
            this.lstIWADS.MouseLeave += new System.EventHandler(this.lstIWADS_MouseLeave);
            // 
            // BtnEngineLocation
            // 
            this.BtnEngineLocation.Location = new System.Drawing.Point(12, 8);
            this.BtnEngineLocation.Name = "BtnEngineLocation";
            this.BtnEngineLocation.Size = new System.Drawing.Size(364, 57);
            this.BtnEngineLocation.TabIndex = 171;
            this.BtnEngineLocation.Text = "Add Engine Location";
            this.BtnEngineLocation.UseVisualStyleBackColor = true;
            this.BtnEngineLocation.Click += new System.EventHandler(this.BtnEngineLocation_Click);
            this.BtnEngineLocation.MouseEnter += new System.EventHandler(this.BtnEngineLocation_MouseEnter);
            this.BtnEngineLocation.MouseLeave += new System.EventHandler(this.BtnEngineLocation_MouseLeave);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunch.Location = new System.Drawing.Point(294, 390);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(117, 61);
            this.btnLaunch.TabIndex = 175;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnIWADSLocation
            // 
            this.btnIWADSLocation.Location = new System.Drawing.Point(16, 120);
            this.btnIWADSLocation.Name = "btnIWADSLocation";
            this.btnIWADSLocation.Size = new System.Drawing.Size(159, 29);
            this.btnIWADSLocation.TabIndex = 176;
            this.btnIWADSLocation.Text = "Add IWADs Location";
            this.btnIWADSLocation.UseVisualStyleBackColor = true;
            this.btnIWADSLocation.Click += new System.EventHandler(this.btnIWADSLocation_Click);
            this.btnIWADSLocation.MouseEnter += new System.EventHandler(this.btnIWADSLocation_MouseEnter);
            this.btnIWADSLocation.MouseLeave += new System.EventHandler(this.btnIWADSLocation_MouseLeave);
            // 
            // cmbMonsters
            // 
            this.cmbMonsters.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMonsters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMonsters.FormattingEnabled = true;
            this.cmbMonsters.Items.AddRange(new object[] {
            "Normal",
            "Respawn",
            "No Monsters"});
            this.cmbMonsters.Location = new System.Drawing.Point(18, 434);
            this.cmbMonsters.Name = "cmbMonsters";
            this.cmbMonsters.Size = new System.Drawing.Size(124, 21);
            this.cmbMonsters.TabIndex = 211;
            this.cmbMonsters.SelectedIndexChanged += new System.EventHandler(this.cmbMonsters_SelectedIndexChanged);
            // 
            // cmbGameMods
            // 
            this.cmbGameMods.BackColor = System.Drawing.SystemColors.Control;
            this.cmbGameMods.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbGameMods.FormattingEnabled = true;
            this.cmbGameMods.Items.AddRange(new object[] {
            "Single Player",
            "Deathmatch",
            "Alt-Death",
            "Solo-Net Single Player",
            "Solo-Net Deathmatch",
            "Solo-Net Alt-Death"});
            this.cmbGameMods.Location = new System.Drawing.Point(160, 434);
            this.cmbGameMods.Name = "cmbGameMods";
            this.cmbGameMods.Size = new System.Drawing.Size(128, 21);
            this.cmbGameMods.TabIndex = 212;
            this.cmbGameMods.SelectedIndexChanged += new System.EventHandler(this.cmbGameMods_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 214;
            this.label8.Text = "Game Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 205;
            this.label5.Text = "Level and/or Episode:";
            // 
            // cmbMaps2
            // 
            this.cmbMaps2.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps2.DropDownHeight = 80;
            this.cmbMaps2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMaps2.FormattingEnabled = true;
            this.cmbMaps2.IntegralHeight = false;
            this.cmbMaps2.Items.AddRange(new object[] {
            "E1M1",
            "E1M2",
            "E1M3",
            "E1M4",
            "E1M5",
            "E1M6",
            "E1M7",
            "E1M8",
            "E1M9",
            "E2M1",
            "E2M2",
            "E2M3",
            "E2M4",
            "E2M5",
            "E2M6",
            "E2M7",
            "E2M8",
            "E2M9",
            "E3M1",
            "E3M2",
            "E3M3",
            "E3M4",
            "E3M5",
            "E3M6",
            "E3M7",
            "E3M8",
            "E3M9",
            "E4M1",
            "E4M2",
            "E4M3",
            "E4M4",
            "E4M5",
            "E4M6",
            "E4M7",
            "E4M8",
            "E4M9"});
            this.cmbMaps2.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps2.Name = "cmbMaps2";
            this.cmbMaps2.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps2.TabIndex = 204;
            this.cmbMaps2.Visible = false;
            this.cmbMaps2.SelectedIndexChanged += new System.EventHandler(this.cmbMaps2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 213;
            this.label6.Text = "Monsters:";
            // 
            // cmbMaps3
            // 
            this.cmbMaps3.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps3.FormattingEnabled = true;
            this.cmbMaps3.Items.AddRange(new object[] {
            "E1M1",
            "E1M2",
            "E1M3",
            "E1M4",
            "E1M5",
            "E1M6",
            "E1M7",
            "E1M8",
            "E1M9"});
            this.cmbMaps3.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps3.Name = "cmbMaps3";
            this.cmbMaps3.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps3.TabIndex = 206;
            this.cmbMaps3.Visible = false;
            this.cmbMaps3.SelectedIndexChanged += new System.EventHandler(this.cmbMaps3_SelectedIndexChanged);
            // 
            // cmbMaps4
            // 
            this.cmbMaps4.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps4.FormattingEnabled = true;
            this.cmbMaps4.Items.AddRange(new object[] {
            "MAP01",
            "MAP02",
            "MAP03",
            "MAP04",
            "MAP05",
            "MAP06",
            "MAP07",
            "MAP08",
            "MAP09",
            "MAP10",
            "MAP11",
            "MAP12",
            "MAP13",
            "MAP14",
            "MAP15",
            "MAP16",
            "MAP17",
            "MAP18",
            "MAP19",
            "MAP20",
            "MAP21",
            "MAP22",
            "MAP23",
            "MAP24",
            "MAP25",
            "MAP26",
            "MAP27",
            "MAP28",
            "MAP29",
            "MAP30",
            "MAP31",
            "MAP32"});
            this.cmbMaps4.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps4.Name = "cmbMaps4";
            this.cmbMaps4.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps4.TabIndex = 207;
            this.cmbMaps4.Visible = false;
            this.cmbMaps4.SelectedIndexChanged += new System.EventHandler(this.cmbMaps4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 210;
            this.label3.Text = "Skill:";
            // 
            // cmbMaps5
            // 
            this.cmbMaps5.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps5.FormattingEnabled = true;
            this.cmbMaps5.Items.AddRange(new object[] {
            "MAP01",
            "MAP02",
            "MAP03",
            "MAP04",
            "MAP05",
            "MAP06",
            "MAP07",
            "MAP08",
            "MAP09",
            "MAP10",
            "MAP11",
            "MAP12",
            "MAP13",
            "MAP14",
            "MAP15",
            "MAP16",
            "MAP17",
            "MAP18",
            "MAP19",
            "MAP20",
            "MAP21",
            "MAP22",
            "MAP23",
            "MAP24",
            "MAP25",
            "MAP26",
            "MAP27",
            "MAP28",
            "MAP29",
            "MAP30",
            "MAP31",
            "MAP32"});
            this.cmbMaps5.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps5.Name = "cmbMaps5";
            this.cmbMaps5.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps5.TabIndex = 208;
            this.cmbMaps5.Visible = false;
            this.cmbMaps5.SelectedIndexChanged += new System.EventHandler(this.cmbMaps5_SelectedIndexChanged);
            // 
            // cmbMaps
            // 
            this.cmbMaps.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps.DropDownHeight = 80;
            this.cmbMaps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.IntegralHeight = false;
            this.cmbMaps.Items.AddRange(new object[] {
            "MAP01",
            "MAP02",
            "MAP03",
            "MAP04",
            "MAP05",
            "MAP06",
            "MAP07",
            "MAP08",
            "MAP09",
            "MAP10",
            "MAP11",
            "MAP12",
            "MAP13",
            "MAP14",
            "MAP15",
            "MAP16",
            "MAP17",
            "MAP18",
            "MAP19",
            "MAP20",
            "MAP21",
            "MAP22",
            "MAP23",
            "MAP24",
            "MAP25",
            "MAP26",
            "MAP27",
            "MAP28",
            "MAP29",
            "MAP30",
            "MAP31",
            "MAP32"});
            this.cmbMaps.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps.TabIndex = 203;
            this.cmbMaps.SelectedIndexChanged += new System.EventHandler(this.cmbMaps_SelectedIndexChanged);
            // 
            // cmbSkills
            // 
            this.cmbSkills.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSkills.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbSkills.FormattingEnabled = true;
            this.cmbSkills.Items.AddRange(new object[] {
            "Skill 1",
            "Skill 2",
            "Skill 3",
            "Skill 4",
            "Skill 5"});
            this.cmbSkills.Location = new System.Drawing.Point(160, 390);
            this.cmbSkills.Name = "cmbSkills";
            this.cmbSkills.Size = new System.Drawing.Size(128, 21);
            this.cmbSkills.TabIndex = 209;
            this.cmbSkills.SelectedIndexChanged += new System.EventHandler(this.cmbSkills_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSetup);
            this.tabControl1.Controls.Add(this.tabAddons);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(397, 359);
            this.tabControl1.TabIndex = 218;
            // 
            // tabSetup
            // 
            this.tabSetup.BackColor = System.Drawing.Color.Transparent;
            this.tabSetup.Controls.Add(this.groupBox3);
            this.tabSetup.Controls.Add(this.groupBox2);
            this.tabSetup.Controls.Add(this.chkSaveAdditional);
            this.tabSetup.Controls.Add(this.IWAD_SelectedItem);
            this.tabSetup.Controls.Add(this.BtnEngineLocation);
            this.tabSetup.Controls.Add(this.Logo_Box);
            this.tabSetup.Controls.Add(this.label4);
            this.tabSetup.Controls.Add(this.AdditionalCmds);
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(389, 333);
            this.tabSetup.TabIndex = 0;
            this.tabSetup.Text = "Setup Location";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblMonsters);
            this.groupBox3.Controls.Add(this.lblWarp);
            this.groupBox3.Controls.Add(this.lblGameMode);
            this.groupBox3.Controls.Add(this.lblSkill);
            this.groupBox3.Location = new System.Drawing.Point(189, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 76);
            this.groupBox3.TabIndex = 287;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Parameters";
            // 
            // lblMonsters
            // 
            this.lblMonsters.AutoSize = true;
            this.lblMonsters.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMonsters.Location = new System.Drawing.Point(10, 42);
            this.lblMonsters.Name = "lblMonsters";
            this.lblMonsters.Size = new System.Drawing.Size(130, 13);
            this.lblMonsters.TabIndex = 233;
            this.lblMonsters.Text = "Monsters - None Selected";
            // 
            // lblWarp
            // 
            this.lblWarp.AutoSize = true;
            this.lblWarp.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWarp.Location = new System.Drawing.Point(10, 16);
            this.lblWarp.Name = "lblWarp";
            this.lblWarp.Size = new System.Drawing.Size(113, 13);
            this.lblWarp.TabIndex = 0;
            this.lblWarp.Text = "Level - None Selected";
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGameMode.Location = new System.Drawing.Point(10, 55);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(145, 13);
            this.lblGameMode.TabIndex = 234;
            this.lblGameMode.Text = "Game Mode - None Selected";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSkill.Location = new System.Drawing.Point(10, 29);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(106, 13);
            this.lblSkill.TabIndex = 232;
            this.lblSkill.Text = "Skill - None Selected";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstIWADS);
            this.groupBox2.Controls.Add(this.btnIWADSLocation);
            this.groupBox2.Location = new System.Drawing.Point(189, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 157);
            this.groupBox2.TabIndex = 287;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IWADs";
            // 
            // chkSaveAdditional
            // 
            this.chkSaveAdditional.AutoSize = true;
            this.chkSaveAdditional.Location = new System.Drawing.Point(276, 309);
            this.chkSaveAdditional.Name = "chkSaveAdditional";
            this.chkSaveAdditional.Size = new System.Drawing.Size(100, 17);
            this.chkSaveAdditional.TabIndex = 238;
            this.chkSaveAdditional.Text = "Save Additional";
            this.chkSaveAdditional.UseVisualStyleBackColor = true;
            this.chkSaveAdditional.CheckedChanged += new System.EventHandler(this.chkSaveAdditional_CheckedChanged);
            // 
            // IWAD_SelectedItem
            // 
            this.IWAD_SelectedItem.BackColor = System.Drawing.Color.Transparent;
            this.IWAD_SelectedItem.Controls.Add(this.picGame);
            this.IWAD_SelectedItem.Location = new System.Drawing.Point(15, 71);
            this.IWAD_SelectedItem.Name = "IWAD_SelectedItem";
            this.IWAD_SelectedItem.Size = new System.Drawing.Size(168, 218);
            this.IWAD_SelectedItem.TabIndex = 0;
            this.IWAD_SelectedItem.TabStop = false;
            this.IWAD_SelectedItem.Text = "Selected Game";
            // 
            // picGame
            // 
            this.picGame.BackColor = System.Drawing.Color.DimGray;
            this.picGame.Location = new System.Drawing.Point(16, 19);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(136, 186);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGame.TabIndex = 227;
            this.picGame.TabStop = false;
            // 
            // Logo_Box
            // 
            this.Logo_Box.BackColor = System.Drawing.Color.DimGray;
            this.Logo_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Box.Image = global::Managed_Doom_Launcher.Properties.Resources.MD_Lancher_logo2_1;
            this.Logo_Box.Location = new System.Drawing.Point(15, 8);
            this.Logo_Box.Name = "Logo_Box";
            this.Logo_Box.Size = new System.Drawing.Size(355, 57);
            this.Logo_Box.TabIndex = 178;
            this.Logo_Box.TabStop = false;
            this.Logo_Box.Click += new System.EventHandler(this.Logo_Box_Click);
            this.Logo_Box.MouseEnter += new System.EventHandler(this.Logo_Box_MouseEnter);
            this.Logo_Box.MouseLeave += new System.EventHandler(this.Logo_Box_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 196;
            this.label4.Text = "Additional Parameters:";
            // 
            // AdditionalCmds
            // 
            this.AdditionalCmds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdditionalCmds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionalCmds.Location = new System.Drawing.Point(15, 308);
            this.AdditionalCmds.Name = "AdditionalCmds";
            this.AdditionalCmds.Size = new System.Drawing.Size(255, 20);
            this.AdditionalCmds.TabIndex = 195;
            // 
            // tabAddons
            // 
            this.tabAddons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAddons.Controls.Add(this.current_deh);
            this.tabAddons.Controls.Add(this.current_pwad);
            this.tabAddons.Controls.Add(this.groupBox1);
            this.tabAddons.Controls.Add(this.test);
            this.tabAddons.Controls.Add(this.label13);
            this.tabAddons.Controls.Add(this.label12);
            this.tabAddons.Controls.Add(this.btnLoadDeh);
            this.tabAddons.Controls.Add(this.btnClearDeh);
            this.tabAddons.Controls.Add(this.LoadPwads);
            this.tabAddons.Controls.Add(this.btnLoadPwads);
            this.tabAddons.Controls.Add(this.LoadDeh);
            this.tabAddons.Controls.Add(this.btnClearPwads);
            this.tabAddons.Location = new System.Drawing.Point(4, 22);
            this.tabAddons.Name = "tabAddons";
            this.tabAddons.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddons.Size = new System.Drawing.Size(389, 333);
            this.tabAddons.TabIndex = 1;
            this.tabAddons.Text = "Addons";
            // 
            // current_deh
            // 
            this.current_deh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_deh.Location = new System.Drawing.Point(155, 59);
            this.current_deh.Multiline = true;
            this.current_deh.Name = "current_deh";
            this.current_deh.ReadOnly = true;
            this.current_deh.Size = new System.Drawing.Size(203, 18);
            this.current_deh.TabIndex = 288;
            this.current_deh.Visible = false;
            // 
            // current_pwad
            // 
            this.current_pwad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_pwad.Location = new System.Drawing.Point(155, 0);
            this.current_pwad.Multiline = true;
            this.current_pwad.Name = "current_pwad";
            this.current_pwad.ReadOnly = true;
            this.current_pwad.Size = new System.Drawing.Size(203, 18);
            this.current_pwad.TabIndex = 287;
            this.current_pwad.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkEnableRemoveAll);
            this.groupBox1.Controls.Add(this.btnClearAll_RecentDeh);
            this.groupBox1.Controls.Add(this.btnClearAll_RecentPwads);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lstRecent_Pwads);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnClear_RecentPwads);
            this.groupBox1.Controls.Add(this.lstRecent_Deh);
            this.groupBox1.Controls.Add(this.btnClear_RecentDeh);
            this.groupBox1.Location = new System.Drawing.Point(13, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 205);
            this.groupBox1.TabIndex = 264;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recently Loaded Pwad and Deh files";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // chkEnableRemoveAll
            // 
            this.chkEnableRemoveAll.AutoSize = true;
            this.chkEnableRemoveAll.Location = new System.Drawing.Point(239, 18);
            this.chkEnableRemoveAll.Name = "chkEnableRemoveAll";
            this.chkEnableRemoveAll.Size = new System.Drawing.Size(116, 17);
            this.chkEnableRemoveAll.TabIndex = 270;
            this.chkEnableRemoveAll.Text = "Enable Remove All";
            this.chkEnableRemoveAll.UseVisualStyleBackColor = true;
            this.chkEnableRemoveAll.CheckedChanged += new System.EventHandler(this.chkEnableRemoveAll_CheckedChanged);
            this.chkEnableRemoveAll.MouseEnter += new System.EventHandler(this.chkEnableRemoveAll_MouseEnter);
            this.chkEnableRemoveAll.MouseLeave += new System.EventHandler(this.chkEnableRemoveAll_MouseLeave);
            // 
            // btnClearAll_RecentDeh
            // 
            this.btnClearAll_RecentDeh.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearAll_RecentDeh.Enabled = false;
            this.btnClearAll_RecentDeh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClearAll_RecentDeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll_RecentDeh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearAll_RecentDeh.Location = new System.Drawing.Point(240, 165);
            this.btnClearAll_RecentDeh.Name = "btnClearAll_RecentDeh";
            this.btnClearAll_RecentDeh.Size = new System.Drawing.Size(125, 29);
            this.btnClearAll_RecentDeh.TabIndex = 269;
            this.btnClearAll_RecentDeh.Text = "Remove All";
            this.btnClearAll_RecentDeh.UseVisualStyleBackColor = false;
            this.btnClearAll_RecentDeh.Click += new System.EventHandler(this.btnClearAll_RecentDeh_Click);
            // 
            // btnClearAll_RecentPwads
            // 
            this.btnClearAll_RecentPwads.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearAll_RecentPwads.Enabled = false;
            this.btnClearAll_RecentPwads.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClearAll_RecentPwads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll_RecentPwads.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearAll_RecentPwads.Location = new System.Drawing.Point(239, 80);
            this.btnClearAll_RecentPwads.Name = "btnClearAll_RecentPwads";
            this.btnClearAll_RecentPwads.Size = new System.Drawing.Size(125, 28);
            this.btnClearAll_RecentPwads.TabIndex = 268;
            this.btnClearAll_RecentPwads.Text = "Remove All";
            this.btnClearAll_RecentPwads.UseVisualStyleBackColor = false;
            this.btnClearAll_RecentPwads.Click += new System.EventHandler(this.btnClearAll_RecentPwads_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 266;
            this.label10.Text = "Recently loaded Pwads:";
            // 
            // lstRecent_Pwads
            // 
            this.lstRecent_Pwads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstRecent_Pwads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRecent_Pwads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecent_Pwads.FormattingEnabled = true;
            this.lstRecent_Pwads.HorizontalScrollbar = true;
            this.lstRecent_Pwads.Location = new System.Drawing.Point(8, 41);
            this.lstRecent_Pwads.Name = "lstRecent_Pwads";
            this.lstRecent_Pwads.Size = new System.Drawing.Size(225, 67);
            this.lstRecent_Pwads.Sorted = true;
            this.lstRecent_Pwads.TabIndex = 261;
            this.lstRecent_Pwads.Tag = "";
            this.lstRecent_Pwads.SelectedIndexChanged += new System.EventHandler(this.lstRecent_Pwads_SelectedIndexChanged);
            this.lstRecent_Pwads.MouseEnter += new System.EventHandler(this.lstRecent_Pwads_MouseEnter);
            this.lstRecent_Pwads.MouseLeave += new System.EventHandler(this.lstRecent_Pwads_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 267;
            this.label11.Text = "Recently loaded Deh:";
            // 
            // btnClear_RecentPwads
            // 
            this.btnClear_RecentPwads.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear_RecentPwads.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear_RecentPwads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_RecentPwads.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear_RecentPwads.Location = new System.Drawing.Point(239, 41);
            this.btnClear_RecentPwads.Name = "btnClear_RecentPwads";
            this.btnClear_RecentPwads.Size = new System.Drawing.Size(125, 33);
            this.btnClear_RecentPwads.TabIndex = 262;
            this.btnClear_RecentPwads.Text = "Remove Selected";
            this.btnClear_RecentPwads.UseVisualStyleBackColor = false;
            this.btnClear_RecentPwads.Click += new System.EventHandler(this.btnClear_RecentPwads_Click);
            // 
            // lstRecent_Deh
            // 
            this.lstRecent_Deh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstRecent_Deh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRecent_Deh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecent_Deh.FormattingEnabled = true;
            this.lstRecent_Deh.HorizontalScrollbar = true;
            this.lstRecent_Deh.Location = new System.Drawing.Point(9, 127);
            this.lstRecent_Deh.Name = "lstRecent_Deh";
            this.lstRecent_Deh.Size = new System.Drawing.Size(225, 67);
            this.lstRecent_Deh.TabIndex = 263;
            this.lstRecent_Deh.Tag = "";
            this.lstRecent_Deh.SelectedIndexChanged += new System.EventHandler(this.lstRecent_Deh_SelectedIndexChanged);
            this.lstRecent_Deh.MouseEnter += new System.EventHandler(this.lstRecent_Deh_MouseEnter);
            this.lstRecent_Deh.MouseLeave += new System.EventHandler(this.lstRecent_Deh_MouseLeave);
            // 
            // btnClear_RecentDeh
            // 
            this.btnClear_RecentDeh.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear_RecentDeh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear_RecentDeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear_RecentDeh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear_RecentDeh.Location = new System.Drawing.Point(240, 127);
            this.btnClear_RecentDeh.Name = "btnClear_RecentDeh";
            this.btnClear_RecentDeh.Size = new System.Drawing.Size(125, 32);
            this.btnClear_RecentDeh.TabIndex = 264;
            this.btnClear_RecentDeh.Text = "Remove Selected";
            this.btnClear_RecentDeh.UseVisualStyleBackColor = false;
            this.btnClear_RecentDeh.Click += new System.EventHandler(this.btnClear_RecentDeh_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(221, 143);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(13, 13);
            this.test.TabIndex = 270;
            this.test.Text = "..";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 269;
            this.label13.Text = "Currently loaded Deh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 268;
            this.label12.Text = "Currently loaded Pwads:";
            // 
            // btnLoadDeh
            // 
            this.btnLoadDeh.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadDeh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoadDeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDeh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadDeh.Location = new System.Drawing.Point(277, 81);
            this.btnLoadDeh.Name = "btnLoadDeh";
            this.btnLoadDeh.Size = new System.Drawing.Size(102, 35);
            this.btnLoadDeh.TabIndex = 196;
            this.btnLoadDeh.Text = "Load Deh";
            this.btnLoadDeh.UseVisualStyleBackColor = false;
            this.btnLoadDeh.Click += new System.EventHandler(this.btnLoadDeh_Click);
            this.btnLoadDeh.MouseEnter += new System.EventHandler(this.btnLoadDeh_MouseEnter);
            this.btnLoadDeh.MouseLeave += new System.EventHandler(this.btnLoadDeh_MouseLeave);
            // 
            // btnClearDeh
            // 
            this.btnClearDeh.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearDeh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClearDeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDeh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearDeh.Location = new System.Drawing.Point(252, 81);
            this.btnClearDeh.Name = "btnClearDeh";
            this.btnClearDeh.Size = new System.Drawing.Size(19, 35);
            this.btnClearDeh.TabIndex = 195;
            this.btnClearDeh.Text = "X";
            this.btnClearDeh.UseVisualStyleBackColor = false;
            this.btnClearDeh.Click += new System.EventHandler(this.btnClearDeh_Click);
            // 
            // LoadPwads
            // 
            this.LoadPwads.AllowDrop = true;
            this.LoadPwads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadPwads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadPwads.Location = new System.Drawing.Point(12, 19);
            this.LoadPwads.Multiline = true;
            this.LoadPwads.Name = "LoadPwads";
            this.LoadPwads.ReadOnly = true;
            this.LoadPwads.Size = new System.Drawing.Size(233, 34);
            this.LoadPwads.TabIndex = 194;
            this.LoadPwads.DragDrop += new System.Windows.Forms.DragEventHandler(this.LoadPwads_DragDrop);
            this.LoadPwads.DragEnter += new System.Windows.Forms.DragEventHandler(this.LoadPwads_DragEnter);
            this.LoadPwads.MouseEnter += new System.EventHandler(this.LoadPwads_MouseEnter);
            this.LoadPwads.MouseLeave += new System.EventHandler(this.LoadPwads_MouseLeave);
            // 
            // btnLoadPwads
            // 
            this.btnLoadPwads.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadPwads.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLoadPwads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPwads.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadPwads.Location = new System.Drawing.Point(276, 19);
            this.btnLoadPwads.Name = "btnLoadPwads";
            this.btnLoadPwads.Size = new System.Drawing.Size(102, 34);
            this.btnLoadPwads.TabIndex = 193;
            this.btnLoadPwads.Text = "Load Pwad";
            this.btnLoadPwads.UseVisualStyleBackColor = false;
            this.btnLoadPwads.Click += new System.EventHandler(this.btnLoadPwads_Click);
            this.btnLoadPwads.MouseEnter += new System.EventHandler(this.btnLoadPwads_MouseEnter);
            this.btnLoadPwads.MouseLeave += new System.EventHandler(this.btnLoadPwads_MouseLeave);
            // 
            // LoadDeh
            // 
            this.LoadDeh.AllowDrop = true;
            this.LoadDeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadDeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadDeh.Location = new System.Drawing.Point(13, 81);
            this.LoadDeh.Multiline = true;
            this.LoadDeh.Name = "LoadDeh";
            this.LoadDeh.ReadOnly = true;
            this.LoadDeh.Size = new System.Drawing.Size(233, 35);
            this.LoadDeh.TabIndex = 191;
            this.LoadDeh.DragDrop += new System.Windows.Forms.DragEventHandler(this.LoadDeh_DragDrop);
            this.LoadDeh.DragEnter += new System.Windows.Forms.DragEventHandler(this.LoadDeh_DragEnter);
            this.LoadDeh.MouseEnter += new System.EventHandler(this.LoadDeh_MouseEnter);
            this.LoadDeh.MouseLeave += new System.EventHandler(this.LoadDeh_MouseLeave);
            // 
            // btnClearPwads
            // 
            this.btnClearPwads.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearPwads.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClearPwads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPwads.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearPwads.Location = new System.Drawing.Point(251, 19);
            this.btnClearPwads.Name = "btnClearPwads";
            this.btnClearPwads.Size = new System.Drawing.Size(19, 34);
            this.btnClearPwads.TabIndex = 192;
            this.btnClearPwads.Text = "X";
            this.btnClearPwads.UseVisualStyleBackColor = false;
            this.btnClearPwads.Click += new System.EventHandler(this.btnClearPwads_Click);
            // 
            // current_iwad
            // 
            this.current_iwad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_iwad.Location = new System.Drawing.Point(316, -1);
            this.current_iwad.Multiline = true;
            this.current_iwad.Name = "current_iwad";
            this.current_iwad.ReadOnly = true;
            this.current_iwad.Size = new System.Drawing.Size(18, 18);
            this.current_iwad.TabIndex = 223;
            this.current_iwad.Visible = false;
            // 
            // IWAD_Index
            // 
            this.IWAD_Index.Location = new System.Drawing.Point(340, -3);
            this.IWAD_Index.Name = "IWAD_Index";
            this.IWAD_Index.Size = new System.Drawing.Size(20, 20);
            this.IWAD_Index.TabIndex = 220;
            this.IWAD_Index.Visible = false;
            // 
            // cmbMaps6
            // 
            this.cmbMaps6.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps6.DropDownHeight = 80;
            this.cmbMaps6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMaps6.FormattingEnabled = true;
            this.cmbMaps6.IntegralHeight = false;
            this.cmbMaps6.Items.AddRange(new object[] {
            "E1M1",
            "E1M2",
            "E1M3",
            "E1M4",
            "E1M5",
            "E1M6",
            "E1M7",
            "E1M8",
            "E1M9",
            "E2M1",
            "E2M2",
            "E2M3",
            "E2M4",
            "E2M5",
            "E2M6",
            "E2M7",
            "E2M8",
            "E2M9",
            "E3M1",
            "E3M2",
            "E3M3",
            "E3M4",
            "E3M5",
            "E3M6",
            "E3M7",
            "E3M8",
            "E3M9",
            "E4M1",
            "E4M2",
            "E4M3",
            "E4M4",
            "E4M5",
            "E4M6",
            "E4M7",
            "E4M8",
            "E4M9"});
            this.cmbMaps6.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps6.Name = "cmbMaps6";
            this.cmbMaps6.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps6.TabIndex = 221;
            this.cmbMaps6.Visible = false;
            this.cmbMaps6.SelectedIndexChanged += new System.EventHandler(this.cmbMaps6_SelectedIndexChanged);
            // 
            // cmbMaps7
            // 
            this.cmbMaps7.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaps7.FormattingEnabled = true;
            this.cmbMaps7.Items.AddRange(new object[] {
            "MAP01",
            "MAP02",
            "MAP03",
            "MAP04",
            "MAP05",
            "MAP06",
            "MAP07",
            "MAP08",
            "MAP09",
            "MAP10",
            "MAP11",
            "MAP12",
            "MAP13",
            "MAP14",
            "MAP15",
            "MAP16",
            "MAP17",
            "MAP18",
            "MAP19",
            "MAP20",
            "MAP21",
            "MAP22",
            "MAP23",
            "MAP24",
            "MAP25",
            "MAP26",
            "MAP27",
            "MAP28",
            "MAP29",
            "MAP30",
            "MAP31",
            "MAP32"});
            this.cmbMaps7.Location = new System.Drawing.Point(17, 390);
            this.cmbMaps7.Name = "cmbMaps7";
            this.cmbMaps7.Size = new System.Drawing.Size(125, 21);
            this.cmbMaps7.TabIndex = 222;
            this.cmbMaps7.Visible = false;
            this.cmbMaps7.SelectedIndexChanged += new System.EventHandler(this.cmbMaps7_SelectedIndexChanged);
            // 
            // txtRecent_Deh
            // 
            this.txtRecent_Deh.Location = new System.Drawing.Point(395, -1);
            this.txtRecent_Deh.Multiline = true;
            this.txtRecent_Deh.Name = "txtRecent_Deh";
            this.txtRecent_Deh.Size = new System.Drawing.Size(25, 18);
            this.txtRecent_Deh.TabIndex = 263;
            this.txtRecent_Deh.Visible = false;
            // 
            // txtRecent_Pwads
            // 
            this.txtRecent_Pwads.Location = new System.Drawing.Point(366, -1);
            this.txtRecent_Pwads.Multiline = true;
            this.txtRecent_Pwads.Name = "txtRecent_Pwads";
            this.txtRecent_Pwads.Size = new System.Drawing.Size(23, 18);
            this.txtRecent_Pwads.TabIndex = 262;
            this.txtRecent_Pwads.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 286;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusInfo
            // 
            this.StatusInfo.BackColor = System.Drawing.Color.White;
            this.StatusInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusInfo.Name = "StatusInfo";
            this.StatusInfo.Size = new System.Drawing.Size(16, 17);
            this.StatusInfo.Text = "...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(425, 483);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtRecent_Deh);
            this.Controls.Add(this.txtRecent_Pwads);
            this.Controls.Add(this.cmbMaps7);
            this.Controls.Add(this.cmbMaps6);
            this.Controls.Add(this.current_iwad);
            this.Controls.Add(this.IWAD_Index);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmbMonsters);
            this.Controls.Add(this.cmbGameMods);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMaps2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMaps3);
            this.Controls.Add(this.cmbMaps4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaps5);
            this.Controls.Add(this.cmbMaps);
            this.Controls.Add(this.cmbSkills);
            this.Controls.Add(this.btnLaunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managed Doom Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.IWAD_SelectedItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Box)).EndInit();
            this.tabAddons.ResumeLayout(false);
            this.tabAddons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIWADS;
        private System.Windows.Forms.Button BtnEngineLocation;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnIWADSLocation;
        private System.Windows.Forms.TextBox New_IWAD_Path;
        private System.Windows.Forms.ComboBox cmbMonsters;
        private System.Windows.Forms.ComboBox cmbGameMods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaps2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaps3;
        private System.Windows.Forms.ComboBox cmbMaps4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaps5;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.ComboBox cmbSkills;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabAddons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdditionalCmds;
        private System.Windows.Forms.TextBox LoadPwads;
        private System.Windows.Forms.Button btnLoadPwads;
        private System.Windows.Forms.TextBox LoadDeh;
        private System.Windows.Forms.Button btnClearPwads;
        private System.Windows.Forms.PictureBox Logo_Box;
        private System.Windows.Forms.Label lblWarp;
        private System.Windows.Forms.TextBox IWAD_Index;
        private System.Windows.Forms.ComboBox cmbMaps6;
        private System.Windows.Forms.ComboBox cmbMaps7;
        private System.Windows.Forms.TextBox current_iwad;
        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label lblMonsters;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.GroupBox IWAD_SelectedItem;
        private System.Windows.Forms.Button btnClearDeh;
        private System.Windows.Forms.Button btnLoadDeh;
        private System.Windows.Forms.Button btnClear_RecentDeh;
        private System.Windows.Forms.ListBox lstRecent_Deh;
        private System.Windows.Forms.Button btnClear_RecentPwads;
        private System.Windows.Forms.ListBox lstRecent_Pwads;
        private System.Windows.Forms.TextBox txtRecent_Deh;
        private System.Windows.Forms.TextBox txtRecent_Pwads;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearAll_RecentDeh;
        private System.Windows.Forms.Button btnClearAll_RecentPwads;
        private System.Windows.Forms.CheckBox chkEnableRemoveAll;
        private System.Windows.Forms.CheckBox chkSaveAdditional;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusInfo;
        private System.Windows.Forms.TextBox current_pwad;
        private System.Windows.Forms.TextBox current_deh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

