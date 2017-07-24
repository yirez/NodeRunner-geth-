using Node_Runner.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Node_Runner
{
    public class Node
    {
        public int NetworkID { get; set; }
        public string NodeName { get; set; } 
        public string DataDirPath { get; set; }
        public int RpcPort { get; set; }
        public int Port { get; set; }
        public string IPCPath { get; set; }
        public int MaxPeers { get; set; }
        public int Verbosity { get; set; }
        public RPCExposeData RPCData { get; set; }
        public bool IsPrimary { get; set; }
    }
}
