using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineParserTest
{
    public class CommandlineOptions
    {
        [Option('h', "host", Default = "localhost", HelpText = "Hostname on to listen")]
        public String Host { get; set; }

        [Option('p', "port", Default = 9876, HelpText = "Port HTTP proxy will be listening to", Required = false)]
        public Int32 HttpPort { get; set; }
    }
}
