using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace USG_backend_console
{
    static class GlobalSettings
    {
        public static TcpListener serverSocket = null;
        public static TcpClient clientSocket = null;
        public static TCPconnection paramConn = null;
        public static NetworkStream stream = null;
        public static StreamReader reader = null;
        public static StreamWriter writer = null;
    }
}
