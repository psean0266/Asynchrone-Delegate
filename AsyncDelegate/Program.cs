using System;
using System.Net;
using System.Threading;

namespace AsyncDelegate
{
    class Program
    {
      static bool downloading = false;
        static void Main(string[] args)
        {
            var webclient = new WebClient();

            Console.Write("Téléchargement...");
            string url = "https://codeavecjonathan.com/res/bateau.jpg";
            //  webclient.DownloadFile(url,"bateau.jpg");

            webclient.DownloadFileCompleted += Webclient_DownloadFileCompleted;
            webclient.DownloadFileAsync(new Uri(url), "bateau.jpg");

            while (downloading)
            {
                Thread.Sleep(500);

                if (downloading)
                {
                    Console.Write(".");
                }
               
            }

            Console.WriteLine("FIN DU PROGRAMME");

            
        }

        private static void Webclient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Telechargement terminé");
            downloading = false;
        }
    }
}
