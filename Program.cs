using System;
using DNS.Server;

namespace DNSserver
{
    class Program
    {
        static void Main(string[] args)
        {
            DnsServer server = new DnsServer("8.8.8.8");

            server.MasterFile.AddIPAddressResourceRecord("www.index.hu", "127.0.0.1");
            server.MasterFile.AddIPAddressResourceRecord("www.discoveri.hu", "192.168.17.60");
            

            server.Requested += serverRequested;
            server.Responded += serverResponded;

            server.Listen();

            //this should not display , because the listen function pause the thread....
            Console.WriteLine("DNS server is start... Set your pc to use this server.");
        }

        static void serverResponded(DNS.Protocol.IRequest request, DNS.Protocol.IResponse response)
        {
            //called when dns response is send
        }


        static void serverRequested(DNS.Protocol.IRequest request)
        {
            //this function called whenn DNS request is received
        }
    }
}