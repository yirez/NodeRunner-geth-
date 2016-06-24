namespace Node_Runner
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
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPrimary = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstStaticNodes = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorkerProcessHandler = new System.ComponentModel.BackgroundWorker();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.btnPeerCount = new System.Windows.Forms.Button();
            this.btnNodeInfo = new System.Windows.Forms.Button();
            this.btnConnectedPeers = new System.Windows.Forms.Button();
            this.nmrcVerbosity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcVerbosity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenesisFilePath
            // 
            this.txtGenesisFilePath.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGenesisFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenesisFilePath.ForeColor = System.Drawing.SystemColors.Info;
            this.txtGenesisFilePath.Location = new System.Drawing.Point(88, 68);
            this.txtGenesisFilePath.Name = "txtGenesisFilePath";
            this.txtGenesisFilePath.Size = new System.Drawing.Size(225, 20);
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
            this.btnFindGenesis.Location = new System.Drawing.Point(88, 92);
            this.btnFindGenesis.Name = "btnFindGenesis";
            this.btnFindGenesis.Size = new System.Drawing.Size(75, 20);
            this.btnFindGenesis.TabIndex = 2;
            this.btnFindGenesis.Text = "Browse";
            this.btnFindGenesis.UseVisualStyleBackColor = false;
            this.btnFindGenesis.Click += new System.EventHandler(this.btnFindGenesis_Click);
            // 
            // btnFindDataDir
            // 
            this.btnFindDataDir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFindDataDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindDataDir.Location = new System.Drawing.Point(88, 146);
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
            this.txtDataFolder.Location = new System.Drawing.Point(88, 125);
            this.txtDataFolder.Name = "txtDataFolder";
            this.txtDataFolder.Size = new System.Drawing.Size(225, 20);
            this.txtDataFolder.TabIndex = 1;
            this.txtDataFolder.Text = "D:\\blockchain_critical\\Ethereum\\customchain1\\node1\\chain";
            this.txtDataFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataFolder_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(18, 45);
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
            this.txtNodeID.Location = new System.Drawing.Point(88, 42);
            this.txtNodeID.Name = "txtNodeID";
            this.txtNodeID.Size = new System.Drawing.Size(225, 20);
            this.txtNodeID.TabIndex = 10;
            this.txtNodeID.Text = "CustomChainPOCNode1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(18, 19);
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
            this.txtNetworkID.Location = new System.Drawing.Point(88, 16);
            this.txtNetworkID.Name = "txtNetworkID";
            this.txtNetworkID.Size = new System.Drawing.Size(225, 20);
            this.txtNetworkID.TabIndex = 14;
            this.txtNetworkID.Text = "2147483645";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(28, 176);
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
            this.txtRPCPort.Location = new System.Drawing.Point(88, 173);
            this.txtRPCPort.Name = "txtRPCPort";
            this.txtRPCPort.Size = new System.Drawing.Size(75, 20);
            this.txtRPCPort.TabIndex = 16;
            this.txtRPCPort.Text = "8102";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(179, 176);
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
            this.txtPort.Location = new System.Drawing.Point(214, 173);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 20);
            this.txtPort.TabIndex = 18;
            this.txtPort.Text = "30302";
            // 
            // txtLogs
            // 
            this.txtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLogs.Location = new System.Drawing.Point(342, 38);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(677, 420);
            this.txtLogs.TabIndex = 20;
            this.txtLogs.WordWrap = false;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartStop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartStop.Location = new System.Drawing.Point(12, 381);
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
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Genesis File:";
            // 
            // chkPrimary
            // 
            this.chkPrimary.AutoSize = true;
            this.chkPrimary.ForeColor = System.Drawing.SystemColors.Info;
            this.chkPrimary.Location = new System.Drawing.Point(204, 151);
            this.chkPrimary.Name = "chkPrimary";
            this.chkPrimary.Size = new System.Drawing.Size(109, 17);
            this.chkPrimary.TabIndex = 23;
            this.chkPrimary.Text = "PRIMARY NODE";
            this.chkPrimary.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstStaticNodes);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 164);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static Nodes";
            // 
            // lstStaticNodes
            // 
            this.lstStaticNodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstStaticNodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstStaticNodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstStaticNodes.Location = new System.Drawing.Point(7, 20);
            this.lstStaticNodes.Name = "lstStaticNodes";
            this.lstStaticNodes.Size = new System.Drawing.Size(306, 138);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 203);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Info";
            // 
            // backgroundWorkerProcessHandler
            // 
            this.backgroundWorkerProcessHandler.WorkerSupportsCancellation = true;
            this.backgroundWorkerProcessHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerProcessHandler_DoWork);
            // 
            // txtCommands
            // 
            this.txtCommands.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommands.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCommands.Location = new System.Drawing.Point(342, 12);
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(247, 20);
            this.txtCommands.TabIndex = 34;
            this.txtCommands.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommands_KeyDown);
            // 
            // btnPeerCount
            // 
            this.btnPeerCount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPeerCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPeerCount.Location = new System.Drawing.Point(943, 11);
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
            this.btnNodeInfo.Location = new System.Drawing.Point(595, 11);
            this.btnNodeInfo.Name = "btnNodeInfo";
            this.btnNodeInfo.Size = new System.Drawing.Size(75, 23);
            this.btnNodeInfo.TabIndex = 36;
            this.btnNodeInfo.Text = "Node Info";
            this.btnNodeInfo.UseVisualStyleBackColor = false;
            this.btnNodeInfo.Click += new System.EventHandler(this.btnNodeInfo_Click);
            // 
            // btnConnectedPeers
            // 
            this.btnConnectedPeers.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConnectedPeers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnectedPeers.Location = new System.Drawing.Point(834, 11);
            this.btnConnectedPeers.Name = "btnConnectedPeers";
            this.btnConnectedPeers.Size = new System.Drawing.Size(103, 23);
            this.btnConnectedPeers.TabIndex = 37;
            this.btnConnectedPeers.Text = "Connected Peers";
            this.btnConnectedPeers.UseVisualStyleBackColor = false;
            this.btnConnectedPeers.Click += new System.EventHandler(this.btnConnectedPeers_Click);
            // 
            // nmrcVerbosity
            // 
            this.nmrcVerbosity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nmrcVerbosity.ForeColor = System.Drawing.SystemColors.Info;
            this.nmrcVerbosity.Location = new System.Drawing.Point(732, 12);
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
            this.label7.Location = new System.Drawing.Point(676, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Verbosity";
            // 
            // btnMine
            // 
            this.btnMine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMine.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMine.Location = new System.Drawing.Point(186, 381);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(150, 77);
            this.btnMine.TabIndex = 40;
            this.btnMine.Text = "START MINING";
            this.btnMine.UseVisualStyleBackColor = false;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1022, 463);
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
            this.Controls.Add(this.txtLogs);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Node Runner v0.0.1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcVerbosity)).EndInit();
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
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPrimary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProcessHandler;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Button btnPeerCount;
        private System.Windows.Forms.Button btnNodeInfo;
        private System.Windows.Forms.Button btnConnectedPeers;
        private System.Windows.Forms.NumericUpDown nmrcVerbosity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.ListView lstStaticNodes;
    }
}

