using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GramConvert;

namespace GramOunceServer
{
    public class Server
    {
        GramOunce G = new GramOunce();
        private readonly int pORT;

        public Server(int pORT)
        {
            this.pORT = pORT;
        }

        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, pORT);
            serverListener.Start();

            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        private void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string[] incommingstr = sr.ReadLine().Split(' ');
                if (incommingstr[0].Contains("TOOUNCES"))
                {
                    sw.WriteLine(G.GramToOunce(Convert.ToDouble(incommingstr[1])));
                    sw.Flush();
                }
                else if (incommingstr[0].Contains("TOGRAM"))
                {
                    
                    sw.WriteLine(G.OunceToGram(Convert.ToDouble(incommingstr[1])));
                    sw.Flush();
                }
            }
        }
    }
}