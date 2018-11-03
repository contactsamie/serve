using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Net.Mime;
    using System.Net.Sockets;
    using System.Reflection;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var loc = Assembly.GetEntryAssembly().Location;
            //create server with auto assigned port
            var myServer = new SimpleHttpServer(System.IO.Path.GetDirectoryName(loc));
            Process.Start("http://localhost:" + myServer.Port);
            Console.ReadKey();
        }
    }
  
}
