using Node_Runner.Base;
using Node_Runner.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Node_Runner
{
    public partial class Form1 : Form
    {
        private GethHelper gethHelper = null;
        private GenericHelper genericHelper = new GenericHelper();
        public Form1()
        {
            InitializeComponent(); 
            toggleGethFunctionalityButtons(false,false);
            txtRPCExposeHost.Text = genericHelper.GetLocalIPAddress();
            lstRPCExposeAPIs.SetSelected(0, true);
            lstRPCExposeAPIs.SetSelected(1, true);
            lstRPCExposeAPIs.SetSelected(2, true);

            gethHelper = new GethHelper(this);
            if (gethHelper.NodeList != null)
                refreshPreviousNodeList(false);
        }

        #region UI interactions        
        private void btnStartRPC_Click(object sender, EventArgs e)
        {
            gethHelper.SendCommandToConsole("admin.startRPC(\""
                + txtRPCExposeHost.Text + "\",\""
                + txtRPCExposePort.Text + "\",\""
                + txtRPCExposeCors.Text + "\")"
                , gethHelper.SelectedActivity.ConnectedProcess);

        }

        private void lstPrevNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPrevNodes.SelectedItems != null && lstPrevNodes.SelectedItems.Count > 0)
            {
                Node node = (Node)lstPrevNodes.SelectedItems[0].Tag;
                txtNodeFolder.Text = node.DataDirPath; 
                txtNetworkID.Text = node.NetworkID.ToString();
                txtNodeID.Text = node.NodeName;
                txtPort.Text = node.Port.ToString();
                txtRPCPort.Text = node.RpcPort.ToString();
                chkPrimary.Checked = node.IsPrimary;
            }
        }
        private void handleTabSelectionChanges()
        {
            gethHelper.SelectedActivity = getSelectedTabActivity(); 
            btnStartStop.Enabled = true;

            if (gethHelper.SelectedActivity != null)
            {
                txtNodeFolder.Text = gethHelper.SelectedActivity.ActiveNode.DataDirPath; 
                txtNetworkID.Text = gethHelper.SelectedActivity.ActiveNode.NetworkID.ToString();
                txtNodeID.Text = gethHelper.SelectedActivity.ActiveNode.NodeName;
                txtPort.Text = gethHelper.SelectedActivity.ActiveNode.Port.ToString();
                txtRPCPort.Text = gethHelper.SelectedActivity.ActiveNode.RpcPort.ToString();
                chkPrimary.Checked = gethHelper.SelectedActivity.ActiveNode.IsPrimary;
                
                refreshStaticNodeList();

                if (!gethHelper.SelectedActivity.IsRunning)
                {
                    btnStartStop.Text = "START"; 
                    toggleGethFunctionalityButtons(false, false);
                }
                else
                {
                    btnStartStop.Text = "STOP"; 
                    toggleGethFunctionalityButtons(true, false);
                }
            }
            else
            {
                txtNodeFolder.Text = string.Empty; 
                txtNetworkID.Text = string.Empty;
                txtNodeID.Text = string.Empty;
                txtPort.Text = string.Empty;
                txtRPCPort.Text = string.Empty;
                chkPrimary.Checked= false;
            }

            // find if any tab is closed, start close operations if so.
            if (customTabControl1.TabCount != gethHelper.ActiveNodeList.Count)
            {
                for (int i = 0; i < gethHelper.ActiveNodeList.ToList().Count; i++)
                {
                    NodeActivity act = gethHelper.ActiveNodeList[i];
                    if (!customTabControl1.TabPages.Contains(act.ParentTab))
                    {
                        stopActivity(act);
                    }
                }
            }

        }
        private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            handleTabSelectionChanges();
        }
        private void lstPrevNodes_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                // Right mouse click
                case MouseButtons.Right:


                    ContextMenu myContextMenu = new ContextMenu();
                     
                    MenuItem menuItem1 = new MenuItem("Delete"); 
                    MenuItem menuItem2 = new MenuItem("Open Data Directory");  


                    // Clear all previously added MenuItems.
                    myContextMenu.MenuItems.Clear(); 
                    myContextMenu.MenuItems.Add(menuItem1); 
                    myContextMenu.MenuItems.Add(menuItem2); 
                    myContextMenu.Show(lstPrevNodes, e.Location, LeftRightAlignment.Right); 
                     
                    menuItem1.Click += delegate
                    {
                        if (lstPrevNodes.SelectedItems != null && lstPrevNodes.SelectedItems.Count > 0)
                        {
                            lstPrevNodes.Items.Remove(lstPrevNodes.SelectedItems[0]);
                        }
                    };

                    menuItem2.Click += delegate
                    {
                        if (lstPrevNodes.SelectedItems != null && lstPrevNodes.SelectedItems.Count>0)
                            genericHelper.OpenDirectory(((Node)lstPrevNodes.SelectedItems[0].Tag).DataDirPath);
                    };
                    break;

            }
        }

        private void txtNodeID_TextChanged(object sender, EventArgs e)
        {

            if (gethHelper.ActiveNodeList == null || !gethHelper.ActiveNodeList.Any(x => x.ActiveNode.NodeName.Equals(txtNodeID.Text)))
            {
                btnStartStop.Text = "START"; 
                btnStartStop.Enabled = true;
                toggleGethFunctionalityButtons(false, false);
            }
            else
            {
                NodeActivity activity = gethHelper.ActiveNodeList.First(x => x.ActiveNode.NodeName.Equals(txtNodeID.Text));
                btnStartStop.Text = "STOP"; 
                toggleGethFunctionalityButtons(true, false);
            }
        }
         
        private void nmrcVerbosity_ValueChanged(object sender, EventArgs e)
        {
            gethHelper.SendCommandToConsole("debug.verbosity(" + nmrcVerbosity.Value + ")", gethHelper.SelectedActivity.ConnectedProcess);
        } 

        private void btnAccountList_Click(object sender, EventArgs e)
        {
            gethHelper.SendCommandToConsole("personal.listAccounts", gethHelper.SelectedActivity.ConnectedProcess);
        }

        private void btnPeerCount_Click(object sender, EventArgs e)
        {
            gethHelper.SendCommandToConsole("net.peerCount", gethHelper.SelectedActivity.ConnectedProcess);
        }

        private void btnConnectedPeers_Click(object sender, EventArgs e)
        {
            gethHelper.SendCommandToConsole("admin.peers", gethHelper.SelectedActivity.ConnectedProcess); ;
        }

        private void btnNodeInfo_Click(object sender, EventArgs e)
        {
            gethHelper.SendCommandToConsole("admin.nodeInfo", gethHelper.SelectedActivity.ConnectedProcess);
        }
         
        private void btnFindDataDir_Click(object sender, EventArgs e)
        {
            DialogResult result = dataDirBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtNodeFolder.Text = dataDirBrowserDialog.SelectedPath;
                if (File.Exists(Path.Combine(txtNodeFolder.Text, "static-nodes.json")))
                    refreshStaticNodeList();
            } 

        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNetworkID.Text) || string.IsNullOrEmpty(txtNodeID.Text))
                return;

            NodeActivity activity = new NodeActivity();
            try
            { 
                if (gethHelper.ActiveNodeList.Any(x => x.ActiveNode.NodeName.Equals(txtNodeID.Text)))
                    activity = gethHelper.ActiveNodeList.First(x => x.ActiveNode.NodeName.Equals(txtNodeID.Text));
                else
                {
                    activity.IsRunning = false;
                    activity.ActiveNode = createNode();
                    createTabAndConsole(activity);
                } 
                refreshStaticNodeList();

                if (!activity.IsRunning)
                {
                    activity.IsRunning = true;
                    var bw = new BackgroundWorker();
                    activity.WorkerThread = bw;

                    gethHelper.ActiveNodeList.Add(activity);
                    toggleGethFunctionalityButtons(true,false);
                    gethHelper.SaveActiveNodeData(activity.ActiveNode);
                    gethHelper.SelectedActivity = activity;
                    handleTabSelectionChanges();

                    refreshPreviousNodeList();

                    bw.WorkerSupportsCancellation = true;
                    bw.DoWork += delegate
                    {

                        gethHelper.StartGeth(activity);
                    };
                    bw.RunWorkerCompleted += delegate
                    {

                        stopActivity(activity);
                    };
                    bw.RunWorkerAsync();
                    btnStartStop.Text = "STOP";
                }
                else
                {
                    stopActivity(activity); 
                }
            }
            catch (Exception ex)
            { 
                activity.IsRunning = false;
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
                gethHelper.SendCommandToConsole(txtCommands.Text, gethHelper.SelectedActivity.ConnectedProcess);

                if (txtCommands.Text.Contains("exit"))
                {
                    if (gethHelper.SelectedActivity != null)
                    {
                        stopActivity(gethHelper.SelectedActivity);
                    }
                }
                txtCommands.Text = string.Empty;

            }
        }
         
        private void lstStaticNodes_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != lstStaticNodes) return;

            if (e.Control && e.KeyCode == Keys.C)
                copySelectedValuesToClipboard();
        } 

        #endregion

        #region UI support methods
        private NodeActivity getSelectedTabActivity()
        {
            if (customTabControl1.SelectedTab != null)
            {
                return gethHelper.ActiveNodeList.FirstOrDefault(x => x.ParentTab == customTabControl1.SelectedTab);
            }

            return null;
        } 

        private void refreshStaticNodeList()
        {
            lstStaticNodes.Items.Clear();

            if (Directory.Exists(txtNodeFolder.Text) && File.Exists(Path.Combine(txtNodeFolder.Text + "\\dataDir\\", "static-nodes.json")))
            {
                string[] staticNodeData = File.ReadAllLines(Path.Combine(txtNodeFolder.Text + "\\dataDir\\", "static-nodes.json"));

                foreach (string node in staticNodeData)
                {
                    if (node.Contains("enode"))
                        lstStaticNodes.Items.Add(node);
                }
            } 
        }

        private void refreshPreviousNodeList(bool invokeRequired=true)
        {
            if (invokeRequired)
                Invoke(new Action(() => lstPrevNodes.Items.Clear()));
            else
                lstPrevNodes.Items.Clear();
            

            if (gethHelper.NodeList==null)
                return;


            foreach (Node node in gethHelper.NodeList)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = node;
                item.Text = node.NodeName;
                if (invokeRequired)
                    Invoke(new Action(() => lstPrevNodes.Items.Add(item)));
                else
                    lstPrevNodes.Items.Add(item);
            }

        }

        private void copySelectedValuesToClipboard()
        {
            if (lstStaticNodes.SelectedItems != null)
            {
                var builder = new StringBuilder();
                foreach (ListViewItem item in lstStaticNodes.SelectedItems)
                    builder.AppendLine(item.SubItems[0].Text);
                Clipboard.SetText(builder.ToString());
            }

        }
        private void toggleGethFunctionalityButtons(bool status,bool invokeRequired=true)
        {
            if (invokeRequired)
            {
                Invoke(new Action(() => btnNodeInfo.Enabled = status));
                Invoke(new Action(() => btnConnectedPeers.Enabled = status));
                Invoke(new Action(() => btnPeerCount.Enabled = status));
                Invoke(new Action(() => nmrcVerbosity.Enabled = status));
                Invoke(new Action(() => txtCommands.Enabled = status));
                Invoke(new Action(() => btnStartRPC.Enabled = status));
                Invoke(new Action(() => btnAccountList.Enabled = status)); 
            }
            else
            {
                btnNodeInfo.Enabled = status;
                btnConnectedPeers.Enabled = status;
                btnPeerCount.Enabled = status;
                nmrcVerbosity.Enabled = status;
                txtCommands.Enabled = status;
                btnStartRPC.Enabled = status;
                btnAccountList.Enabled = status; 
            }
        }

        //add node to active node list and create tab page with console
        private void createTabAndConsole(NodeActivity nodeActivity)
        {
            var page = new TabPage(nodeActivity.ActiveNode.NodeName);
            var txtConsole = new TextBox();
            txtConsole.Dock = DockStyle.Fill;
            txtConsole.BorderStyle = BorderStyle.None;
            txtConsole.BackColor = Color.Black;
            txtConsole.Multiline = true;
            txtConsole.Name = "txt" + nodeActivity.ActiveNode.NodeName;
            txtConsole.ScrollBars = ScrollBars.Both;
            txtConsole.ForeColor = SystemColors.Info;
            txtConsole.BackColor = Color.FromArgb(64, 64, 64);

            txtConsole.WordWrap = false;
            txtConsole.ReadOnly = true;

            page.Controls.Add(txtConsole);
            customTabControl1.TabPages.Add(page);
            customTabControl1.SelectedTab = page;
            page.Select();

            nodeActivity.OutputConsole = txtConsole;
            nodeActivity.ParentTab = page;
        }

        #endregion
         

        #region Assertions
        private void assertDataValid()
        { 
            if (!Directory.Exists(txtNodeFolder.Text) || string.IsNullOrEmpty(txtNodeFolder.Text))
                throw new Exception("Data directory path does not exist. Create a data directory with a genesis file.");

            if (!chkPrimary.Checked && string.IsNullOrEmpty(txtPort.Text))
                throw new Exception("Empty port on secondary nodes not allowed");

            if (string.IsNullOrEmpty(txtRPCPort.Text))
                throw new Exception("RPC port cannot be empty");

            if (string.IsNullOrEmpty(txtNodeID.Text))
                throw new Exception("Node name cannot be empty");
        }
        #endregion
          
        /// <summary>
        /// creates a global node object with some default elements like verbocity and peercount
        /// </summary>
        private Node createNode()
        {
            Node activeNode=new Node();
            assertDataValid();

            activeNode = new Node();
            activeNode.IsPrimary = chkPrimary.Checked; 
            activeNode.MaxPeers = 15;
            activeNode.NodeName = txtNodeID.Text;
            activeNode.NetworkID = int.Parse(txtNetworkID.Text);
            activeNode.Port = (chkPrimary.Checked ? 30303 : int.Parse(txtPort.Text));
            activeNode.RpcPort = int.Parse(txtRPCPort.Text);
            activeNode.IPCPath = (chkPrimary.Checked ? null : "--ipcpath ~/Library/Ethereum/" + activeNode.NodeName + "/geth.ipc");
            activeNode.DataDirPath = txtNodeFolder.Text; 
             
            if (!Directory.Exists(activeNode.DataDirPath) || !File.Exists(Path.Combine(activeNode.DataDirPath, "geth.exe")))
                throw new Exception("Geth does not exist. Geth MUST exist within "+activeNode.DataDirPath + " directory.");
              
            return activeNode;
        }
         
        private void stopActivity(NodeActivity activity)
        {
            gethHelper.StopGeth(activity.ConnectedProcess);
            activity.IsRunning = false;
            btnStartStop.Text = "START";
            btnStartStop.Enabled = true; 
            gethHelper.ActiveNodeList.Remove(activity);
            toggleGethFunctionalityButtons(false, false);
            activity.WorkerThread.CancelAsync();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }
    }
}
