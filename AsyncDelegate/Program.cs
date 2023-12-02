using System;
using System.Net;

namespace AsyncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var webclient = new WebClient();

            Console.Write("Téléchargement...");
            string url = "https://codeavecjonathan.com/res/bateau.jpg";
            webclient.DownloadFile(url,"bateau.jpg");
            Console.WriteLine("OK");
            
        }
    }
}
