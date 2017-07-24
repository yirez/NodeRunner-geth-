using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Node_Runner.Base
{
    public class NodeActivity
    {
        public Node ActiveNode { get; set; }
        public bool IsRunning { get; set; }
        public TextBox OutputConsole { get; set; }
        public TabPage ParentTab { get; set; }
        public BackgroundWorker WorkerThread { get; set; }
        public Process ConnectedProcess { get; set; }
    }
}
