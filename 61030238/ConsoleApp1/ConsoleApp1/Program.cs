using System;
using System.Net;  // for web client
using System.IO;   // for stream writer
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create web client.
            WebClient client = new WebClient();
            // Download string.
            string value = client.DownloadString("http://www.kmitl.ac.th");
            // Write values.
            Console.WriteLine("--- WebClient result ---");
            Console.WriteLine(value.Length);
            Console.WriteLine(value);
            StreamWriter outtxt = new StreamWriter("webload.html");
            outtext.Write(value);
            outtxt.Dispose();
        }
    }
}
