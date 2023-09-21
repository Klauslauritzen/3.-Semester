using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AuctionHouseServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            SocketServer.ExecuteServer();
        }
    }
}