using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace lab_51_Http_Calling_Data_From_Internet
{
    class Program
    {
        //static Uri url = new Uri("https://www.google.com");
        //static Uri url = new Uri("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");
        static Uri url = new Uri("https://localhost:44335/api/Customers");

        


        static void Main(string[] args)
        {
            // get web page synchrously
            Console.WriteLine("Program Has Started");
            //GetData();
            //GetDataAsync();
            GetDataJson();
            Console.WriteLine("Program Has Ended");
            Console.WriteLine("Async data is now arriving from the internet");
            Console.ReadLine();
        }

        static void GetData()
        {
            // proxy is used as an agent middleman computer (not used here)
            var webclient = new WebClient { Proxy = null };
            webclient.DownloadFile(url, "myWebPage.html");
            // print to screen
            //Console.WriteLine(File.ReadAllText("myWebPage.html"));
        }


        async static void GetDataAsync()
        {
            // repeat async
            var webclient = new WebClient { Proxy = null };
            //webclient.DownloadFileAsync(url, "myWebPage2.html");  // missing 'async' keyword
            //Console.WriteLine(File.ReadAllText("myWebPage2.html"));
            var myWebPage3 = await webclient.DownloadStringTaskAsync(url); // this is proper async
            File.WriteAllText("myWebPage3.html", myWebPage3);
            Console.WriteLine(myWebPage3);

        }

        static void GetDataJson()
        {
            
            var webclient = new WebClient { Proxy = null };
            var jsonData = webclient.DownloadString(url);
            Console.WriteLine(jsonData);
        }

        static async Task<string> GetStringAsync()
        {
            return null;
           
        }

    }
}
