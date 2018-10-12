using System;

namespace GramOunceServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(7);
            server.Start();
            Console.ReadLine();
        }
    }
}
