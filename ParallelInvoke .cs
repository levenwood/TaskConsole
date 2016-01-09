using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace TaskConsole
{
   public class ParallelInvoke
    {
       public static void Run()
       {
           string[] words = CreateWordArray(@"http://www.gutenberg.org/files/2009/2009.txt");
           Parallel.Invoke
       }
       public static string[] CreateWordArray(string url)
       {
           Console.WriteLine("Retrieving from {0}",url);
           string s = new WebClient().DownloadString(url);
           return s.Split(
                new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
                StringSplitOptions.RemoveEmptyEntries);
       }
    }
}
