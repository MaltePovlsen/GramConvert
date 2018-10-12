using System;
using System.IO;
using System.Net.Sockets;

namespace GramOunceClient
{
    public class Client
    {
        private readonly string connectToHost;
        private readonly int connectToPort;

        public Client(string connectToHost, int connectToPort)
        {
            this.connectToHost = connectToHost;
            this.connectToPort = connectToPort;
        }

        public void Start()
        {
            using (TcpClient clientSocket = new TcpClient(connectToHost, connectToPort))
            using (StreamReader sr = new StreamReader(clientSocket.GetStream()))
            using (StreamWriter sw = new StreamWriter(clientSocket.GetStream()))
            {
                // read from console
                Console.Write("Type TOGRAM (value) or TOOUNCES (value) : ");
                String str = Console.ReadLine();

                // send to server
                sw.WriteLine(str);
                sw.Flush();

                // read response from server
                String inStr = sr.ReadLine();
                Console.WriteLine("From server: " + inStr);
                Console.ReadLine();

            }
            ;
        }
    }
}