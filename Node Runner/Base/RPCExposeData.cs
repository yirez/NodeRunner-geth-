using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Node_Runner.Base
{
    public class RPCExposeData
    {
        //network interface to open the listener socket on (defaults to "local machine ip")
        string Host { get; set; }

        //network port to open the listener socket on (defaults to 8545)
        string Port { get; set; }

        //cross-origin resource sharing header to use (defaults to "*")
        string Cors { get; set; }

        // API modules to offer over this interface (defaults to "eth,net,web3")
        string APIs { get; set; }
    }
}
