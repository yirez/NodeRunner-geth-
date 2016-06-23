using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Windows.Forms;

namespace Node_Runner
{
    public partial class Form1 : Form
    {
        private static bool isRunning = false;
        private static bool isMining = false;
        private static Node activeNode = null;
        private Process process = null;


        public Form1()
        {
            InitializeComponent(); 
            toggleGethFunctionalityButtons(false,false);
        }

        #region UI interactions
        private void nmrcVerbosity_ValueChanged(object sender, EventArgs e)
        {
            sendCommandToConsole("debug.verbosity(" + nmrcVerbosity.Value + ")"); 
        }

        private void btnPeerCount_Click(object sender, EventArgs e)
        {
            sendCommandToConsole("net.peerCount"); 
        }

        private void btnConnectedPeers_Click(object sender, EventArgs e)
        {
            sendCommandToConsole("admin.peers"); 
        }

        private void btnNodeInfo_Click(object sender, EventArgs e)
        {
            sendCommandToConsole("admin.nodeInfo"); 
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            try
            {
                btnStartStop.Enabled = false;
                isMining = true;
                refreshStaticNodeList();
                if (!isRunning)
                {
                    backgroundWorkerProcessHandler.RunWorkerAsync();
                    btnMine.Text = "STOP MINING";
                }
                else
                {
                    backgroundWorkerProcessHandler.CancelAsync();
                    stopGeth();
                    btnMine.Text = "START MINING";
                }
            }
            catch (Exception ex)
            {
                btnStartStop.Enabled = true;
                isRunning = false;
                btnMine.Text = "START MINING";
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        } 
        private void btnFindGenesis_Click(object sender, EventArgs e)
        {
            DialogResult result = findGenedisFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtGenesisFilePath.Text = findGenedisFileDialog.FileName;
            }
        }
        private void btnFindDataDir_Click(object sender, EventArgs e)
        {
            DialogResult result = dataDirBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDataFolder.Text = dataDirBrowserDialog.SelectedPath;
                if (File.Exists(Path.Combine(txtDataFolder.Text, "static-nodes.json")))
                    refreshStaticNodeList();
            } 

        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                btnMine.Enabled = false;
                isMining=false;
                refreshStaticNodeList();
                if (!isRunning)
                {
                    backgroundWorkerProcessHandler.RunWorkerAsync(); 
                    btnStartStop.Text = "STOP";
                }
                else
                {
                    btnMine.Enabled = true;
                    backgroundWorkerProcessHandler.CancelAsync();
                    stopGeth();
                    btnStartStop.Text = "START";
                }
            }
            catch (Exception ex)
            {
                btnMine.Enabled = true;
                isRunning = false;
                btnStartStop.Text = "START";
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtDataFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refreshStaticNodeList();
            }
        }

        private void txtCommands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendCommandToConsole(txtCommands.Text);  

                if (txtCommands.Text.Contains("exit"))
                {
                    backgroundWorkerProcessHandler.CancelAsync();
                    stopGeth();
                    btnStartStop.Text = "START";
                }
                txtCommands.Text = string.Empty;

            }
        }
         
        private void lstStaticNodes_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != lstStaticNodes) return;

            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard();
        } 

        #endregion

        #region UI support methods
        private void refreshStaticNodeList()
        {
            lstStaticNodes.Items.Clear();

            if (!Directory.Exists(txtDataFolder.Text))
                return;

            string[] staticNodeData = File.ReadAllLines(Path.Combine(txtDataFolder.Text, "static-nodes.json"));

            foreach (string node in staticNodeData)
            {
                if (node.Contains("enode"))
                    lstStaticNodes.Items.Add(node);
            }

        }

        private void CopySelectedValuesToClipboard()
        {
            var builder = new StringBuilder();
            foreach (ListViewItem item in lstStaticNodes.SelectedItems)
                builder.AppendLine(item.SubItems[0].Text);

            Clipboard.SetText(builder.ToString());
        }
        private void toggleGethFunctionalityButtons(bool status,bool invokeRequired=true)
        {
            if (invokeRequired)
            {
                Invoke(new Action(() => btnNodeInfo.Enabled = status));
                Invoke(new Action(() => btnConnectedPeers.Enabled = status));
                Invoke(new Action(() => btnPeerCount.Enabled = status));
                Invoke(new Action(() => nmrcVerbosity.Enabled = status));
            }
            else
            {
                btnNodeInfo.Enabled = status;
                btnConnectedPeers.Enabled = status;
                btnPeerCount.Enabled = status;
                nmrcVerbosity.Enabled = status;
            }
        }

        private void sendCommandToConsole(string command)
        {
            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
        }
        #endregion

        #region Command handler thread

        private void backgroundWorkerProcessHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                createNode();
                startGeth();
            }
            catch (Exception ex)
            {

                toggleGethFunctionalityButtons(false);
                isRunning = false;
                Invoke(new Action(() => btnStartStop.Text = "START"));
                Invoke(new Action(() => MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)));
            }
        }
        #endregion

        #region Assertions
        private void assertDataValid()
        {

            if (!Directory.Exists(txtDataFolder.Text) || string.IsNullOrEmpty(txtDataFolder.Text))
                throw new Exception("Data directory path does not exist. Create a data directory with a genesis file.");

            if (!chkPrimary.Checked && string.IsNullOrEmpty(txtPort.Text))
                throw new Exception("Empty port on secondary nodes not allowed");

            if (string.IsNullOrEmpty(txtRPCPort.Text))
                throw new Exception("RPC port cannot be empty");

            if (string.IsNullOrEmpty(txtNodeID.Text))
                throw new Exception("Node name cannot be empty");
        }
        #endregion

         
        private void startContainerCommandProcess(string parameters)
        { 
            string gethPath = activeNode.DataDirPath.Remove(activeNode.DataDirPath.LastIndexOf("\\"));
            process = new Process();

            process.StartInfo.FileName = Path.Combine(gethPath, "geth.exe");
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = parameters;

            StringBuilder output = new StringBuilder();
            StringBuilder error = new StringBuilder();

            using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
            using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
            {
                process.OutputDataReceived += (sender, e) =>
                { 
                    Invoke(new Action(() => txtLogs.AppendText(e.Data + Environment.NewLine)));
                };
                process.ErrorDataReceived += (sender, e) =>
                {
                    Invoke(new Action(() => txtLogs.AppendText(e.Data + Environment.NewLine)));
                };


                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                //takes some time to get geth running
                Thread.Sleep(2000);

                toggleGethFunctionalityButtons(true);

                process.WaitForExit();
            }
        }

        private string formGethStartString()
        {
            StringBuilder gethChainCommand = new StringBuilder();
            //nothing in chain (no chain data), must have genesis to rebuild
            if (!Directory.Exists(Path.Combine(activeNode.DataDirPath, "chaindata")) 
                || Directory.GetFiles(Path.Combine(activeNode.DataDirPath, "chaindata")).Length == 0)
            {
                gethChainCommand.Append(" --genesis ").Append(activeNode.GenesisFilePath);
            }

            if (!chkPrimary.Checked)
            {
                gethChainCommand.Append(" --port ").Append(activeNode.Port);
                gethChainCommand.Append(" --ipcpath ~/Library/Ethereum/").Append(activeNode.NodeName).Append("/geth.ipc");
            }

            if (activeNode.Verbosity > 0)
                gethChainCommand.Append(" --verbosity ").Append(activeNode.Verbosity);

            gethChainCommand.Append(" --datadir ").Append(activeNode.DataDirPath)
            .Append(" --identity ").Append(activeNode.NodeName);


            if (activeNode.BlockChainVersion > 0)
                gethChainCommand.Append(" --blockchainversion ").Append(activeNode.BlockChainVersion);


            gethChainCommand.Append(" --networkid ").Append(activeNode.NetworkID)
            .Append(" --rpcport ").Append(activeNode.RpcPort);

            if (activeNode.MaxPeers > 0)
                gethChainCommand.Append(" --maxpeers ").Append(activeNode.MaxPeers);

            gethChainCommand.Append(" console ");

            return gethChainCommand.ToString();
        }

        private string formGethMiningString()
        {
            StringBuilder gethChainCommand = new StringBuilder(); 

            if (!chkPrimary.Checked)
            {
                gethChainCommand.Append(" --port ").Append(activeNode.Port);
                gethChainCommand.Append(" --ipcpath ~/Library/Ethereum/").Append(activeNode.NodeName).Append("/geth.ipc");
            }

            if (activeNode.Verbosity > 0)
                gethChainCommand.Append(" --verbosity ").Append(activeNode.Verbosity);

            gethChainCommand.Append(" --datadir ").Append(activeNode.DataDirPath)
            .Append(" --identity ").Append(activeNode.NodeName);


            if (activeNode.BlockChainVersion > 0)
                gethChainCommand.Append(" --blockchainversion ").Append(activeNode.BlockChainVersion);


            gethChainCommand.Append(" --networkid ").Append(activeNode.NetworkID)
            .Append(" --rpcport ").Append(activeNode.RpcPort);

            if (activeNode.MaxPeers > 0)
                gethChainCommand.Append(" --maxpeers ").Append(activeNode.MaxPeers);

            gethChainCommand.Append(" --mine -rpccorsdomain \"*\" --ipcapi \"admin,eth,miner\" --rpcapi \"eth,web3\" --networkid 2147483645 --blockchainversion 12 -maxpeers 5 --minerthreads 1 console ");

            return gethChainCommand.ToString();
        }

        /// <summary>
        /// starts geth with a string formed with global node object
        /// </summary>
        private void startGeth()
        {
            isRunning = true;
            string gethStartCommand = formGethStartString();
            if(isMining)
              gethStartCommand = formGethMiningString();

            startContainerCommandProcess(gethStartCommand); 
        }

        /// <summary>
        /// forces geth exit and closes process
        /// </summary>
        private void stopGeth()
        {
            isRunning = false;
            sendCommandToConsole("exit"); 
            process.StandardInput.Close(); 
            process.Close(); 
        }

        /// <summary>
        /// creates a global node object with some default elements like verbocity and peercount
        /// </summary>
        private void createNode()
        {
            assertDataValid();

            activeNode = new Node();
            activeNode.BlockChainVersion = 12;
            activeNode.MaxPeers = 15;
            activeNode.NodeName = txtNodeID.Text;
            activeNode.NetworkID = int.Parse(txtNetworkID.Text);
            activeNode.Port = (chkPrimary.Checked ? 0 : int.Parse(txtRPCPort.Text));
            activeNode.RpcPort = int.Parse(txtRPCPort.Text);
            activeNode.IPCPath = (chkPrimary.Checked ? null : "--ipcpath ~/Library/Ethereum/" + activeNode.NodeName + "/geth.ipc");
            activeNode.DataDirPath = txtDataFolder.Text;

            if (string.IsNullOrEmpty(txtGenesisFilePath.Text) && Directory.GetFiles(txtDataFolder.Text).Length == 0)
            {
                MessageBox.Show("Genesis not used and data dir has no chain info. Try again with genesis in case of problem.", "No genesis and empty data dir", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            activeNode.GenesisFilePath = txtGenesisFilePath.Text;
        } 
       
    }
}
