using System;
using System.IO;
using System.Net;

namespace lab_51__httpcalling
{
    class Program
    {
        static Uri url = new Uri("https://www.google.com");
        static void Main(string[] args)
        {
            //GetData();
            //GetDataAsync();
            GetDataJson();


        }

        static void GetDataJson()
        {
            var url = new Uri("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");
            var webclient = new WebClient { Proxy = null };
            var jsonData = webclient.DownloadString(url);
            Console.WriteLine(jsonData);
        }

        static void GetData()
        {
            var webclient = new WebClient { Proxy = null };
            webclient.DownloadFile(url, "myWebpage1.html");
        }

        async static void GetDataAsync()
        {

            var webclient = new WebClient { Proxy = null };
            webclient.DownloadFileAsync(url, "myWebpage2.html");
            var myWebpage = await webclient.DownloadStringTaskAsync(url);
            File.WriteAllText("myWebPage2.html", myWebpage);
            Console.WriteLine(myWebpage);
        }
    }
}
