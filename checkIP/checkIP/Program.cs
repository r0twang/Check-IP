using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace checkIP
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry addressesIP = Dns.GetHostEntry(hostName);
            Console.WriteLine("host name: " + hostName);
            int i = 0;
            foreach (IPAddress addressIP in addressesIP.AddressList)
            {
                if (addressIP.ToString() == "127.0.0.1")
                {
                    Console.WriteLine("host is not connected to net. IP address: " + addressIP.ToString());
                }
                else
                {
                    Console.WriteLine("IP address #" + ++i + ": " + addressIP.ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
