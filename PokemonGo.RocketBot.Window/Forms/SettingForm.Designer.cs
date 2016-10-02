﻿namespace PokemonGo.RocketBot.Window.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.enableAdvSettingCb = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.GoogleApiBox = new System.Windows.Forms.TextBox();
            this.GoogleApiLabel = new System.Windows.Forms.Label();
            this.tbWalkingSpeed = new System.Windows.Forms.TextBox();
            this.TravelSpeedText = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.proxyGb = new System.Windows.Forms.GroupBox();
            this.proxyPortTb = new System.Windows.Forms.TextBox();
            this.proxyUserTb = new System.Windows.Forms.TextBox();
            this.proxyPwTb = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.proxyHostTb = new System.Windows.Forms.TextBox();
            this.useProxyAuthCb = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.useProxyCb = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ResetLocationBtn = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.FindAdressBtn = new System.Windows.Forms.Button();
            this.gMapCtrl = new GMap.NET.WindowsForms.GMapControl();
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.UserPasswordBox = new System.Windows.Forms.TextBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.authTypeLabel = new System.Windows.Forms.Label();
            this.longiLabel = new System.Windows.Forms.Label();
            this.authTypeCb = new System.Windows.Forms.ComboBox();
            this.latLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.tabDevice = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RandomIDBtn = new System.Windows.Forms.Button();
            this.deviceTypeCb = new System.Windows.Forms.ComboBox();
            this.RandomDeviceBtn = new System.Windows.Forms.Button();
            this.FirmwareFingerprintTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.FirmwareTypeTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FirmwareTagsTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FirmwareBrandTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HardwareModelTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HardwareManufacturerTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeviceModelBootTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeviceModelIdentifierTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeviceModelTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DeviceBrandTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AndroidBootloaderTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AndroidBoardNameTb = new System.Windows.Forms.TextBox();
            this.BoardName = new System.Windows.Forms.Label();
            this.DeviceIdTb = new System.Windows.Forms.TextBox();
            this.deviceIdlb = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPokemon = new System.Windows.Forms.TabPage();
            this.tcPokemonDetail = new System.Windows.Forms.TabControl();
            this.tabCatch = new System.Windows.Forms.TabPage();
            this.label47 = new System.Windows.Forms.Label();
            this.cbAutoFavoritePokemon = new System.Windows.Forms.CheckBox();
            this.tbFavoriteMinIvPercentage = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbUseBerriesOperator = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.tbUseBerriesMinCp = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.tbUseBerriesMinIv = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tbUseBerriesBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.tbMaxPokeballsPerPokemon = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUseMasterBallBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.tbUseGreatBallAboveCp = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUseUltraBallBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.tbUseUltraBallAboveCp = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUseGreatBallBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.tbUseMasterBallAboveCp = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUseUltraBallAboveIv = new System.Windows.Forms.TextBox();
            this.tbUseGreatBallAboveIv = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbIgnoreAll = new System.Windows.Forms.CheckBox();
            this.clbIgnore = new System.Windows.Forms.CheckedListBox();
            this.tBMaxBerriesToUsePerPokemon = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbUseEggIncubators = new System.Windows.Forms.CheckBox();
            this.cbCatchPoke = new System.Windows.Forms.CheckBox();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNotTransferAll = new System.Windows.Forms.CheckBox();
            this.clbTransfer = new System.Windows.Forms.CheckedListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbUseKeepMinLvl = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbKeepMinLvl = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbTransferDuplicatePokemonOnCapture = new System.Windows.Forms.CheckBox();
            this.cbTransferDuplicatePokemon = new System.Windows.Forms.CheckBox();
            this.cbTransferWeakPokemon = new System.Windows.Forms.CheckBox();
            this.tbKeepMinDuplicatePokemon = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbPrioritizeIvOverCp = new System.Windows.Forms.CheckBox();
            this.tbKeepMinIV = new System.Windows.Forms.TextBox();
            this.cbKeepMinOperator = new System.Windows.Forms.ComboBox();
            this.tbKeepMinCp = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tabPowerUp = new System.Windows.Forms.TabPage();
            this.cbPowerUpFav = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbPowerUpMinIV = new System.Windows.Forms.TextBox();
            this.cbPowerUpCondiction = new System.Windows.Forms.ComboBox();
            this.tbPowerUpMinCP = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cbPowerUpMinStarDust = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbPowerUpType = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPowerUpAll = new System.Windows.Forms.CheckBox();
            this.clbPowerUp = new System.Windows.Forms.CheckedListBox();
            this.cbAutoPowerUp = new System.Windows.Forms.CheckBox();
            this.tabEvo = new System.Windows.Forms.TabPage();
            this.label53 = new System.Windows.Forms.Label();
            this.tbUseLuckyEggsMinPokemonAmount = new System.Windows.Forms.TextBox();
            this.cbUseLuckyEggsWhileEvolving = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbEvoAboveIV = new System.Windows.Forms.TextBox();
            this.cbEvoAllAboveIV = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbEvolveAllPokemonWithEnoughCandy = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbEvolveKeptPokemonsAtStorageUsagePercentage = new System.Windows.Forms.TextBox();
            this.cbKeepPokemonsThatCanEvolve = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEvolveAll = new System.Windows.Forms.CheckBox();
            this.clbEvolve = new System.Windows.Forms.CheckedListBox();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbVerboseRecycling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRecycleInventoryAtUsagePercentage = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfPokeballsToKeep = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfPotionsToKeep = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfRevivesToKeep = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfBerriesToKeep = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbUseIncenseConstantly = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbUseLuckyEggConstantly = new System.Windows.Forms.CheckBox();
            this.tabAdvSetting = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cbEnableHumanizedThrows = new System.Windows.Forms.CheckBox();
            this.tbForceExcellentThrowOverCp = new System.Windows.Forms.TextBox();
            this.tbForceGreatThrowOverCp = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.tbForceExcellentThrowOverIv = new System.Windows.Forms.TextBox();
            this.tbNiceThrowChance = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.tbForceGreatThrowOverIv = new System.Windows.Forms.TextBox();
            this.tbGreatThrowChance = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tbCurveThrowChance = new System.Windows.Forms.TextBox();
            this.tbExcellentThrowChance = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cbRandomizeRecycle = new System.Windows.Forms.CheckBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tbRandomRecycleValue = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.cbShowWalkingSpeed = new System.Windows.Forms.CheckBox();
            this.cbUseWalkingSpeedVariant = new System.Windows.Forms.CheckBox();
            this.cbDisableHumanWalking = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.tbWalkingSpeedVariantInKilometerPerHour = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tbMaxSpawnLocationOffset = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tbMaxTravelDistanceInMeters = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tbDelayBetweenRecycle = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.tbDelayBetweenPlayerActions = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tbDelayBetweenPokemonCatch = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.proxyGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tabDevice.SuspendLayout();
            this.tabPokemon.SuspendLayout();
            this.tcPokemonDetail.SuspendLayout();
            this.tabCatch.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPowerUp.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabEvo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabAdvSetting.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.SuspendLayout();
            // 
            // enableAdvSettingCb
            // 
            this.enableAdvSettingCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enableAdvSettingCb.AutoSize = true;
            this.enableAdvSettingCb.Location = new System.Drawing.Point(752, 513);
            this.enableAdvSettingCb.Name = "enableAdvSettingCb";
            this.enableAdvSettingCb.Size = new System.Drawing.Size(162, 19);
            this.enableAdvSettingCb.TabIndex = 32;
            this.enableAdvSettingCb.Text = "Enable Advanced Settings";
            this.enableAdvSettingCb.UseVisualStyleBackColor = true;
            this.enableAdvSettingCb.Click += new System.EventHandler(this.enableAdvSettingCb_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(810, 540);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 32);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabAuth);
            this.tabControl.Controls.Add(this.tabDevice);
            this.tabControl.Controls.Add(this.tabPokemon);
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.Controls.Add(this.tabAdvSetting);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(928, 507);
            this.tabControl.TabIndex = 30;
            // 
            // tabAuth
            // 
            this.tabAuth.BackColor = System.Drawing.SystemColors.Control;
            this.tabAuth.Controls.Add(this.GoogleApiBox);
            this.tabAuth.Controls.Add(this.GoogleApiLabel);
            this.tabAuth.Controls.Add(this.tbWalkingSpeed);
            this.tabAuth.Controls.Add(this.TravelSpeedText);
            this.tabAuth.Controls.Add(this.cbLanguage);
            this.tabAuth.Controls.Add(this.label26);
            this.tabAuth.Controls.Add(this.proxyGb);
            this.tabAuth.Controls.Add(this.ResetLocationBtn);
            this.tabAuth.Controls.Add(this.trackBar);
            this.tabAuth.Controls.Add(this.AdressBox);
            this.tabAuth.Controls.Add(this.FindAdressBtn);
            this.tabAuth.Controls.Add(this.gMapCtrl);
            this.tabAuth.Controls.Add(this.UserLoginBox);
            this.tabAuth.Controls.Add(this.UserPasswordBox);
            this.tabAuth.Controls.Add(this.tbLatitude);
            this.tabAuth.Controls.Add(this.tbLongitude);
            this.tabAuth.Controls.Add(this.authTypeLabel);
            this.tabAuth.Controls.Add(this.longiLabel);
            this.tabAuth.Controls.Add(this.authTypeCb);
            this.tabAuth.Controls.Add(this.latLabel);
            this.tabAuth.Controls.Add(this.UserLabel);
            this.tabAuth.Controls.Add(this.PasswordLabel);
            this.tabAuth.Location = new System.Drawing.Point(4, 24);
            this.tabAuth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAuth.Size = new System.Drawing.Size(920, 479);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "Auth";
            // 
            // GoogleApiBox
            // 
            this.GoogleApiBox.Location = new System.Drawing.Point(140, 142);
            this.GoogleApiBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GoogleApiBox.Name = "GoogleApiBox";
            this.GoogleApiBox.Size = new System.Drawing.Size(184, 23);
            this.GoogleApiBox.TabIndex = 33;
            // 
            // GoogleApiLabel
            // 
            this.GoogleApiLabel.AutoSize = true;
            this.GoogleApiLabel.Location = new System.Drawing.Point(6, 144);
            this.GoogleApiLabel.Name = "GoogleApiLabel";
            this.GoogleApiLabel.Size = new System.Drawing.Size(91, 15);
            this.GoogleApiLabel.TabIndex = 32;
            this.GoogleApiLabel.Text = "Google API Key:";
            // 
            // tbWalkingSpeed
            // 
            this.tbWalkingSpeed.Location = new System.Drawing.Point(140, 241);
            this.tbWalkingSpeed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbWalkingSpeed.Name = "tbWalkingSpeed";
            this.tbWalkingSpeed.Size = new System.Drawing.Size(184, 23);
            this.tbWalkingSpeed.TabIndex = 30;
            // 
            // TravelSpeedText
            // 
            this.TravelSpeedText.AutoSize = true;
            this.TravelSpeedText.Location = new System.Drawing.Point(6, 244);
            this.TravelSpeedText.Name = "TravelSpeedText";
            this.TravelSpeedText.Size = new System.Drawing.Size(131, 15);
            this.TravelSpeedText.TabIndex = 31;
            this.TravelSpeedText.Text = "Walking Speed (KM/H):";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Google",
            "PTC"});
            this.cbLanguage.Location = new System.Drawing.Point(140, 10);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(184, 23);
            this.cbLanguage.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 15);
            this.label26.TabIndex = 28;
            this.label26.Text = "Language:";
            // 
            // proxyGb
            // 
            this.proxyGb.Controls.Add(this.proxyPortTb);
            this.proxyGb.Controls.Add(this.proxyUserTb);
            this.proxyGb.Controls.Add(this.proxyPwTb);
            this.proxyGb.Controls.Add(this.label24);
            this.proxyGb.Controls.Add(this.label25);
            this.proxyGb.Controls.Add(this.proxyHostTb);
            this.proxyGb.Controls.Add(this.useProxyAuthCb);
            this.proxyGb.Controls.Add(this.label19);
            this.proxyGb.Controls.Add(this.useProxyCb);
            this.proxyGb.Controls.Add(this.label23);
            this.proxyGb.Location = new System.Drawing.Point(9, 272);
            this.proxyGb.Name = "proxyGb";
            this.proxyGb.Size = new System.Drawing.Size(315, 195);
            this.proxyGb.TabIndex = 27;
            this.proxyGb.TabStop = false;
            this.proxyGb.Text = "Proxy Setting";
            this.proxyGb.Visible = false;
            // 
            // proxyPortTb
            // 
            this.proxyPortTb.Location = new System.Drawing.Point(131, 76);
            this.proxyPortTb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.proxyPortTb.Name = "proxyPortTb";
            this.proxyPortTb.Size = new System.Drawing.Size(172, 23);
            this.proxyPortTb.TabIndex = 36;
            // 
            // proxyUserTb
            // 
            this.proxyUserTb.Location = new System.Drawing.Point(131, 132);
            this.proxyUserTb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.proxyUserTb.Name = "proxyUserTb";
            this.proxyUserTb.Size = new System.Drawing.Size(172, 23);
            this.proxyUserTb.TabIndex = 34;
            // 
            // proxyPwTb
            // 
            this.proxyPwTb.Location = new System.Drawing.Point(131, 163);
            this.proxyPwTb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.proxyPwTb.Name = "proxyPwTb";
            this.proxyPwTb.PasswordChar = '*';
            this.proxyPwTb.Size = new System.Drawing.Size(172, 23);
            this.proxyPwTb.TabIndex = 35;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 32;
            this.label24.Text = "Username:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 166);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 15);
            this.label25.TabIndex = 33;
            this.label25.Text = "Password:";
            // 
            // proxyHostTb
            // 
            this.proxyHostTb.Location = new System.Drawing.Point(131, 45);
            this.proxyHostTb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.proxyHostTb.Name = "proxyHostTb";
            this.proxyHostTb.Size = new System.Drawing.Size(172, 23);
            this.proxyHostTb.TabIndex = 30;
            // 
            // useProxyAuthCb
            // 
            this.useProxyAuthCb.AutoSize = true;
            this.useProxyAuthCb.Location = new System.Drawing.Point(6, 105);
            this.useProxyAuthCb.Name = "useProxyAuthCb";
            this.useProxyAuthCb.Size = new System.Drawing.Size(159, 19);
            this.useProxyAuthCb.TabIndex = 29;
            this.useProxyAuthCb.Text = "Use Proxy Authentication";
            this.useProxyAuthCb.UseVisualStyleBackColor = true;
            this.useProxyAuthCb.CheckedChanged += new System.EventHandler(this.useProxyAuthCb_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 28;
            this.label19.Text = "Host:";
            // 
            // useProxyCb
            // 
            this.useProxyCb.AutoSize = true;
            this.useProxyCb.Location = new System.Drawing.Point(6, 22);
            this.useProxyCb.Name = "useProxyCb";
            this.useProxyCb.Size = new System.Drawing.Size(77, 19);
            this.useProxyCb.TabIndex = 30;
            this.useProxyCb.Text = "Use Proxy\r\n";
            this.useProxyCb.UseVisualStyleBackColor = true;
            this.useProxyCb.CheckedChanged += new System.EventHandler(this.useProxyCb_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 15);
            this.label23.TabIndex = 29;
            this.label23.Text = "Port:";
            // 
            // ResetLocationBtn
            // 
            this.ResetLocationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetLocationBtn.Location = new System.Drawing.Point(802, 445);
            this.ResetLocationBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ResetLocationBtn.Name = "ResetLocationBtn";
            this.ResetLocationBtn.Size = new System.Drawing.Size(110, 25);
            this.ResetLocationBtn.TabIndex = 26;
            this.ResetLocationBtn.Text = "Reset Location";
            this.ResetLocationBtn.UseVisualStyleBackColor = true;
            this.ResetLocationBtn.Click += new System.EventHandler(this.ResetLocationBtn_Click);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.BackColor = System.Drawing.SystemColors.Info;
            this.trackBar.Location = new System.Drawing.Point(867, 5);
            this.trackBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.trackBar.Maximum = 18;
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 150);
            this.trackBar.TabIndex = 25;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Value = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // AdressBox
            // 
            this.AdressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressBox.ForeColor = System.Drawing.Color.Gray;
            this.AdressBox.Location = new System.Drawing.Point(330, 445);
            this.AdressBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(350, 25);
            this.AdressBox.TabIndex = 25;
            this.AdressBox.Text = "Enter an address or a coordinate";
            this.AdressBox.Enter += new System.EventHandler(this.AdressBox_Enter);
            this.AdressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdressBox_KeyPress);
            this.AdressBox.Leave += new System.EventHandler(this.AdressBox_Leave);
            // 
            // FindAdressBtn
            // 
            this.FindAdressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindAdressBtn.Location = new System.Drawing.Point(686, 445);
            this.FindAdressBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FindAdressBtn.Name = "FindAdressBtn";
            this.FindAdressBtn.Size = new System.Drawing.Size(110, 25);
            this.FindAdressBtn.TabIndex = 25;
            this.FindAdressBtn.Text = "Find Location";
            this.FindAdressBtn.UseVisualStyleBackColor = true;
            this.FindAdressBtn.Click += new System.EventHandler(this.FindAdressBtn_Click);
            // 
            // gMapCtrl
            // 
            this.gMapCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapCtrl.BackColor = System.Drawing.SystemColors.Info;
            this.gMapCtrl.Bearing = 0F;
            this.gMapCtrl.CanDragMap = true;
            this.gMapCtrl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapCtrl.GrayScaleMode = false;
            this.gMapCtrl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapCtrl.LevelsKeepInMemmory = 5;
            this.gMapCtrl.Location = new System.Drawing.Point(330, 5);
            this.gMapCtrl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gMapCtrl.MarkersEnabled = true;
            this.gMapCtrl.MaxZoom = 18;
            this.gMapCtrl.MinZoom = 0;
            this.gMapCtrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapCtrl.Name = "gMapCtrl";
            this.gMapCtrl.NegativeMode = false;
            this.gMapCtrl.PolygonsEnabled = true;
            this.gMapCtrl.RetryLoadTile = 0;
            this.gMapCtrl.RoutesEnabled = true;
            this.gMapCtrl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapCtrl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapCtrl.ShowTileGridLines = false;
            this.gMapCtrl.Size = new System.Drawing.Size(582, 430);
            this.gMapCtrl.TabIndex = 22;
            this.gMapCtrl.Zoom = 0D;
            this.gMapCtrl.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapCtrl_OnMapZoomChanged);
            this.gMapCtrl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapCtrl_MouseClick);
            this.gMapCtrl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapCtrl_MouseUp);
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.Location = new System.Drawing.Point(140, 76);
            this.UserLoginBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UserLoginBox.Name = "UserLoginBox";
            this.UserLoginBox.Size = new System.Drawing.Size(184, 23);
            this.UserLoginBox.TabIndex = 11;
            // 
            // UserPasswordBox
            // 
            this.UserPasswordBox.Location = new System.Drawing.Point(140, 109);
            this.UserPasswordBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UserPasswordBox.Name = "UserPasswordBox";
            this.UserPasswordBox.PasswordChar = '*';
            this.UserPasswordBox.Size = new System.Drawing.Size(184, 23);
            this.UserPasswordBox.TabIndex = 12;
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(140, 175);
            this.tbLatitude.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(184, 23);
            this.tbLatitude.TabIndex = 13;
            this.tbLatitude.Leave += new System.EventHandler(this.latitudeText_Leave);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(140, 208);
            this.tbLongitude.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(184, 23);
            this.tbLongitude.TabIndex = 14;
            this.tbLongitude.Leave += new System.EventHandler(this.longitudeText_Leave);
            // 
            // authTypeLabel
            // 
            this.authTypeLabel.AutoSize = true;
            this.authTypeLabel.Location = new System.Drawing.Point(6, 45);
            this.authTypeLabel.Name = "authTypeLabel";
            this.authTypeLabel.Size = new System.Drawing.Size(68, 15);
            this.authTypeLabel.TabIndex = 0;
            this.authTypeLabel.Text = "Login Type:";
            // 
            // longiLabel
            // 
            this.longiLabel.AutoSize = true;
            this.longiLabel.Location = new System.Drawing.Point(6, 210);
            this.longiLabel.Name = "longiLabel";
            this.longiLabel.Size = new System.Drawing.Size(64, 15);
            this.longiLabel.TabIndex = 5;
            this.longiLabel.Text = "Longitude:";
            // 
            // authTypeCb
            // 
            this.authTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authTypeCb.FormattingEnabled = true;
            this.authTypeCb.Items.AddRange(new object[] {
            "Google",
            "PTC"});
            this.authTypeCb.Location = new System.Drawing.Point(140, 43);
            this.authTypeCb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.authTypeCb.Name = "authTypeCb";
            this.authTypeCb.Size = new System.Drawing.Size(184, 23);
            this.authTypeCb.TabIndex = 1;
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(6, 177);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(53, 15);
            this.latLabel.TabIndex = 4;
            this.latLabel.Text = "Latitude:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(6, 78);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(63, 15);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 111);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // tabDevice
            // 
            this.tabDevice.Controls.Add(this.label22);
            this.tabDevice.Controls.Add(this.label20);
            this.tabDevice.Controls.Add(this.label21);
            this.tabDevice.Controls.Add(this.RandomIDBtn);
            this.tabDevice.Controls.Add(this.deviceTypeCb);
            this.tabDevice.Controls.Add(this.RandomDeviceBtn);
            this.tabDevice.Controls.Add(this.FirmwareFingerprintTb);
            this.tabDevice.Controls.Add(this.label14);
            this.tabDevice.Controls.Add(this.FirmwareTypeTb);
            this.tabDevice.Controls.Add(this.label13);
            this.tabDevice.Controls.Add(this.FirmwareTagsTb);
            this.tabDevice.Controls.Add(this.label12);
            this.tabDevice.Controls.Add(this.FirmwareBrandTb);
            this.tabDevice.Controls.Add(this.label11);
            this.tabDevice.Controls.Add(this.HardwareModelTb);
            this.tabDevice.Controls.Add(this.label10);
            this.tabDevice.Controls.Add(this.HardwareManufacturerTb);
            this.tabDevice.Controls.Add(this.label9);
            this.tabDevice.Controls.Add(this.DeviceModelBootTb);
            this.tabDevice.Controls.Add(this.label8);
            this.tabDevice.Controls.Add(this.DeviceModelIdentifierTb);
            this.tabDevice.Controls.Add(this.label7);
            this.tabDevice.Controls.Add(this.DeviceModelTb);
            this.tabDevice.Controls.Add(this.label15);
            this.tabDevice.Controls.Add(this.DeviceBrandTb);
            this.tabDevice.Controls.Add(this.label16);
            this.tabDevice.Controls.Add(this.AndroidBootloaderTb);
            this.tabDevice.Controls.Add(this.label17);
            this.tabDevice.Controls.Add(this.AndroidBoardNameTb);
            this.tabDevice.Controls.Add(this.BoardName);
            this.tabDevice.Controls.Add(this.DeviceIdTb);
            this.tabDevice.Controls.Add(this.deviceIdlb);
            this.tabDevice.Controls.Add(this.label18);
            this.tabDevice.Location = new System.Drawing.Point(4, 24);
            this.tabDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.Size = new System.Drawing.Size(920, 479);
            this.tabDevice.TabIndex = 0;
            this.tabDevice.Text = "Device";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label22.Location = new System.Drawing.Point(672, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(227, 60);
            this.label22.TabIndex = 69;
            this.label22.Text = "This setting change what the server\r\nthink you are using to play Pokémon GO. \r\nIt" +
    "s a good idea to change your device to \r\nwhat phone you are using to prevent ban" +
    ".";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(475, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 20);
            this.label20.TabIndex = 67;
            this.label20.Text = "Important:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label21.Location = new System.Drawing.Point(475, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(158, 45);
            this.label21.TabIndex = 66;
            this.label21.Text = "For your account safety.\r\nPlease do not change your \r\ndevice infomation too often" +
    ".\r\n";
            // 
            // RandomIDBtn
            // 
            this.RandomIDBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomIDBtn.Location = new System.Drawing.Point(334, 48);
            this.RandomIDBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RandomIDBtn.Name = "RandomIDBtn";
            this.RandomIDBtn.Size = new System.Drawing.Size(101, 23);
            this.RandomIDBtn.TabIndex = 65;
            this.RandomIDBtn.Text = "Get New ID";
            this.RandomIDBtn.UseVisualStyleBackColor = true;
            this.RandomIDBtn.Click += new System.EventHandler(this.RandomIDBtn_Click);
            // 
            // deviceTypeCb
            // 
            this.deviceTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceTypeCb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deviceTypeCb.FormattingEnabled = true;
            this.deviceTypeCb.Items.AddRange(new object[] {
            "Apple",
            "Android"});
            this.deviceTypeCb.Location = new System.Drawing.Point(154, 12);
            this.deviceTypeCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deviceTypeCb.Name = "deviceTypeCb";
            this.deviceTypeCb.Size = new System.Drawing.Size(174, 23);
            this.deviceTypeCb.TabIndex = 37;
            this.deviceTypeCb.SelectionChangeCommitted += new System.EventHandler(this.deviceTypeCb_SelectionChangeCommitted);
            // 
            // RandomDeviceBtn
            // 
            this.RandomDeviceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RandomDeviceBtn.Location = new System.Drawing.Point(710, 300);
            this.RandomDeviceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RandomDeviceBtn.Name = "RandomDeviceBtn";
            this.RandomDeviceBtn.Size = new System.Drawing.Size(189, 95);
            this.RandomDeviceBtn.TabIndex = 64;
            this.RandomDeviceBtn.Text = "I am feeling RICH\r\n(Randomize)";
            this.RandomDeviceBtn.UseVisualStyleBackColor = true;
            this.RandomDeviceBtn.Click += new System.EventHandler(this.RandomDeviceBtn_Click);
            // 
            // FirmwareFingerprintTb
            // 
            this.FirmwareFingerprintTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareFingerprintTb.Location = new System.Drawing.Point(616, 264);
            this.FirmwareFingerprintTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirmwareFingerprintTb.Name = "FirmwareFingerprintTb";
            this.FirmwareFingerprintTb.Size = new System.Drawing.Size(283, 23);
            this.FirmwareFingerprintTb.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.Location = new System.Drawing.Point(475, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Firmware Fingerprint";
            // 
            // FirmwareTypeTb
            // 
            this.FirmwareTypeTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareTypeTb.Location = new System.Drawing.Point(616, 228);
            this.FirmwareTypeTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirmwareTypeTb.Name = "FirmwareTypeTb";
            this.FirmwareTypeTb.Size = new System.Drawing.Size(283, 23);
            this.FirmwareTypeTb.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(475, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "Firmware Type";
            // 
            // FirmwareTagsTb
            // 
            this.FirmwareTagsTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareTagsTb.Location = new System.Drawing.Point(616, 192);
            this.FirmwareTagsTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirmwareTagsTb.Name = "FirmwareTagsTb";
            this.FirmwareTagsTb.Size = new System.Drawing.Size(283, 23);
            this.FirmwareTagsTb.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(475, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Firmware Tags";
            // 
            // FirmwareBrandTb
            // 
            this.FirmwareBrandTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareBrandTb.Location = new System.Drawing.Point(616, 156);
            this.FirmwareBrandTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirmwareBrandTb.Name = "FirmwareBrandTb";
            this.FirmwareBrandTb.Size = new System.Drawing.Size(283, 23);
            this.FirmwareBrandTb.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(475, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "Firmware Brand";
            // 
            // HardwareModelTb
            // 
            this.HardwareModelTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HardwareModelTb.Location = new System.Drawing.Point(616, 120);
            this.HardwareModelTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HardwareModelTb.Name = "HardwareModelTb";
            this.HardwareModelTb.Size = new System.Drawing.Size(283, 23);
            this.HardwareModelTb.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(475, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Hardware Model";
            // 
            // HardwareManufacturerTb
            // 
            this.HardwareManufacturerTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HardwareManufacturerTb.Location = new System.Drawing.Point(616, 84);
            this.HardwareManufacturerTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HardwareManufacturerTb.Name = "HardwareManufacturerTb";
            this.HardwareManufacturerTb.Size = new System.Drawing.Size(283, 23);
            this.HardwareManufacturerTb.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(475, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Hardware Manu facturer";
            // 
            // DeviceModelBootTb
            // 
            this.DeviceModelBootTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceModelBootTb.Location = new System.Drawing.Point(154, 264);
            this.DeviceModelBootTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeviceModelBootTb.Name = "DeviceModelBootTb";
            this.DeviceModelBootTb.Size = new System.Drawing.Size(283, 23);
            this.DeviceModelBootTb.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(13, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Device Model Boot";
            // 
            // DeviceModelIdentifierTb
            // 
            this.DeviceModelIdentifierTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceModelIdentifierTb.Location = new System.Drawing.Point(154, 228);
            this.DeviceModelIdentifierTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeviceModelIdentifierTb.Name = "DeviceModelIdentifierTb";
            this.DeviceModelIdentifierTb.Size = new System.Drawing.Size(283, 23);
            this.DeviceModelIdentifierTb.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(13, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Device Model Identifier";
            // 
            // DeviceModelTb
            // 
            this.DeviceModelTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceModelTb.Location = new System.Drawing.Point(154, 192);
            this.DeviceModelTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeviceModelTb.Name = "DeviceModelTb";
            this.DeviceModelTb.Size = new System.Drawing.Size(283, 23);
            this.DeviceModelTb.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.Location = new System.Drawing.Point(13, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Device Model";
            // 
            // DeviceBrandTb
            // 
            this.DeviceBrandTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceBrandTb.Location = new System.Drawing.Point(154, 156);
            this.DeviceBrandTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeviceBrandTb.Name = "DeviceBrandTb";
            this.DeviceBrandTb.Size = new System.Drawing.Size(283, 23);
            this.DeviceBrandTb.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.Location = new System.Drawing.Point(13, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 41;
            this.label16.Text = "Device Brand";
            // 
            // AndroidBootloaderTb
            // 
            this.AndroidBootloaderTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AndroidBootloaderTb.Location = new System.Drawing.Point(154, 120);
            this.AndroidBootloaderTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AndroidBootloaderTb.Name = "AndroidBootloaderTb";
            this.AndroidBootloaderTb.Size = new System.Drawing.Size(283, 23);
            this.AndroidBootloaderTb.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(13, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Android Boot loader";
            // 
            // AndroidBoardNameTb
            // 
            this.AndroidBoardNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AndroidBoardNameTb.Location = new System.Drawing.Point(154, 84);
            this.AndroidBoardNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AndroidBoardNameTb.Name = "AndroidBoardNameTb";
            this.AndroidBoardNameTb.Size = new System.Drawing.Size(283, 23);
            this.AndroidBoardNameTb.TabIndex = 61;
            // 
            // BoardName
            // 
            this.BoardName.AutoSize = true;
            this.BoardName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BoardName.Location = new System.Drawing.Point(13, 87);
            this.BoardName.Name = "BoardName";
            this.BoardName.Size = new System.Drawing.Size(119, 15);
            this.BoardName.TabIndex = 39;
            this.BoardName.Text = "Android Board Name";
            // 
            // DeviceIdTb
            // 
            this.DeviceIdTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceIdTb.Location = new System.Drawing.Point(154, 48);
            this.DeviceIdTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeviceIdTb.Name = "DeviceIdTb";
            this.DeviceIdTb.Size = new System.Drawing.Size(174, 23);
            this.DeviceIdTb.TabIndex = 38;
            // 
            // deviceIdlb
            // 
            this.deviceIdlb.AutoSize = true;
            this.deviceIdlb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deviceIdlb.Location = new System.Drawing.Point(13, 51);
            this.deviceIdlb.Name = "deviceIdlb";
            this.deviceIdlb.Size = new System.Drawing.Size(56, 15);
            this.deviceIdlb.TabIndex = 45;
            this.deviceIdlb.Text = "Device ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label18.Location = new System.Drawing.Point(13, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "Device Type:";
            // 
            // tabPokemon
            // 
            this.tabPokemon.BackColor = System.Drawing.SystemColors.Control;
            this.tabPokemon.Controls.Add(this.tcPokemonDetail);
            this.tabPokemon.Location = new System.Drawing.Point(4, 24);
            this.tabPokemon.Name = "tabPokemon";
            this.tabPokemon.Size = new System.Drawing.Size(920, 479);
            this.tabPokemon.TabIndex = 3;
            this.tabPokemon.Text = "Pokemon";
            // 
            // tcPokemonDetail
            // 
            this.tcPokemonDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPokemonDetail.Controls.Add(this.tabCatch);
            this.tcPokemonDetail.Controls.Add(this.tabTransfer);
            this.tcPokemonDetail.Controls.Add(this.tabPowerUp);
            this.tcPokemonDetail.Controls.Add(this.tabEvo);
            this.tcPokemonDetail.Location = new System.Drawing.Point(0, 0);
            this.tcPokemonDetail.Name = "tcPokemonDetail";
            this.tcPokemonDetail.SelectedIndex = 0;
            this.tcPokemonDetail.Size = new System.Drawing.Size(920, 479);
            this.tcPokemonDetail.TabIndex = 5;
            // 
            // tabCatch
            // 
            this.tabCatch.BackColor = System.Drawing.SystemColors.Control;
            this.tabCatch.Controls.Add(this.label47);
            this.tabCatch.Controls.Add(this.cbAutoFavoritePokemon);
            this.tabCatch.Controls.Add(this.tbFavoriteMinIvPercentage);
            this.tabCatch.Controls.Add(this.groupBox10);
            this.tabCatch.Controls.Add(this.tbMaxPokeballsPerPokemon);
            this.tabCatch.Controls.Add(this.label43);
            this.tabCatch.Controls.Add(this.groupBox9);
            this.tabCatch.Controls.Add(this.groupBox2);
            this.tabCatch.Controls.Add(this.tBMaxBerriesToUsePerPokemon);
            this.tabCatch.Controls.Add(this.label27);
            this.tabCatch.Controls.Add(this.cbUseEggIncubators);
            this.tabCatch.Controls.Add(this.cbCatchPoke);
            this.tabCatch.Location = new System.Drawing.Point(4, 24);
            this.tabCatch.Name = "tabCatch";
            this.tabCatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabCatch.Size = new System.Drawing.Size(912, 451);
            this.tabCatch.TabIndex = 0;
            this.tabCatch.Text = "Catch";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 131);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(101, 15);
            this.label47.TabIndex = 4;
            this.label47.Text = "Favorite Min-IV%:";
            // 
            // cbAutoFavoritePokemon
            // 
            this.cbAutoFavoritePokemon.AutoSize = true;
            this.cbAutoFavoritePokemon.Location = new System.Drawing.Point(9, 106);
            this.cbAutoFavoritePokemon.Name = "cbAutoFavoritePokemon";
            this.cbAutoFavoritePokemon.Size = new System.Drawing.Size(153, 19);
            this.cbAutoFavoritePokemon.TabIndex = 19;
            this.cbAutoFavoritePokemon.Text = "Auto-Favorite Pokemon";
            this.cbAutoFavoritePokemon.UseVisualStyleBackColor = true;
            // 
            // tbFavoriteMinIvPercentage
            // 
            this.tbFavoriteMinIvPercentage.Location = new System.Drawing.Point(178, 128);
            this.tbFavoriteMinIvPercentage.Name = "tbFavoriteMinIvPercentage";
            this.tbFavoriteMinIvPercentage.Size = new System.Drawing.Size(100, 23);
            this.tbFavoriteMinIvPercentage.TabIndex = 5;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbUseBerriesOperator);
            this.groupBox10.Controls.Add(this.label52);
            this.groupBox10.Controls.Add(this.tbUseBerriesMinCp);
            this.groupBox10.Controls.Add(this.label54);
            this.groupBox10.Controls.Add(this.tbUseBerriesMinIv);
            this.groupBox10.Controls.Add(this.label56);
            this.groupBox10.Controls.Add(this.tbUseBerriesBelowCatchProbability);
            this.groupBox10.Location = new System.Drawing.Point(284, 18);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(358, 168);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Berry";
            // 
            // cbUseBerriesOperator
            // 
            this.cbUseBerriesOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUseBerriesOperator.FormattingEnabled = true;
            this.cbUseBerriesOperator.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cbUseBerriesOperator.Location = new System.Drawing.Point(95, 45);
            this.cbUseBerriesOperator.Name = "cbUseBerriesOperator";
            this.cbUseBerriesOperator.Size = new System.Drawing.Size(121, 23);
            this.cbUseBerriesOperator.TabIndex = 17;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 19);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(109, 15);
            this.label52.TabIndex = 4;
            this.label52.Text = "Use Berries Min CP:";
            // 
            // tbUseBerriesMinCp
            // 
            this.tbUseBerriesMinCp.Location = new System.Drawing.Point(202, 16);
            this.tbUseBerriesMinCp.Name = "tbUseBerriesMinCp";
            this.tbUseBerriesMinCp.Size = new System.Drawing.Size(142, 23);
            this.tbUseBerriesMinCp.TabIndex = 5;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(11, 77);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(104, 15);
            this.label54.TabIndex = 4;
            this.label54.Text = "Use Berries Min IV:";
            // 
            // tbUseBerriesMinIv
            // 
            this.tbUseBerriesMinIv.Location = new System.Drawing.Point(202, 74);
            this.tbUseBerriesMinIv.Name = "tbUseBerriesMinIv";
            this.tbUseBerriesMinIv.Size = new System.Drawing.Size(142, 23);
            this.tbUseBerriesMinIv.TabIndex = 5;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(11, 121);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(196, 15);
            this.label56.TabIndex = 4;
            this.label56.Text = "Use Berries Below Catch Probability:";
            // 
            // tbUseBerriesBelowCatchProbability
            // 
            this.tbUseBerriesBelowCatchProbability.Location = new System.Drawing.Point(213, 118);
            this.tbUseBerriesBelowCatchProbability.Name = "tbUseBerriesBelowCatchProbability";
            this.tbUseBerriesBelowCatchProbability.Size = new System.Drawing.Size(131, 23);
            this.tbUseBerriesBelowCatchProbability.TabIndex = 5;
            // 
            // tbMaxPokeballsPerPokemon
            // 
            this.tbMaxPokeballsPerPokemon.Location = new System.Drawing.Point(178, 74);
            this.tbMaxPokeballsPerPokemon.Name = "tbMaxPokeballsPerPokemon";
            this.tbMaxPokeballsPerPokemon.Size = new System.Drawing.Size(100, 23);
            this.tbMaxPokeballsPerPokemon.TabIndex = 8;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 77);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(144, 15);
            this.label43.TabIndex = 7;
            this.label43.Text = "Max Poke balls/Pokemon:\r\n";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.tbUseMasterBallBelowCatchProbability);
            this.groupBox9.Controls.Add(this.tbUseGreatBallAboveCp);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.tbUseUltraBallBelowCatchProbability);
            this.groupBox9.Controls.Add(this.tbUseUltraBallAboveCp);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.tbUseGreatBallBelowCatchProbability);
            this.groupBox9.Controls.Add(this.tbUseMasterBallAboveCp);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.tbUseUltraBallAboveIv);
            this.groupBox9.Controls.Add(this.tbUseGreatBallAboveIv);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Location = new System.Drawing.Point(284, 192);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(358, 252);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ball";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Use Great Ball Above CP:\r\n";
            // 
            // tbUseMasterBallBelowCatchProbability
            // 
            this.tbUseMasterBallBelowCatchProbability.Location = new System.Drawing.Point(244, 219);
            this.tbUseMasterBallBelowCatchProbability.Name = "tbUseMasterBallBelowCatchProbability";
            this.tbUseMasterBallBelowCatchProbability.Size = new System.Drawing.Size(100, 23);
            this.tbUseMasterBallBelowCatchProbability.TabIndex = 5;
            // 
            // tbUseGreatBallAboveCp
            // 
            this.tbUseGreatBallAboveCp.Location = new System.Drawing.Point(244, 16);
            this.tbUseGreatBallAboveCp.Name = "tbUseGreatBallAboveCp";
            this.tbUseGreatBallAboveCp.Size = new System.Drawing.Size(100, 23);
            this.tbUseGreatBallAboveCp.TabIndex = 5;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 222);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(219, 15);
            this.label42.TabIndex = 4;
            this.label42.Text = "Use Master Ball Below Catch Probability:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Use Ultra Ball Above CP:\r\n";
            // 
            // tbUseUltraBallBelowCatchProbability
            // 
            this.tbUseUltraBallBelowCatchProbability.Location = new System.Drawing.Point(244, 190);
            this.tbUseUltraBallBelowCatchProbability.Name = "tbUseUltraBallBelowCatchProbability";
            this.tbUseUltraBallBelowCatchProbability.Size = new System.Drawing.Size(100, 23);
            this.tbUseUltraBallBelowCatchProbability.TabIndex = 5;
            // 
            // tbUseUltraBallAboveCp
            // 
            this.tbUseUltraBallAboveCp.Location = new System.Drawing.Point(244, 45);
            this.tbUseUltraBallAboveCp.Name = "tbUseUltraBallAboveCp";
            this.tbUseUltraBallAboveCp.Size = new System.Drawing.Size(100, 23);
            this.tbUseUltraBallAboveCp.TabIndex = 5;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 193);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(208, 15);
            this.label41.TabIndex = 4;
            this.label41.Text = "Use Ultra Ball Below Catch Probability:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Use Master Ball Above CP:";
            // 
            // tbUseGreatBallBelowCatchProbability
            // 
            this.tbUseGreatBallBelowCatchProbability.Location = new System.Drawing.Point(244, 161);
            this.tbUseGreatBallBelowCatchProbability.Name = "tbUseGreatBallBelowCatchProbability";
            this.tbUseGreatBallBelowCatchProbability.Size = new System.Drawing.Size(100, 23);
            this.tbUseGreatBallBelowCatchProbability.TabIndex = 5;
            // 
            // tbUseMasterBallAboveCp
            // 
            this.tbUseMasterBallAboveCp.Location = new System.Drawing.Point(244, 74);
            this.tbUseMasterBallAboveCp.Name = "tbUseMasterBallAboveCp";
            this.tbUseMasterBallAboveCp.Size = new System.Drawing.Size(100, 23);
            this.tbUseMasterBallAboveCp.TabIndex = 5;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 164);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(211, 15);
            this.label40.TabIndex = 4;
            this.label40.Text = "Use Great Ball Below Catch Probability:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Use Great Ball Above IV:\r\n";
            // 
            // tbUseUltraBallAboveIv
            // 
            this.tbUseUltraBallAboveIv.Location = new System.Drawing.Point(244, 132);
            this.tbUseUltraBallAboveIv.Name = "tbUseUltraBallAboveIv";
            this.tbUseUltraBallAboveIv.Size = new System.Drawing.Size(100, 23);
            this.tbUseUltraBallAboveIv.TabIndex = 5;
            // 
            // tbUseGreatBallAboveIv
            // 
            this.tbUseGreatBallAboveIv.Location = new System.Drawing.Point(244, 103);
            this.tbUseGreatBallAboveIv.Name = "tbUseGreatBallAboveIv";
            this.tbUseGreatBallAboveIv.Size = new System.Drawing.Size(100, 23);
            this.tbUseGreatBallAboveIv.TabIndex = 5;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 135);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(129, 15);
            this.label36.TabIndex = 4;
            this.label36.Text = "Use Ultra Ball Above IV:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.cbIgnoreAll);
            this.groupBox2.Controls.Add(this.clbIgnore);
            this.groupBox2.Location = new System.Drawing.Point(6, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(272, 285);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ignore";
            // 
            // cbIgnoreAll
            // 
            this.cbIgnoreAll.AutoSize = true;
            this.cbIgnoreAll.Location = new System.Drawing.Point(6, 17);
            this.cbIgnoreAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIgnoreAll.Name = "cbIgnoreAll";
            this.cbIgnoreAll.Size = new System.Drawing.Size(74, 19);
            this.cbIgnoreAll.TabIndex = 1;
            this.cbIgnoreAll.Text = "Select All";
            this.cbIgnoreAll.UseVisualStyleBackColor = true;
            this.cbIgnoreAll.CheckedChanged += new System.EventHandler(this.cbSelectAllCatch_CheckedChanged);
            // 
            // clbIgnore
            // 
            this.clbIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbIgnore.CheckOnClick = true;
            this.clbIgnore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbIgnore.FormattingEnabled = true;
            this.clbIgnore.Location = new System.Drawing.Point(6, 44);
            this.clbIgnore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbIgnore.Name = "clbIgnore";
            this.clbIgnore.Size = new System.Drawing.Size(259, 76);
            this.clbIgnore.TabIndex = 0;
            // 
            // tBMaxBerriesToUsePerPokemon
            // 
            this.tBMaxBerriesToUsePerPokemon.Location = new System.Drawing.Point(178, 45);
            this.tBMaxBerriesToUsePerPokemon.Name = "tBMaxBerriesToUsePerPokemon";
            this.tBMaxBerriesToUsePerPokemon.Size = new System.Drawing.Size(100, 23);
            this.tBMaxBerriesToUsePerPokemon.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(128, 15);
            this.label27.TabIndex = 1;
            this.label27.Text = "Berry to use/Pokemon:\r\n";
            // 
            // cbUseEggIncubators
            // 
            this.cbUseEggIncubators.AutoSize = true;
            this.cbUseEggIncubators.Location = new System.Drawing.Point(9, 21);
            this.cbUseEggIncubators.Name = "cbUseEggIncubators";
            this.cbUseEggIncubators.Size = new System.Drawing.Size(127, 19);
            this.cbUseEggIncubators.TabIndex = 1;
            this.cbUseEggIncubators.Text = "Use Egg Incubators";
            this.cbUseEggIncubators.UseVisualStyleBackColor = true;
            // 
            // cbCatchPoke
            // 
            this.cbCatchPoke.AutoSize = true;
            this.cbCatchPoke.Location = new System.Drawing.Point(9, 3);
            this.cbCatchPoke.Name = "cbCatchPoke";
            this.cbCatchPoke.Size = new System.Drawing.Size(111, 19);
            this.cbCatchPoke.TabIndex = 1;
            this.cbCatchPoke.Text = "Catch Pokemon";
            this.cbCatchPoke.UseVisualStyleBackColor = true;
            // 
            // tabTransfer
            // 
            this.tabTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.tabTransfer.Controls.Add(this.groupBox1);
            this.tabTransfer.Controls.Add(this.groupBox8);
            this.tabTransfer.Controls.Add(this.groupBox7);
            this.tabTransfer.Location = new System.Drawing.Point(4, 24);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransfer.Size = new System.Drawing.Size(912, 451);
            this.tabTransfer.TabIndex = 1;
            this.tabTransfer.Text = "Transfer";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbNotTransferAll);
            this.groupBox1.Controls.Add(this.clbTransfer);
            this.groupBox1.Location = new System.Drawing.Point(330, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(220, 456);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exclude Transfer";
            // 
            // cbNotTransferAll
            // 
            this.cbNotTransferAll.AutoSize = true;
            this.cbNotTransferAll.Location = new System.Drawing.Point(6, 17);
            this.cbNotTransferAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNotTransferAll.Name = "cbNotTransferAll";
            this.cbNotTransferAll.Size = new System.Drawing.Size(74, 19);
            this.cbNotTransferAll.TabIndex = 1;
            this.cbNotTransferAll.Text = "Select All";
            this.cbNotTransferAll.UseVisualStyleBackColor = true;
            this.cbNotTransferAll.CheckedChanged += new System.EventHandler(this.cbSelectAllTransfer_CheckedChanged);
            // 
            // clbTransfer
            // 
            this.clbTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTransfer.CheckOnClick = true;
            this.clbTransfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTransfer.FormattingEnabled = true;
            this.clbTransfer.Location = new System.Drawing.Point(6, 40);
            this.clbTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbTransfer.Name = "clbTransfer";
            this.clbTransfer.Size = new System.Drawing.Size(207, 364);
            this.clbTransfer.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbUseKeepMinLvl);
            this.groupBox8.Controls.Add(this.label37);
            this.groupBox8.Controls.Add(this.tbKeepMinLvl);
            this.groupBox8.Location = new System.Drawing.Point(6, 261);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(318, 86);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Additional Condiction";
            // 
            // cbUseKeepMinLvl
            // 
            this.cbUseKeepMinLvl.AutoSize = true;
            this.cbUseKeepMinLvl.Location = new System.Drawing.Point(9, 23);
            this.cbUseKeepMinLvl.Name = "cbUseKeepMinLvl";
            this.cbUseKeepMinLvl.Size = new System.Drawing.Size(190, 19);
            this.cbUseKeepMinLvl.TabIndex = 20;
            this.cbUseKeepMinLvl.Text = "Use Keep Min Level Condiction\r\n";
            this.cbUseKeepMinLvl.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 50);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(92, 15);
            this.label37.TabIndex = 16;
            this.label37.Text = "Keep Min-Level:";
            // 
            // tbKeepMinLvl
            // 
            this.tbKeepMinLvl.Location = new System.Drawing.Point(186, 47);
            this.tbKeepMinLvl.Name = "tbKeepMinLvl";
            this.tbKeepMinLvl.Size = new System.Drawing.Size(121, 23);
            this.tbKeepMinLvl.TabIndex = 17;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbTransferDuplicatePokemonOnCapture);
            this.groupBox7.Controls.Add(this.cbTransferDuplicatePokemon);
            this.groupBox7.Controls.Add(this.cbTransferWeakPokemon);
            this.groupBox7.Controls.Add(this.tbKeepMinDuplicatePokemon);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.cbPrioritizeIvOverCp);
            this.groupBox7.Controls.Add(this.tbKeepMinIV);
            this.groupBox7.Controls.Add(this.cbKeepMinOperator);
            this.groupBox7.Controls.Add(this.tbKeepMinCp);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(318, 249);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Condiction";
            // 
            // cbTransferDuplicatePokemonOnCapture
            // 
            this.cbTransferDuplicatePokemonOnCapture.AutoSize = true;
            this.cbTransferDuplicatePokemonOnCapture.Location = new System.Drawing.Point(6, 224);
            this.cbTransferDuplicatePokemonOnCapture.Name = "cbTransferDuplicatePokemonOnCapture";
            this.cbTransferDuplicatePokemonOnCapture.Size = new System.Drawing.Size(239, 19);
            this.cbTransferDuplicatePokemonOnCapture.TabIndex = 24;
            this.cbTransferDuplicatePokemonOnCapture.Text = "Transfer Duplicate Pokemon On Capture";
            this.cbTransferDuplicatePokemonOnCapture.UseVisualStyleBackColor = true;
            // 
            // cbTransferDuplicatePokemon
            // 
            this.cbTransferDuplicatePokemon.AutoSize = true;
            this.cbTransferDuplicatePokemon.Location = new System.Drawing.Point(6, 199);
            this.cbTransferDuplicatePokemon.Name = "cbTransferDuplicatePokemon";
            this.cbTransferDuplicatePokemon.Size = new System.Drawing.Size(175, 19);
            this.cbTransferDuplicatePokemon.TabIndex = 24;
            this.cbTransferDuplicatePokemon.Text = "Transfer Duplicate Pokemon";
            this.cbTransferDuplicatePokemon.UseVisualStyleBackColor = true;
            // 
            // cbTransferWeakPokemon
            // 
            this.cbTransferWeakPokemon.AutoSize = true;
            this.cbTransferWeakPokemon.Location = new System.Drawing.Point(6, 174);
            this.cbTransferWeakPokemon.Name = "cbTransferWeakPokemon";
            this.cbTransferWeakPokemon.Size = new System.Drawing.Size(154, 19);
            this.cbTransferWeakPokemon.TabIndex = 24;
            this.cbTransferWeakPokemon.Text = "Transfer Weak Pokemon";
            this.cbTransferWeakPokemon.UseVisualStyleBackColor = true;
            // 
            // tbKeepMinDuplicatePokemon
            // 
            this.tbKeepMinDuplicatePokemon.Location = new System.Drawing.Point(216, 139);
            this.tbKeepMinDuplicatePokemon.Name = "tbKeepMinDuplicatePokemon";
            this.tbKeepMinDuplicatePokemon.Size = new System.Drawing.Size(91, 23);
            this.tbKeepMinDuplicatePokemon.TabIndex = 23;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 142);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(204, 15);
            this.label35.TabIndex = 22;
            this.label35.Text = "Keep How Many Duplicate Pokemon:\r\n";
            // 
            // cbPrioritizeIvOverCp
            // 
            this.cbPrioritizeIvOverCp.AutoSize = true;
            this.cbPrioritizeIvOverCp.Location = new System.Drawing.Point(11, 22);
            this.cbPrioritizeIvOverCp.Name = "cbPrioritizeIvOverCp";
            this.cbPrioritizeIvOverCp.Size = new System.Drawing.Size(131, 19);
            this.cbPrioritizeIvOverCp.TabIndex = 21;
            this.cbPrioritizeIvOverCp.Text = "Prioritize IV Over CP";
            this.cbPrioritizeIvOverCp.UseVisualStyleBackColor = true;
            // 
            // tbKeepMinIV
            // 
            this.tbKeepMinIV.Location = new System.Drawing.Point(186, 110);
            this.tbKeepMinIV.Name = "tbKeepMinIV";
            this.tbKeepMinIV.Size = new System.Drawing.Size(121, 23);
            this.tbKeepMinIV.TabIndex = 12;
            // 
            // cbKeepMinOperator
            // 
            this.cbKeepMinOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeepMinOperator.FormattingEnabled = true;
            this.cbKeepMinOperator.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cbKeepMinOperator.Location = new System.Drawing.Point(78, 81);
            this.cbKeepMinOperator.Name = "cbKeepMinOperator";
            this.cbKeepMinOperator.Size = new System.Drawing.Size(121, 23);
            this.cbKeepMinOperator.TabIndex = 11;
            // 
            // tbKeepMinCp
            // 
            this.tbKeepMinCp.Location = new System.Drawing.Point(186, 52);
            this.tbKeepMinCp.Name = "tbKeepMinCp";
            this.tbKeepMinCp.Size = new System.Drawing.Size(121, 23);
            this.tbKeepMinCp.TabIndex = 11;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 113);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 15);
            this.label38.TabIndex = 10;
            this.label38.Text = "Keep Min-IV%:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 55);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(80, 15);
            this.label39.TabIndex = 8;
            this.label39.Text = "Keep Min-CP:";
            // 
            // tabPowerUp
            // 
            this.tabPowerUp.BackColor = System.Drawing.SystemColors.Control;
            this.tabPowerUp.Controls.Add(this.cbPowerUpFav);
            this.tabPowerUp.Controls.Add(this.groupBox6);
            this.tabPowerUp.Controls.Add(this.cbPowerUpType);
            this.tabPowerUp.Controls.Add(this.label29);
            this.tabPowerUp.Controls.Add(this.groupBox4);
            this.tabPowerUp.Controls.Add(this.cbAutoPowerUp);
            this.tabPowerUp.Location = new System.Drawing.Point(4, 24);
            this.tabPowerUp.Name = "tabPowerUp";
            this.tabPowerUp.Size = new System.Drawing.Size(912, 451);
            this.tabPowerUp.TabIndex = 4;
            this.tabPowerUp.Text = "PowerUp";
            // 
            // cbPowerUpFav
            // 
            this.cbPowerUpFav.AutoSize = true;
            this.cbPowerUpFav.Location = new System.Drawing.Point(9, 28);
            this.cbPowerUpFav.Name = "cbPowerUpFav";
            this.cbPowerUpFav.Size = new System.Drawing.Size(152, 19);
            this.cbPowerUpFav.TabIndex = 11;
            this.cbPowerUpFav.Text = "Only PowerUp Favorites\r\n";
            this.cbPowerUpFav.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbPowerUpMinIV);
            this.groupBox6.Controls.Add(this.cbPowerUpCondiction);
            this.groupBox6.Controls.Add(this.tbPowerUpMinCP);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.cbPowerUpMinStarDust);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Location = new System.Drawing.Point(9, 130);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 120);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Condiction";
            // 
            // tbPowerUpMinIV
            // 
            this.tbPowerUpMinIV.Location = new System.Drawing.Point(178, 80);
            this.tbPowerUpMinIV.Name = "tbPowerUpMinIV";
            this.tbPowerUpMinIV.Size = new System.Drawing.Size(121, 23);
            this.tbPowerUpMinIV.TabIndex = 12;
            // 
            // cbPowerUpCondiction
            // 
            this.cbPowerUpCondiction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerUpCondiction.FormattingEnabled = true;
            this.cbPowerUpCondiction.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cbPowerUpCondiction.Location = new System.Drawing.Point(79, 51);
            this.cbPowerUpCondiction.Name = "cbPowerUpCondiction";
            this.cbPowerUpCondiction.Size = new System.Drawing.Size(121, 23);
            this.cbPowerUpCondiction.TabIndex = 11;
            // 
            // tbPowerUpMinCP
            // 
            this.tbPowerUpMinCP.Location = new System.Drawing.Point(178, 80);
            this.tbPowerUpMinCP.Name = "tbPowerUpMinCP";
            this.tbPowerUpMinCP.Size = new System.Drawing.Size(121, 23);
            this.tbPowerUpMinCP.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 83);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 15);
            this.label31.TabIndex = 10;
            this.label31.Text = "Min-IV%:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 83);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 15);
            this.label30.TabIndex = 8;
            this.label30.Text = "Min-CP:";
            // 
            // cbPowerUpMinStarDust
            // 
            this.cbPowerUpMinStarDust.FormattingEnabled = true;
            this.cbPowerUpMinStarDust.Items.AddRange(new object[] {
            "200",
            "400",
            "600",
            "800",
            "1000",
            "1300",
            "1600",
            "1900",
            "2200",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000"});
            this.cbPowerUpMinStarDust.Location = new System.Drawing.Point(178, 22);
            this.cbPowerUpMinStarDust.Name = "cbPowerUpMinStarDust";
            this.cbPowerUpMinStarDust.Size = new System.Drawing.Size(121, 23);
            this.cbPowerUpMinStarDust.TabIndex = 7;
            this.cbPowerUpMinStarDust.Text = "5000";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 15);
            this.label28.TabIndex = 6;
            this.label28.Text = "Min-StarDust For PowerUp:\r\n";
            // 
            // cbPowerUpType
            // 
            this.cbPowerUpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerUpType.FormattingEnabled = true;
            this.cbPowerUpType.Items.AddRange(new object[] {
            "IV",
            "CP"});
            this.cbPowerUpType.Location = new System.Drawing.Point(98, 93);
            this.cbPowerUpType.Name = "cbPowerUpType";
            this.cbPowerUpType.Size = new System.Drawing.Size(121, 23);
            this.cbPowerUpType.TabIndex = 9;
            this.cbPowerUpType.SelectionChangeCommitted += new System.EventHandler(this.cbPowerUpType_SelectionChangeCommitted);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 15);
            this.label29.TabIndex = 8;
            this.label29.Text = "PowerUp Type:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.cbPowerUpAll);
            this.groupBox4.Controls.Add(this.clbPowerUp);
            this.groupBox4.Location = new System.Drawing.Point(323, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(220, 459);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Power Up";
            // 
            // cbPowerUpAll
            // 
            this.cbPowerUpAll.AutoSize = true;
            this.cbPowerUpAll.Location = new System.Drawing.Point(6, 17);
            this.cbPowerUpAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPowerUpAll.Name = "cbPowerUpAll";
            this.cbPowerUpAll.Size = new System.Drawing.Size(74, 19);
            this.cbPowerUpAll.TabIndex = 1;
            this.cbPowerUpAll.Text = "Select All";
            this.cbPowerUpAll.UseVisualStyleBackColor = true;
            this.cbPowerUpAll.CheckedChanged += new System.EventHandler(this.cbPowerUpAll_CheckedChanged);
            // 
            // clbPowerUp
            // 
            this.clbPowerUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbPowerUp.CheckOnClick = true;
            this.clbPowerUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPowerUp.FormattingEnabled = true;
            this.clbPowerUp.Location = new System.Drawing.Point(6, 44);
            this.clbPowerUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbPowerUp.Name = "clbPowerUp";
            this.clbPowerUp.Size = new System.Drawing.Size(207, 382);
            this.clbPowerUp.TabIndex = 0;
            // 
            // cbAutoPowerUp
            // 
            this.cbAutoPowerUp.AutoSize = true;
            this.cbAutoPowerUp.Location = new System.Drawing.Point(9, 3);
            this.cbAutoPowerUp.Name = "cbAutoPowerUp";
            this.cbAutoPowerUp.Size = new System.Drawing.Size(106, 19);
            this.cbAutoPowerUp.TabIndex = 4;
            this.cbAutoPowerUp.Text = "Auto Power Up";
            this.cbAutoPowerUp.UseVisualStyleBackColor = true;
            // 
            // tabEvo
            // 
            this.tabEvo.BackColor = System.Drawing.SystemColors.Control;
            this.tabEvo.Controls.Add(this.label53);
            this.tabEvo.Controls.Add(this.tbUseLuckyEggsMinPokemonAmount);
            this.tabEvo.Controls.Add(this.cbUseLuckyEggsWhileEvolving);
            this.tabEvo.Controls.Add(this.groupBox5);
            this.tabEvo.Controls.Add(this.label33);
            this.tabEvo.Controls.Add(this.tbEvolveKeptPokemonsAtStorageUsagePercentage);
            this.tabEvo.Controls.Add(this.cbKeepPokemonsThatCanEvolve);
            this.tabEvo.Controls.Add(this.groupBox3);
            this.tabEvo.Location = new System.Drawing.Point(4, 24);
            this.tabEvo.Name = "tabEvo";
            this.tabEvo.Size = new System.Drawing.Size(912, 451);
            this.tabEvo.TabIndex = 3;
            this.tabEvo.Text = "Evolve";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(12, 237);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(129, 45);
            this.label53.TabIndex = 24;
            this.label53.Text = "Use Lucky Eggs \r\nWhen Having Amount \r\nOf Pokemons:";
            // 
            // tbUseLuckyEggsMinPokemonAmount
            // 
            this.tbUseLuckyEggsMinPokemonAmount.Location = new System.Drawing.Point(147, 249);
            this.tbUseLuckyEggsMinPokemonAmount.Name = "tbUseLuckyEggsMinPokemonAmount";
            this.tbUseLuckyEggsMinPokemonAmount.Size = new System.Drawing.Size(102, 23);
            this.tbUseLuckyEggsMinPokemonAmount.TabIndex = 23;
            // 
            // cbUseLuckyEggsWhileEvolving
            // 
            this.cbUseLuckyEggsWhileEvolving.AutoSize = true;
            this.cbUseLuckyEggsWhileEvolving.Location = new System.Drawing.Point(15, 209);
            this.cbUseLuckyEggsWhileEvolving.Name = "cbUseLuckyEggsWhileEvolving";
            this.cbUseLuckyEggsWhileEvolving.Size = new System.Drawing.Size(188, 19);
            this.cbUseLuckyEggsWhileEvolving.TabIndex = 22;
            this.cbUseLuckyEggsWhileEvolving.Text = "Use Lucky Eggs While Evolving\r\n";
            this.cbUseLuckyEggsWhileEvolving.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.tbEvoAboveIV);
            this.groupBox5.Controls.Add(this.cbEvoAllAboveIV);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.cbEvolveAllPokemonWithEnoughCandy);
            this.groupBox5.Location = new System.Drawing.Point(9, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 140);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Global Evo Setting";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Coral;
            this.label34.Location = new System.Drawing.Point(52, 19);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(153, 30);
            this.label34.TabIndex = 20;
            this.label34.Text = " These settings will ignore \r\nthe evolve filter on the right";
            // 
            // tbEvoAboveIV
            // 
            this.tbEvoAboveIV.Location = new System.Drawing.Point(82, 77);
            this.tbEvoAboveIV.Name = "tbEvoAboveIV";
            this.tbEvoAboveIV.Size = new System.Drawing.Size(161, 23);
            this.tbEvoAboveIV.TabIndex = 15;
            // 
            // cbEvoAllAboveIV
            // 
            this.cbEvoAllAboveIV.AutoSize = true;
            this.cbEvoAllAboveIV.Location = new System.Drawing.Point(6, 52);
            this.cbEvoAllAboveIV.Name = "cbEvoAllAboveIV";
            this.cbEvoAllAboveIV.Size = new System.Drawing.Size(181, 19);
            this.cbEvoAllAboveIV.TabIndex = 12;
            this.cbEvoAllAboveIV.Text = "Evolve All Pokemon Above IV";
            this.cbEvoAllAboveIV.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 80);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(30, 15);
            this.label32.TabIndex = 19;
            this.label32.Text = "IV%:";
            // 
            // cbEvolveAllPokemonWithEnoughCandy
            // 
            this.cbEvolveAllPokemonWithEnoughCandy.AutoSize = true;
            this.cbEvolveAllPokemonWithEnoughCandy.Location = new System.Drawing.Point(6, 106);
            this.cbEvolveAllPokemonWithEnoughCandy.Name = "cbEvolveAllPokemonWithEnoughCandy";
            this.cbEvolveAllPokemonWithEnoughCandy.Size = new System.Drawing.Size(240, 19);
            this.cbEvolveAllPokemonWithEnoughCandy.TabIndex = 14;
            this.cbEvolveAllPokemonWithEnoughCandy.Text = "Evolve All Pokemon With Enough Candy";
            this.cbEvolveAllPokemonWithEnoughCandy.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 183);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(98, 15);
            this.label33.TabIndex = 20;
            this.label33.Text = "Storage Usage %:";
            // 
            // tbEvolveKeptPokemonsAtStorageUsagePercentage
            // 
            this.tbEvolveKeptPokemonsAtStorageUsagePercentage.Location = new System.Drawing.Point(116, 180);
            this.tbEvolveKeptPokemonsAtStorageUsagePercentage.Name = "tbEvolveKeptPokemonsAtStorageUsagePercentage";
            this.tbEvolveKeptPokemonsAtStorageUsagePercentage.Size = new System.Drawing.Size(133, 23);
            this.tbEvolveKeptPokemonsAtStorageUsagePercentage.TabIndex = 18;
            // 
            // cbKeepPokemonsThatCanEvolve
            // 
            this.cbKeepPokemonsThatCanEvolve.AutoSize = true;
            this.cbKeepPokemonsThatCanEvolve.Location = new System.Drawing.Point(15, 155);
            this.cbKeepPokemonsThatCanEvolve.Name = "cbKeepPokemonsThatCanEvolve";
            this.cbKeepPokemonsThatCanEvolve.Size = new System.Drawing.Size(237, 19);
            this.cbKeepPokemonsThatCanEvolve.TabIndex = 17;
            this.cbKeepPokemonsThatCanEvolve.Text = "Evolve Pokemons when storage is % full\r\n";
            this.cbKeepPokemonsThatCanEvolve.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.cbEvolveAll);
            this.groupBox3.Controls.Add(this.clbEvolve);
            this.groupBox3.Location = new System.Drawing.Point(270, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(220, 459);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evolve";
            // 
            // cbEvolveAll
            // 
            this.cbEvolveAll.AutoSize = true;
            this.cbEvolveAll.Location = new System.Drawing.Point(6, 17);
            this.cbEvolveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEvolveAll.Name = "cbEvolveAll";
            this.cbEvolveAll.Size = new System.Drawing.Size(74, 19);
            this.cbEvolveAll.TabIndex = 1;
            this.cbEvolveAll.Text = "Select All";
            this.cbEvolveAll.UseVisualStyleBackColor = true;
            this.cbEvolveAll.CheckedChanged += new System.EventHandler(this.cbSelectAllEvolve_CheckedChanged);
            // 
            // clbEvolve
            // 
            this.clbEvolve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEvolve.CheckOnClick = true;
            this.clbEvolve.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbEvolve.FormattingEnabled = true;
            this.clbEvolve.Location = new System.Drawing.Point(6, 44);
            this.clbEvolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbEvolve.Name = "clbEvolve";
            this.clbEvolve.Size = new System.Drawing.Size(207, 346);
            this.clbEvolve.TabIndex = 0;
            // 
            // tabItems
            // 
            this.tabItems.BackColor = System.Drawing.SystemColors.Control;
            this.tabItems.Controls.Add(this.groupBox14);
            this.tabItems.Controls.Add(this.groupBox13);
            this.tabItems.Controls.Add(this.groupBox12);
            this.tabItems.Controls.Add(this.groupBox11);
            this.tabItems.Location = new System.Drawing.Point(4, 24);
            this.tabItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabItems.Size = new System.Drawing.Size(920, 479);
            this.tabItems.TabIndex = 2;
            this.tabItems.Text = "Items";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cbVerboseRecycling);
            this.groupBox14.Controls.Add(this.label1);
            this.groupBox14.Controls.Add(this.tbRecycleInventoryAtUsagePercentage);
            this.groupBox14.Location = new System.Drawing.Point(9, 296);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(311, 81);
            this.groupBox14.TabIndex = 18;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Recycle";
            // 
            // cbVerboseRecycling
            // 
            this.cbVerboseRecycling.AutoSize = true;
            this.cbVerboseRecycling.Location = new System.Drawing.Point(9, 22);
            this.cbVerboseRecycling.Name = "cbVerboseRecycling";
            this.cbVerboseRecycling.Size = new System.Drawing.Size(121, 19);
            this.cbVerboseRecycling.TabIndex = 16;
            this.cbVerboseRecycling.Text = "Verbose Recycling";
            this.cbVerboseRecycling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recycle Inventory At Usage Percentage:\r\n";
            // 
            // tbRecycleInventoryAtUsagePercentage
            // 
            this.tbRecycleInventoryAtUsagePercentage.Location = new System.Drawing.Point(241, 46);
            this.tbRecycleInventoryAtUsagePercentage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbRecycleInventoryAtUsagePercentage.Name = "tbRecycleInventoryAtUsagePercentage";
            this.tbRecycleInventoryAtUsagePercentage.Size = new System.Drawing.Size(64, 23);
            this.tbRecycleInventoryAtUsagePercentage.TabIndex = 15;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label5);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfPokeballsToKeep);
            this.groupBox13.Controls.Add(this.label44);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfPotionsToKeep);
            this.groupBox13.Controls.Add(this.label45);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfRevivesToKeep);
            this.groupBox13.Controls.Add(this.label46);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfBerriesToKeep);
            this.groupBox13.Location = new System.Drawing.Point(9, 139);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(311, 151);
            this.groupBox13.TabIndex = 17;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Amount to Keep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Pokeballs To Keep:";
            // 
            // tbTotalAmountOfPokeballsToKeep
            // 
            this.tbTotalAmountOfPokeballsToKeep.Location = new System.Drawing.Point(157, 16);
            this.tbTotalAmountOfPokeballsToKeep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTotalAmountOfPokeballsToKeep.Name = "tbTotalAmountOfPokeballsToKeep";
            this.tbTotalAmountOfPokeballsToKeep.Size = new System.Drawing.Size(148, 23);
            this.tbTotalAmountOfPokeballsToKeep.TabIndex = 15;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(124, 15);
            this.label44.TabIndex = 14;
            this.label44.Text = "Total Potions To Keep:\r\n";
            // 
            // tbTotalAmountOfPotionsToKeep
            // 
            this.tbTotalAmountOfPotionsToKeep.Location = new System.Drawing.Point(157, 49);
            this.tbTotalAmountOfPotionsToKeep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTotalAmountOfPotionsToKeep.Name = "tbTotalAmountOfPotionsToKeep";
            this.tbTotalAmountOfPotionsToKeep.Size = new System.Drawing.Size(148, 23);
            this.tbTotalAmountOfPotionsToKeep.TabIndex = 15;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 85);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(123, 15);
            this.label45.TabIndex = 14;
            this.label45.Text = "Total Revives To Keep:";
            // 
            // tbTotalAmountOfRevivesToKeep
            // 
            this.tbTotalAmountOfRevivesToKeep.Location = new System.Drawing.Point(157, 82);
            this.tbTotalAmountOfRevivesToKeep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTotalAmountOfRevivesToKeep.Name = "tbTotalAmountOfRevivesToKeep";
            this.tbTotalAmountOfRevivesToKeep.Size = new System.Drawing.Size(148, 23);
            this.tbTotalAmountOfRevivesToKeep.TabIndex = 15;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 118);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(119, 15);
            this.label46.TabIndex = 14;
            this.label46.Text = "Total Berries To Keep:\r\n";
            // 
            // tbTotalAmountOfBerriesToKeep
            // 
            this.tbTotalAmountOfBerriesToKeep.Location = new System.Drawing.Point(157, 115);
            this.tbTotalAmountOfBerriesToKeep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbTotalAmountOfBerriesToKeep.Name = "tbTotalAmountOfBerriesToKeep";
            this.tbTotalAmountOfBerriesToKeep.Size = new System.Drawing.Size(148, 23);
            this.tbTotalAmountOfBerriesToKeep.TabIndex = 15;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cbUseIncenseConstantly);
            this.groupBox12.Location = new System.Drawing.Point(9, 73);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(311, 60);
            this.groupBox12.TabIndex = 17;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Incense";
            // 
            // cbUseIncenseConstantly
            // 
            this.cbUseIncenseConstantly.AutoSize = true;
            this.cbUseIncenseConstantly.Location = new System.Drawing.Point(6, 22);
            this.cbUseIncenseConstantly.Name = "cbUseIncenseConstantly";
            this.cbUseIncenseConstantly.Size = new System.Drawing.Size(148, 19);
            this.cbUseIncenseConstantly.TabIndex = 2;
            this.cbUseIncenseConstantly.Text = "Use Incense Constantly";
            this.cbUseIncenseConstantly.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbUseLuckyEggConstantly);
            this.groupBox11.Location = new System.Drawing.Point(9, 7);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(311, 60);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Lucky Egg";
            // 
            // cbUseLuckyEggConstantly
            // 
            this.cbUseLuckyEggConstantly.AutoSize = true;
            this.cbUseLuckyEggConstantly.Location = new System.Drawing.Point(6, 22);
            this.cbUseLuckyEggConstantly.Name = "cbUseLuckyEggConstantly";
            this.cbUseLuckyEggConstantly.Size = new System.Drawing.Size(162, 19);
            this.cbUseLuckyEggConstantly.TabIndex = 2;
            this.cbUseLuckyEggConstantly.Text = "Use Lucky Egg Constantly";
            this.cbUseLuckyEggConstantly.UseVisualStyleBackColor = true;
            // 
            // tabAdvSetting
            // 
            this.tabAdvSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdvSetting.Controls.Add(this.groupBox18);
            this.tabAdvSetting.Controls.Add(this.groupBox17);
            this.tabAdvSetting.Controls.Add(this.groupBox16);
            this.tabAdvSetting.Controls.Add(this.groupBox15);
            this.tabAdvSetting.Location = new System.Drawing.Point(4, 24);
            this.tabAdvSetting.Name = "tabAdvSetting";
            this.tabAdvSetting.Size = new System.Drawing.Size(920, 479);
            this.tabAdvSetting.TabIndex = 4;
            this.tabAdvSetting.Text = "Advanced Settings";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.cbEnableHumanizedThrows);
            this.groupBox18.Controls.Add(this.tbForceExcellentThrowOverCp);
            this.groupBox18.Controls.Add(this.tbForceGreatThrowOverCp);
            this.groupBox18.Controls.Add(this.label66);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Controls.Add(this.label60);
            this.groupBox18.Controls.Add(this.tbForceExcellentThrowOverIv);
            this.groupBox18.Controls.Add(this.tbNiceThrowChance);
            this.groupBox18.Controls.Add(this.label61);
            this.groupBox18.Controls.Add(this.label62);
            this.groupBox18.Controls.Add(this.tbForceGreatThrowOverIv);
            this.groupBox18.Controls.Add(this.tbGreatThrowChance);
            this.groupBox18.Controls.Add(this.label63);
            this.groupBox18.Controls.Add(this.label64);
            this.groupBox18.Controls.Add(this.tbCurveThrowChance);
            this.groupBox18.Controls.Add(this.tbExcellentThrowChance);
            this.groupBox18.Controls.Add(this.label65);
            this.groupBox18.Location = new System.Drawing.Point(325, 7);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(358, 284);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Catching Behavior";
            // 
            // cbEnableHumanizedThrows
            // 
            this.cbEnableHumanizedThrows.AutoSize = true;
            this.cbEnableHumanizedThrows.Location = new System.Drawing.Point(9, 23);
            this.cbEnableHumanizedThrows.Name = "cbEnableHumanizedThrows";
            this.cbEnableHumanizedThrows.Size = new System.Drawing.Size(167, 19);
            this.cbEnableHumanizedThrows.TabIndex = 18;
            this.cbEnableHumanizedThrows.Text = "Enable Humanized Throws";
            this.cbEnableHumanizedThrows.UseVisualStyleBackColor = true;
            // 
            // tbForceExcellentThrowOverCp
            // 
            this.tbForceExcellentThrowOverCp.Location = new System.Drawing.Point(226, 252);
            this.tbForceExcellentThrowOverCp.Name = "tbForceExcellentThrowOverCp";
            this.tbForceExcellentThrowOverCp.Size = new System.Drawing.Size(126, 23);
            this.tbForceExcellentThrowOverCp.TabIndex = 5;
            // 
            // tbForceGreatThrowOverCp
            // 
            this.tbForceGreatThrowOverCp.Location = new System.Drawing.Point(226, 223);
            this.tbForceGreatThrowOverCp.Name = "tbForceGreatThrowOverCp";
            this.tbForceGreatThrowOverCp.Size = new System.Drawing.Size(126, 23);
            this.tbForceGreatThrowOverCp.TabIndex = 5;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 255);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(171, 15);
            this.label66.TabIndex = 4;
            this.label66.Text = "Force Excellent Throw Over CP:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 226);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(153, 15);
            this.label55.TabIndex = 4;
            this.label55.Text = "Force Great Throw Over CP:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 52);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(127, 15);
            this.label60.TabIndex = 4;
            this.label60.Text = "Nice Throw Chance %:";
            // 
            // tbForceExcellentThrowOverIv
            // 
            this.tbForceExcellentThrowOverIv.Location = new System.Drawing.Point(226, 194);
            this.tbForceExcellentThrowOverIv.Name = "tbForceExcellentThrowOverIv";
            this.tbForceExcellentThrowOverIv.Size = new System.Drawing.Size(126, 23);
            this.tbForceExcellentThrowOverIv.TabIndex = 5;
            // 
            // tbNiceThrowChance
            // 
            this.tbNiceThrowChance.Location = new System.Drawing.Point(226, 49);
            this.tbNiceThrowChance.Name = "tbNiceThrowChance";
            this.tbNiceThrowChance.Size = new System.Drawing.Size(126, 23);
            this.tbNiceThrowChance.TabIndex = 5;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 197);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(179, 15);
            this.label61.TabIndex = 4;
            this.label61.Text = "Force Excellent Throw Over IV %:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 81);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(131, 15);
            this.label62.TabIndex = 4;
            this.label62.Text = "Great Throw Chance %:";
            // 
            // tbForceGreatThrowOverIv
            // 
            this.tbForceGreatThrowOverIv.Location = new System.Drawing.Point(226, 165);
            this.tbForceGreatThrowOverIv.Name = "tbForceGreatThrowOverIv";
            this.tbForceGreatThrowOverIv.Size = new System.Drawing.Size(126, 23);
            this.tbForceGreatThrowOverIv.TabIndex = 5;
            // 
            // tbGreatThrowChance
            // 
            this.tbGreatThrowChance.Location = new System.Drawing.Point(226, 78);
            this.tbGreatThrowChance.Name = "tbGreatThrowChance";
            this.tbGreatThrowChance.Size = new System.Drawing.Size(126, 23);
            this.tbGreatThrowChance.TabIndex = 5;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 168);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(161, 15);
            this.label63.TabIndex = 4;
            this.label63.Text = "Force Great Throw Over IV %:\r\n";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 110);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(149, 15);
            this.label64.TabIndex = 4;
            this.label64.Text = "Excellent Throw Chance %:\r\n";
            // 
            // tbCurveThrowChance
            // 
            this.tbCurveThrowChance.Location = new System.Drawing.Point(226, 136);
            this.tbCurveThrowChance.Name = "tbCurveThrowChance";
            this.tbCurveThrowChance.Size = new System.Drawing.Size(126, 23);
            this.tbCurveThrowChance.TabIndex = 5;
            // 
            // tbExcellentThrowChance
            // 
            this.tbExcellentThrowChance.Location = new System.Drawing.Point(226, 107);
            this.tbExcellentThrowChance.Name = "tbExcellentThrowChance";
            this.tbExcellentThrowChance.Size = new System.Drawing.Size(126, 23);
            this.tbExcellentThrowChance.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 139);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(134, 15);
            this.label65.TabIndex = 4;
            this.label65.Text = "Curve Throw Chance %:\r\n";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.cbRandomizeRecycle);
            this.groupBox17.Controls.Add(this.label51);
            this.groupBox17.Controls.Add(this.tbRandomRecycleValue);
            this.groupBox17.Location = new System.Drawing.Point(325, 297);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(358, 85);
            this.groupBox17.TabIndex = 19;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Recycle Behavior";
            // 
            // cbRandomizeRecycle
            // 
            this.cbRandomizeRecycle.AutoSize = true;
            this.cbRandomizeRecycle.Location = new System.Drawing.Point(9, 22);
            this.cbRandomizeRecycle.Name = "cbRandomizeRecycle";
            this.cbRandomizeRecycle.Size = new System.Drawing.Size(128, 19);
            this.cbRandomizeRecycle.TabIndex = 17;
            this.cbRandomizeRecycle.Text = "Randomize Recycle";
            this.cbRandomizeRecycle.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 49);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(129, 15);
            this.label51.TabIndex = 14;
            this.label51.Text = "Random Recycle Value:";
            // 
            // tbRandomRecycleValue
            // 
            this.tbRandomRecycleValue.Location = new System.Drawing.Point(226, 46);
            this.tbRandomRecycleValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbRandomRecycleValue.Name = "tbRandomRecycleValue";
            this.tbRandomRecycleValue.Size = new System.Drawing.Size(123, 23);
            this.tbRandomRecycleValue.TabIndex = 15;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.cbShowWalkingSpeed);
            this.groupBox16.Controls.Add(this.cbUseWalkingSpeedVariant);
            this.groupBox16.Controls.Add(this.cbDisableHumanWalking);
            this.groupBox16.Controls.Add(this.label57);
            this.groupBox16.Controls.Add(this.tbWalkingSpeedVariantInKilometerPerHour);
            this.groupBox16.Controls.Add(this.label58);
            this.groupBox16.Controls.Add(this.tbMaxSpawnLocationOffset);
            this.groupBox16.Controls.Add(this.label59);
            this.groupBox16.Controls.Add(this.tbMaxTravelDistanceInMeters);
            this.groupBox16.Location = new System.Drawing.Point(8, 7);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(311, 200);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Walking Behavior";
            // 
            // cbShowWalkingSpeed
            // 
            this.cbShowWalkingSpeed.AutoSize = true;
            this.cbShowWalkingSpeed.Location = new System.Drawing.Point(9, 109);
            this.cbShowWalkingSpeed.Name = "cbShowWalkingSpeed";
            this.cbShowWalkingSpeed.Size = new System.Drawing.Size(136, 19);
            this.cbShowWalkingSpeed.TabIndex = 18;
            this.cbShowWalkingSpeed.Text = "Show Walking Speed";
            this.cbShowWalkingSpeed.UseVisualStyleBackColor = true;
            // 
            // cbUseWalkingSpeedVariant
            // 
            this.cbUseWalkingSpeedVariant.AutoSize = true;
            this.cbUseWalkingSpeedVariant.Location = new System.Drawing.Point(9, 51);
            this.cbUseWalkingSpeedVariant.Name = "cbUseWalkingSpeedVariant";
            this.cbUseWalkingSpeedVariant.Size = new System.Drawing.Size(165, 19);
            this.cbUseWalkingSpeedVariant.TabIndex = 17;
            this.cbUseWalkingSpeedVariant.Text = "Use Walking Speed Variant";
            this.cbUseWalkingSpeedVariant.UseVisualStyleBackColor = true;
            // 
            // cbDisableHumanWalking
            // 
            this.cbDisableHumanWalking.AutoSize = true;
            this.cbDisableHumanWalking.Location = new System.Drawing.Point(9, 23);
            this.cbDisableHumanWalking.Name = "cbDisableHumanWalking";
            this.cbDisableHumanWalking.Size = new System.Drawing.Size(153, 19);
            this.cbDisableHumanWalking.TabIndex = 16;
            this.cbDisableHumanWalking.Text = "Disable Human Walking";
            this.cbDisableHumanWalking.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 81);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(170, 15);
            this.label57.TabIndex = 14;
            this.label57.Text = "Walking Speed Variant (KM/H):";
            // 
            // tbWalkingSpeedVariantInKilometerPerHour
            // 
            this.tbWalkingSpeedVariantInKilometerPerHour.Location = new System.Drawing.Point(182, 78);
            this.tbWalkingSpeedVariantInKilometerPerHour.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbWalkingSpeedVariantInKilometerPerHour.Name = "tbWalkingSpeedVariantInKilometerPerHour";
            this.tbWalkingSpeedVariantInKilometerPerHour.Size = new System.Drawing.Size(123, 23);
            this.tbWalkingSpeedVariantInKilometerPerHour.TabIndex = 15;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 139);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(154, 15);
            this.label58.TabIndex = 14;
            this.label58.Text = "Max Spawn Location Offset:";
            // 
            // tbMaxSpawnLocationOffset
            // 
            this.tbMaxSpawnLocationOffset.Location = new System.Drawing.Point(182, 136);
            this.tbMaxSpawnLocationOffset.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbMaxSpawnLocationOffset.Name = "tbMaxSpawnLocationOffset";
            this.tbMaxSpawnLocationOffset.Size = new System.Drawing.Size(123, 23);
            this.tbMaxSpawnLocationOffset.TabIndex = 15;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(6, 172);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(161, 15);
            this.label59.TabIndex = 14;
            this.label59.Text = "Max Travel Distance (Meters):";
            // 
            // tbMaxTravelDistanceInMeters
            // 
            this.tbMaxTravelDistanceInMeters.Location = new System.Drawing.Point(182, 169);
            this.tbMaxTravelDistanceInMeters.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbMaxTravelDistanceInMeters.Name = "tbMaxTravelDistanceInMeters";
            this.tbMaxTravelDistanceInMeters.Size = new System.Drawing.Size(123, 23);
            this.tbMaxTravelDistanceInMeters.TabIndex = 15;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label48);
            this.groupBox15.Controls.Add(this.tbDelayBetweenRecycle);
            this.groupBox15.Controls.Add(this.label49);
            this.groupBox15.Controls.Add(this.tbDelayBetweenPlayerActions);
            this.groupBox15.Controls.Add(this.label50);
            this.groupBox15.Controls.Add(this.tbDelayBetweenPokemonCatch);
            this.groupBox15.Location = new System.Drawing.Point(8, 213);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(311, 169);
            this.groupBox15.TabIndex = 18;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Action Behavior";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 90);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(168, 15);
            this.label48.TabIndex = 21;
            this.label48.Text = "Delay Between Recycling (ms):";
            // 
            // tbDelayBetweenRecycle
            // 
            this.tbDelayBetweenRecycle.Location = new System.Drawing.Point(182, 87);
            this.tbDelayBetweenRecycle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbDelayBetweenRecycle.Name = "tbDelayBetweenRecycle";
            this.tbDelayBetweenRecycle.Size = new System.Drawing.Size(123, 23);
            this.tbDelayBetweenRecycle.TabIndex = 22;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 24);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(157, 15);
            this.label49.TabIndex = 14;
            this.label49.Text = "Delay Between Actions (ms):";
            // 
            // tbDelayBetweenPlayerActions
            // 
            this.tbDelayBetweenPlayerActions.Location = new System.Drawing.Point(182, 21);
            this.tbDelayBetweenPlayerActions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbDelayBetweenPlayerActions.Name = "tbDelayBetweenPlayerActions";
            this.tbDelayBetweenPlayerActions.Size = new System.Drawing.Size(123, 23);
            this.tbDelayBetweenPlayerActions.TabIndex = 15;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 57);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(165, 15);
            this.label50.TabIndex = 14;
            this.label50.Text = "Delay Between Catching (ms):";
            // 
            // tbDelayBetweenPokemonCatch
            // 
            this.tbDelayBetweenPokemonCatch.Location = new System.Drawing.Point(182, 54);
            this.tbDelayBetweenPokemonCatch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbDelayBetweenPokemonCatch.Name = "tbDelayBetweenPokemonCatch";
            this.tbDelayBetweenPokemonCatch.Size = new System.Drawing.Size(123, 23);
            this.tbDelayBetweenPokemonCatch.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(518, 540);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(286, 32);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Save (This will automatically restart RocketBot)";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 586);
            this.Controls.Add(this.enableAdvSettingCb);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.saveBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bot Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.proxyGb.ResumeLayout(false);
            this.proxyGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tabDevice.ResumeLayout(false);
            this.tabDevice.PerformLayout();
            this.tabPokemon.ResumeLayout(false);
            this.tcPokemonDetail.ResumeLayout(false);
            this.tabCatch.ResumeLayout(false);
            this.tabCatch.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabTransfer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPowerUp.ResumeLayout(false);
            this.tabPowerUp.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabEvo.ResumeLayout(false);
            this.tabEvo.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabItems.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabAdvSetting.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableAdvSettingCb;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAuth;
        private System.Windows.Forms.TextBox tbWalkingSpeed;
        private System.Windows.Forms.Label TravelSpeedText;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox proxyGb;
        private System.Windows.Forms.TextBox proxyPortTb;
        private System.Windows.Forms.TextBox proxyUserTb;
        private System.Windows.Forms.TextBox proxyPwTb;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox proxyHostTb;
        private System.Windows.Forms.CheckBox useProxyAuthCb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox useProxyCb;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button ResetLocationBtn;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Button FindAdressBtn;
        private GMap.NET.WindowsForms.GMapControl gMapCtrl;
        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.TextBox UserPasswordBox;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.Label authTypeLabel;
        private System.Windows.Forms.Label longiLabel;
        private System.Windows.Forms.ComboBox authTypeCb;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TabPage tabDevice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button RandomIDBtn;
        private System.Windows.Forms.ComboBox deviceTypeCb;
        private System.Windows.Forms.Button RandomDeviceBtn;
        private System.Windows.Forms.TextBox FirmwareFingerprintTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox FirmwareTypeTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox FirmwareTagsTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FirmwareBrandTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HardwareModelTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HardwareManufacturerTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DeviceModelBootTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeviceModelIdentifierTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeviceModelTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DeviceBrandTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AndroidBootloaderTb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AndroidBoardNameTb;
        private System.Windows.Forms.Label BoardName;
        private System.Windows.Forms.TextBox DeviceIdTb;
        private System.Windows.Forms.Label deviceIdlb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPokemon;
        private System.Windows.Forms.TabControl tcPokemonDetail;
        private System.Windows.Forms.TabPage tabCatch;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckBox cbAutoFavoritePokemon;
        private System.Windows.Forms.TextBox tbFavoriteMinIvPercentage;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbUseBerriesOperator;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbUseBerriesMinCp;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tbUseBerriesMinIv;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tbUseBerriesBelowCatchProbability;
        private System.Windows.Forms.TextBox tbMaxPokeballsPerPokemon;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUseMasterBallBelowCatchProbability;
        private System.Windows.Forms.TextBox tbUseGreatBallAboveCp;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUseUltraBallBelowCatchProbability;
        private System.Windows.Forms.TextBox tbUseUltraBallAboveCp;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUseGreatBallBelowCatchProbability;
        private System.Windows.Forms.TextBox tbUseMasterBallAboveCp;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUseUltraBallAboveIv;
        private System.Windows.Forms.TextBox tbUseGreatBallAboveIv;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbIgnoreAll;
        private System.Windows.Forms.CheckedListBox clbIgnore;
        private System.Windows.Forms.TextBox tBMaxBerriesToUsePerPokemon;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbUseEggIncubators;
        private System.Windows.Forms.CheckBox cbCatchPoke;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNotTransferAll;
        private System.Windows.Forms.CheckedListBox clbTransfer;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cbUseKeepMinLvl;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbKeepMinLvl;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbTransferDuplicatePokemonOnCapture;
        private System.Windows.Forms.CheckBox cbTransferDuplicatePokemon;
        private System.Windows.Forms.CheckBox cbTransferWeakPokemon;
        private System.Windows.Forms.TextBox tbKeepMinDuplicatePokemon;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbPrioritizeIvOverCp;
        private System.Windows.Forms.TextBox tbKeepMinIV;
        private System.Windows.Forms.ComboBox cbKeepMinOperator;
        private System.Windows.Forms.TextBox tbKeepMinCp;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabPowerUp;
        private System.Windows.Forms.CheckBox cbPowerUpFav;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbPowerUpMinIV;
        private System.Windows.Forms.ComboBox cbPowerUpCondiction;
        private System.Windows.Forms.TextBox tbPowerUpMinCP;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbPowerUpMinStarDust;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbPowerUpType;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbPowerUpAll;
        private System.Windows.Forms.CheckedListBox clbPowerUp;
        private System.Windows.Forms.CheckBox cbAutoPowerUp;
        private System.Windows.Forms.TabPage tabEvo;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox tbUseLuckyEggsMinPokemonAmount;
        private System.Windows.Forms.CheckBox cbUseLuckyEggsWhileEvolving;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbEvoAboveIV;
        private System.Windows.Forms.CheckBox cbEvoAllAboveIV;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox cbEvolveAllPokemonWithEnoughCandy;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbEvolveKeptPokemonsAtStorageUsagePercentage;
        private System.Windows.Forms.CheckBox cbKeepPokemonsThatCanEvolve;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbEvolveAll;
        private System.Windows.Forms.CheckedListBox clbEvolve;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotalAmountOfPokeballsToKeep;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbTotalAmountOfPotionsToKeep;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbTotalAmountOfRevivesToKeep;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbTotalAmountOfBerriesToKeep;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox cbUseIncenseConstantly;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox cbUseLuckyEggConstantly;
        private System.Windows.Forms.TabPage tabAdvSetting;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox cbVerboseRecycling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRecycleInventoryAtUsagePercentage;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox cbDisableHumanWalking;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tbWalkingSpeedVariantInKilometerPerHour;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tbMaxSpawnLocationOffset;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tbMaxTravelDistanceInMeters;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tbDelayBetweenPlayerActions;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tbDelayBetweenPokemonCatch;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.CheckBox cbRandomizeRecycle;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tbRandomRecycleValue;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.CheckBox cbEnableHumanizedThrows;
        private System.Windows.Forms.TextBox tbForceExcellentThrowOverCp;
        private System.Windows.Forms.TextBox tbForceGreatThrowOverCp;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tbForceExcellentThrowOverIv;
        private System.Windows.Forms.TextBox tbNiceThrowChance;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox tbForceGreatThrowOverIv;
        private System.Windows.Forms.TextBox tbGreatThrowChance;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tbCurveThrowChance;
        private System.Windows.Forms.TextBox tbExcellentThrowChance;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox GoogleApiBox;
        private System.Windows.Forms.Label GoogleApiLabel;
        private System.Windows.Forms.CheckBox cbShowWalkingSpeed;
        private System.Windows.Forms.CheckBox cbUseWalkingSpeedVariant;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox tbDelayBetweenRecycle;
    }
}