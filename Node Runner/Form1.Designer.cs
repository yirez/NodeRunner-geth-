﻿namespace Node_Runner
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
            this.txtGenesisFilePath = new System.Windows.Forms.TextBox();
            this.findGenedisFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnFindGenesis = new System.Windows.Forms.Button();
            this.btnFindDataDir = new System.Windows.Forms.Button();
            this.txtDataFolder = new System.Windows.Forms.TextBox();
            this.dataDirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNodeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetworkID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRPCPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPrimary = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstStaticNodes = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.btnPeerCount = new System.Windows.Forms.Button();
            this.btnNodeInfo = new System.Windows.Forms.Button();
            this.btnConnectedPeers = new System.Windows.Forms.Button();
            this.nmrcVerbosity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartRPC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lstRPCExposeAPIs = new System.Windows.Forms.ListBox();
            this.txtRPCExposeCors = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRPCExposePort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRPCExposeHost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstPrevNodes = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.customTabControl1 = new System.Windows.Forms.CustomTabControl();
            this.btnAccountList = new System.Windows.Forms.Button();
            this.btnGethMine = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcVerbosity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGenesisFilePath
            // 
            this.txtGenesisFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGenesisFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenesisFilePath.ForeColor = System.Drawing.SystemColors.Info;
            this.txtGenesisFilePath.Location = new System.Drawing.Point(79, 68);
            this.txtGenesisFilePath.Multiline = true;
            this.txtGenesisFilePath.Name = "txtGenesisFilePath";
            this.txtGenesisFilePath.Size = new System.Drawing.Size(153, 47);
            this.txtGenesisFilePath.TabIndex = 1;
            // 
            // findGenedisFileDialog
            // 
            this.findGenedisFileDialog.FileName = "CustomGenesis.json";
            // 
            // btnFindGenesis
            // 
            this.btnFindGenesis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFindGenesis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindGenesis.Location = new System.Drawing.Point(238, 68);
            this.btnFindGenesis.Name = "btnFindGenesis";
            this.btnFindGenesis.Size = new System.Drawing.Size(80, 20);
            this.btnFindGenesis.TabIndex = 2;
            this.btnFindGenesis.Text = "Browse";
            this.btnFindGenesis.UseVisualStyleBackColor = false;
            this.btnFindGenesis.Click += new System.EventHandler(this.btnFindGenesis_Click);
            // 
            // btnFindDataDir
            // 
            this.btnFindDataDir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFindDataDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindDataDir.Location = new System.Drawing.Point(238, 152);
            this.btnFindDataDir.Name = "btnFindDataDir";
            this.btnFindDataDir.Size = new System.Drawing.Size(75, 20);
            this.btnFindDataDir.TabIndex = 2;
            this.btnFindDataDir.Text = "Browse";
            this.btnFindDataDir.UseVisualStyleBackColor = false;
            this.btnFindDataDir.Click += new System.EventHandler(this.btnFindDataDir_Click);
            // 
            // txtDataFolder
            // 
            this.txtDataFolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDataFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataFolder.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDataFolder.Location = new System.Drawing.Point(79, 125);
            this.txtDataFolder.Multiline = true;
            this.txtDataFolder.Name = "txtDataFolder";
            this.txtDataFolder.Size = new System.Drawing.Size(153, 47);
            this.txtDataFolder.TabIndex = 1;
            this.txtDataFolder.Text = "D:\\blockchain_critical\\Ethereum\\customchain1\\node1\\chain";
            this.txtDataFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataFolder_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(9, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Dir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Node Name:";
            // 
            // txtNodeID
            // 
            this.txtNodeID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNodeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNodeID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNodeID.Location = new System.Drawing.Point(79, 42);
            this.txtNodeID.Name = "txtNodeID";
            this.txtNodeID.Size = new System.Drawing.Size(141, 20);
            this.txtNodeID.TabIndex = 10;
            this.txtNodeID.Text = "CustomChainPOCNode1";
            this.txtNodeID.TextChanged += new System.EventHandler(this.txtNodeID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Network ID:";
            // 
            // txtNetworkID
            // 
            this.txtNetworkID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetworkID.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNetworkID.Location = new System.Drawing.Point(79, 16);
            this.txtNetworkID.Name = "txtNetworkID";
            this.txtNetworkID.Size = new System.Drawing.Size(141, 20);
            this.txtNetworkID.TabIndex = 14;
            this.txtNetworkID.Text = "2147483645";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(226, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "RPC Port:";
            // 
            // txtRPCPort
            // 
            this.txtRPCPort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRPCPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRPCPort.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRPCPort.Location = new System.Drawing.Point(286, 41);
            this.txtRPCPort.Name = "txtRPCPort";
            this.txtRPCPort.Size = new System.Drawing.Size(32, 20);
            this.txtRPCPort.TabIndex = 16;
            this.txtRPCPort.Text = "8102";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(226, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPort.Location = new System.Drawing.Point(270, 16);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 20);
            this.txtPort.TabIndex = 18;
            this.txtPort.Text = "30302";
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartStop.ForeColor = System.Drawing.SystemColors.Info;
            this.btnStartStop.Location = new System.Drawing.Point(12, 390);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(150, 77);
            this.btnStartStop.TabIndex = 21;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Genesis:";
            // 
            // chkPrimary
            // 
            this.chkPrimary.AutoSize = true;
            this.chkPrimary.ForeColor = System.Drawing.SystemColors.Info;
            this.chkPrimary.Location = new System.Drawing.Point(238, 108);
            this.chkPrimary.Name = "chkPrimary";
            this.chkPrimary.Size = new System.Drawing.Size(75, 30);
            this.chkPrimary.TabIndex = 23;
            this.chkPrimary.Text = "PRIMARY\r\nNODE";
            this.chkPrimary.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstStaticNodes);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 104);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static Nodes";
            // 
            // lstStaticNodes
            // 
            this.lstStaticNodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstStaticNodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStaticNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStaticNodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstStaticNodes.Location = new System.Drawing.Point(3, 16);
            this.lstStaticNodes.Name = "lstStaticNodes";
            this.lstStaticNodes.Size = new System.Drawing.Size(318, 85);
            this.lstStaticNodes.TabIndex = 0;
            this.lstStaticNodes.UseCompatibleStateImageBehavior = false;
            this.lstStaticNodes.View = System.Windows.Forms.View.List;
            this.lstStaticNodes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstStaticNodes_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFindGenesis);
            this.groupBox3.Controls.Add(this.txtDataFolder);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtGenesisFilePath);
            this.groupBox3.Controls.Add(this.btnFindDataDir);
            this.groupBox3.Controls.Add(this.txtNodeID);
            this.groupBox3.Controls.Add(this.chkPrimary);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNetworkID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtRPCPort);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 179);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Info";
            // 
            // txtCommands
            // 
            this.txtCommands.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommands.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCommands.Location = new System.Drawing.Point(342, 4);
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(247, 20);
            this.txtCommands.TabIndex = 34;
            this.txtCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommands_KeyDown);
            // 
            // btnPeerCount
            // 
            this.btnPeerCount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPeerCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPeerCount.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPeerCount.Location = new System.Drawing.Point(949, 3);
            this.btnPeerCount.Name = "btnPeerCount";
            this.btnPeerCount.Size = new System.Drawing.Size(75, 23);
            this.btnPeerCount.TabIndex = 35;
            this.btnPeerCount.Text = "Peer Count";
            this.btnPeerCount.UseVisualStyleBackColor = false;
            this.btnPeerCount.Click += new System.EventHandler(this.btnPeerCount_Click);
            // 
            // btnNodeInfo
            // 
            this.btnNodeInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNodeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNodeInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnNodeInfo.Location = new System.Drawing.Point(595, 3);
            this.btnNodeInfo.Name = "btnNodeInfo";
            this.btnNodeInfo.Size = new System.Drawing.Size(63, 23);
            this.btnNodeInfo.TabIndex = 36;
            this.btnNodeInfo.Text = "Node Info";
            this.btnNodeInfo.UseVisualStyleBackColor = false;
            this.btnNodeInfo.Click += new System.EventHandler(this.btnNodeInfo_Click);
            // 
            // btnConnectedPeers
            // 
            this.btnConnectedPeers.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConnectedPeers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectedPeers.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConnectedPeers.Location = new System.Drawing.Point(846, 3);
            this.btnConnectedPeers.Name = "btnConnectedPeers";
            this.btnConnectedPeers.Size = new System.Drawing.Size(97, 23);
            this.btnConnectedPeers.TabIndex = 37;
            this.btnConnectedPeers.Text = "Connected Peers";
            this.btnConnectedPeers.UseVisualStyleBackColor = false;
            this.btnConnectedPeers.Click += new System.EventHandler(this.btnConnectedPeers_Click);
            // 
            // nmrcVerbosity
            // 
            this.nmrcVerbosity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nmrcVerbosity.ForeColor = System.Drawing.SystemColors.Info;
            this.nmrcVerbosity.Location = new System.Drawing.Point(720, 5);
            this.nmrcVerbosity.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nmrcVerbosity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcVerbosity.Name = "nmrcVerbosity";
            this.nmrcVerbosity.Size = new System.Drawing.Size(39, 20);
            this.nmrcVerbosity.TabIndex = 38;
            this.nmrcVerbosity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmrcVerbosity.ValueChanged += new System.EventHandler(this.nmrcVerbosity_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(664, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Verbosity";
            // 
            // btnMine
            // 
            this.btnMine.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMine.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMine.Location = new System.Drawing.Point(186, 390);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(150, 48);
            this.btnMine.TabIndex = 40;
            this.btnMine.Text = "START MINING";
            this.btnMine.UseVisualStyleBackColor = false;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartRPC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lstRPCExposeAPIs);
            this.groupBox1.Controls.Add(this.txtRPCExposeCors);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRPCExposePort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRPCExposeHost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 116);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPC Control";
            // 
            // btnStartRPC
            // 
            this.btnStartRPC.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStartRPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartRPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartRPC.Location = new System.Drawing.Point(124, 69);
            this.btnStartRPC.Name = "btnStartRPC";
            this.btnStartRPC.Size = new System.Drawing.Size(189, 43);
            this.btnStartRPC.TabIndex = 41;
            this.btnStartRPC.Text = "START RPC";
            this.btnStartRPC.UseVisualStyleBackColor = false;
            this.btnStartRPC.Click += new System.EventHandler(this.btnStartRPC_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "APIs:";
            // 
            // lstRPCExposeAPIs
            // 
            this.lstRPCExposeAPIs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstRPCExposeAPIs.ForeColor = System.Drawing.SystemColors.Info;
            this.lstRPCExposeAPIs.FormattingEnabled = true;
            this.lstRPCExposeAPIs.Items.AddRange(new object[] {
            "eth",
            "web3",
            "net",
            "shh",
            "bzz",
            "les"});
            this.lstRPCExposeAPIs.Location = new System.Drawing.Point(44, 69);
            this.lstRPCExposeAPIs.Name = "lstRPCExposeAPIs";
            this.lstRPCExposeAPIs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRPCExposeAPIs.Size = new System.Drawing.Size(74, 43);
            this.lstRPCExposeAPIs.TabIndex = 30;
            // 
            // txtRPCExposeCors
            // 
            this.txtRPCExposeCors.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRPCExposeCors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRPCExposeCors.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRPCExposeCors.Location = new System.Drawing.Point(174, 43);
            this.txtRPCExposeCors.Name = "txtRPCExposeCors";
            this.txtRPCExposeCors.Size = new System.Drawing.Size(139, 20);
            this.txtRPCExposeCors.TabIndex = 28;
            this.txtRPCExposeCors.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(144, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Cors:";
            // 
            // txtRPCExposePort
            // 
            this.txtRPCExposePort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRPCExposePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRPCExposePort.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRPCExposePort.Location = new System.Drawing.Point(44, 43);
            this.txtRPCExposePort.Name = "txtRPCExposePort";
            this.txtRPCExposePort.Size = new System.Drawing.Size(94, 20);
            this.txtRPCExposePort.TabIndex = 26;
            this.txtRPCExposePort.Text = "8545";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Port:";
            // 
            // txtRPCExposeHost
            // 
            this.txtRPCExposeHost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRPCExposeHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRPCExposeHost.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRPCExposeHost.Location = new System.Drawing.Point(44, 17);
            this.txtRPCExposeHost.Name = "txtRPCExposeHost";
            this.txtRPCExposeHost.Size = new System.Drawing.Size(269, 20);
            this.txtRPCExposeHost.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Host:";
            // 
            // lstPrevNodes
            // 
            this.lstPrevNodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstPrevNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPrevNodes.ForeColor = System.Drawing.SystemColors.Info;
            this.lstPrevNodes.Location = new System.Drawing.Point(3, 16);
            this.lstPrevNodes.Name = "lstPrevNodes";
            this.lstPrevNodes.Size = new System.Drawing.Size(318, 59);
            this.lstPrevNodes.TabIndex = 41;
            this.lstPrevNodes.UseCompatibleStateImageBehavior = false;
            this.lstPrevNodes.View = System.Windows.Forms.View.List;
            this.lstPrevNodes.SelectedIndexChanged += new System.EventHandler(this.lstPrevNodes_SelectedIndexChanged);
            this.lstPrevNodes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstPrevNodes_MouseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPrevNodes);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Location = new System.Drawing.Point(12, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 78);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Previous Nodes";
            // 
            // customTabControl1
            // 
            this.customTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customTabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Rounded;
            // 
            // 
            // 
            this.customTabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.customTabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.customTabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.customTabControl1.DisplayStyleProvider.FocusTrack = false;
            this.customTabControl1.DisplayStyleProvider.HotTrack = true;
            this.customTabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customTabControl1.DisplayStyleProvider.Opacity = 1F;
            this.customTabControl1.DisplayStyleProvider.Overlap = 0;
            this.customTabControl1.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.customTabControl1.DisplayStyleProvider.Radius = 10;
            this.customTabControl1.DisplayStyleProvider.ShowTabCloser = true;
            this.customTabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.Info;
            this.customTabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.Highlight;
            this.customTabControl1.HotTrack = true;
            this.customTabControl1.Location = new System.Drawing.Point(342, 30);
            this.customTabControl1.Multiline = true;
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(691, 559);
            this.customTabControl1.TabIndex = 41;
            this.customTabControl1.SelectedIndexChanged += new System.EventHandler(this.customTabControl1_SelectedIndexChanged);
            // 
            // btnAccountList
            // 
            this.btnAccountList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAccountList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccountList.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAccountList.Location = new System.Drawing.Point(765, 3);
            this.btnAccountList.Name = "btnAccountList";
            this.btnAccountList.Size = new System.Drawing.Size(75, 23);
            this.btnAccountList.TabIndex = 42;
            this.btnAccountList.Text = "Accounts";
            this.btnAccountList.UseVisualStyleBackColor = false;
            this.btnAccountList.Click += new System.EventHandler(this.btnAccountList_Click);
            // 
            // btnGethMine
            // 
            this.btnGethMine.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGethMine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGethMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGethMine.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGethMine.Location = new System.Drawing.Point(186, 444);
            this.btnGethMine.Name = "btnGethMine";
            this.btnGethMine.Size = new System.Drawing.Size(150, 23);
            this.btnGethMine.TabIndex = 43;
            this.btnGethMine.Text = "GETH MINE";
            this.btnGethMine.UseVisualStyleBackColor = false;
            this.btnGethMine.Click += new System.EventHandler(this.btnGethMine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1042, 596);
            this.Controls.Add(this.btnGethMine);
            this.Controls.Add(this.btnAccountList);
            this.Controls.Add(this.customTabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrcVerbosity);
            this.Controls.Add(this.btnConnectedPeers);
            this.Controls.Add(this.btnNodeInfo);
            this.Controls.Add(this.btnPeerCount);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStartStop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Node Runner v0.0.1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcVerbosity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenesisFilePath;
        private System.Windows.Forms.OpenFileDialog findGenedisFileDialog;
        private System.Windows.Forms.Button btnFindGenesis;
        private System.Windows.Forms.Button btnFindDataDir;
        private System.Windows.Forms.TextBox txtDataFolder;
        private System.Windows.Forms.FolderBrowserDialog dataDirBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNodeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetworkID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRPCPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPrimary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Button btnPeerCount;
        private System.Windows.Forms.Button btnNodeInfo;
        private System.Windows.Forms.Button btnConnectedPeers;
        private System.Windows.Forms.NumericUpDown nmrcVerbosity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.ListView lstStaticNodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartRPC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstRPCExposeAPIs;
        private System.Windows.Forms.TextBox txtRPCExposeCors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRPCExposePort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRPCExposeHost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstPrevNodes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CustomTabControl customTabControl1;
        private System.Windows.Forms.Button btnAccountList;
        private System.Windows.Forms.Button btnGethMine;
    }
}

