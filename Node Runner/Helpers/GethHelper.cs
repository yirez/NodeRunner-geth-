using Node_Runner.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Node_Runner.Helpers
{
    public class GethHelper
    {
        private Form mainFormInvoker = null;
        public GethHelper(Form invokerForm)
        {
            NodeList = new List<Node>();
            NodeList = LoadActiveNodeData();

            ActiveNodeList = new List<NodeActivity>();
            mainFormInvoker=invokerForm;
        }
        public List<NodeActivity> ActiveNodeList { get; set; }
        public NodeActivity SelectedActivity { get; set; }
        public List<Node> NodeList { get; set; }

        public void SendCommandToConsole(string command, Process process)
        {
            if (SelectedActivity != null)
            {
                process.StandardInput.WriteLine(command);
                process.StandardInput.Flush();
            }
        } 

        public string FormGethStartString(Node activeNode)
        {
            StringBuilder gethChainCommand = new StringBuilder();
            //nothing in chain (no chain data), must have genesis to rebuild
            if (!Directory.Exists(Path.Combine(activeNode.DataDirPath, "dataDir")))
            {
                if (!File.Exists(Path.Combine(activeNode.DataDirPath, "CustomGenesis.json")))
                    throw new Exception("Chain needs to be initialised but CustomGenesis.json file does not exist in folder: " + Path.Combine(activeNode.DataDirPath, "dataDir"));

                MessageBox.Show("Chain needs to be initialised and CustomGenesis.json file has been found. After init completion, restart the node.", "GENESIS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                gethChainCommand.Append(" --datadir \"").Append(Path.Combine(activeNode.DataDirPath, "dataDir")).Append("\"");
                gethChainCommand.Append(" init \"").Append(Path.Combine(activeNode.DataDirPath, "CustomGenesis.json ")).Append("\"");
            }
            else
            {
                if (!activeNode.IsPrimary)
                {
                    gethChainCommand.Append(" --port ").Append(activeNode.Port);
                    gethChainCommand.Append(" --ipcpath ~/Library/Ethereum/").Append(activeNode.NodeName).Append("/geth.ipc");
                }

                if (activeNode.Verbosity > 0)
                    gethChainCommand.Append(" --verbosity ").Append(activeNode.Verbosity);

                gethChainCommand.Append(" --datadir \"").Append(Path.Combine(activeNode.DataDirPath, "dataDir")).Append("\"")
                .Append(" --identity ").Append(activeNode.NodeName);


                gethChainCommand.Append(" --networkid ").Append(activeNode.NetworkID)
                .Append(" --rpcport ").Append(activeNode.RpcPort);

                if (activeNode.MaxPeers > 0)
                    gethChainCommand.Append(" --maxpeers ").Append(activeNode.MaxPeers);
            } 
            gethChainCommand.Append(" console ");

            return gethChainCommand.ToString();
        } 

        public void SaveActiveNodeData(Node node)
        {
            if (NodeList != null && !NodeList.Any(x => x.NodeName.Equals(node.NodeName, StringComparison.InvariantCultureIgnoreCase)))
            {
                NodeList.Add(node);
                XmlSerializer xs = new XmlSerializer(typeof(List<Node>));
                TextWriter tw = new StreamWriter("nodeList.xml");
                xs.Serialize(tw, NodeList);
                tw.Close();
            }
            NodeList = LoadActiveNodeData();
        }

        public List<Node> LoadActiveNodeData()
        {
            if (!File.Exists("nodeList.xml"))
                return new List<Node>();

            XmlSerializer xs = new XmlSerializer(typeof(List<Node>));
            using (var sr = new StreamReader("nodeList.xml"))
            {
                return (List<Node>)xs.Deserialize(sr);
            }
        }

        /// <summary>
        /// starts geth with a string formed with global node object
        /// </summary>
        public void StartGeth(NodeActivity nodeActivity)
        {
            string gethStartCommand = FormGethStartString(nodeActivity.ActiveNode); 
            StartContainerCommandProcess(gethStartCommand, nodeActivity);
        }

        /// <summary>
        /// forces geth exit and closes process
        /// </summary>
        public void StopGeth(Process process)
        {
            try
            {
                SendCommandToConsole("exit", process); 
                process.StandardInput.Close();
                process.Close();
            }
            catch { }
        }

        public void StartContainerCommandProcess(string parameters, NodeActivity nodeActivity)
        {
            Process process = new Process();
            nodeActivity.ConnectedProcess = process;

            process.StartInfo.FileName = Path.Combine(nodeActivity.ActiveNode.DataDirPath, "geth.exe");
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
                    if (nodeActivity.IsRunning)
                        mainFormInvoker.Invoke(new Action(() => nodeActivity.OutputConsole.AppendText(e.Data + Environment.NewLine)));
                };
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (nodeActivity.IsRunning)
                        mainFormInvoker.Invoke(new Action(() => nodeActivity.OutputConsole.AppendText(e.Data + Environment.NewLine)));
                };


                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
        }

    }
}
